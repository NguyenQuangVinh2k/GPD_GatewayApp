using GPD_App.Common;
using IoTClient.Clients.PLC;
using IoTClient.Enums;
using iSoft.Common.Utils;
using SuperSimpleTcp;
using SyngentaGatewayApp.Database;
using SyngentaGatewayApp.DeserializedClass;
using SyngentaGatewayApp.Events;
using SyngentaGatewayApp.Factory;
using SyngentaGatewayApp.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using DataReceivedEventArgs = SuperSimpleTcp.DataReceivedEventArgs;

namespace SyngentaGatewayApp.AppCore
{
    public partial class AppCore
    {
        private static AppCore _ins = new AppCore();

        string GatewayIp = Environment.GetEnvironmentVariable("SERVER_IP");
        string GatewayPort = Environment.GetEnvironmentVariable("SERVER_PORT");
        string PrinterIp = Environment.GetEnvironmentVariable("PRINTER_IP");
        string PrinterPort = Environment.GetEnvironmentVariable("PRINTER_PORT");
        string name = "Printer";
        public GatewayServices _gatewayServices = new GatewayServices();
        public GetBatchServices _getBatchServices = new GetBatchServices();

        public PlcServices _PlcServices = new PlcServices();

        public RabbitService _rabbitService = new RabbitService();

        public MitsubishiClient? _client { get; set; }
        private bool isConnectedPLC;
        string PlcIp = Environment.GetEnvironmentVariable("PLC_IP");
        string PlcPort = Environment.GetEnvironmentVariable("PLC_PORT");
        public System.Timers.Timer timer_checkReadtPLC = new System.Timers.Timer();
        public System.Timers.Timer timer_checkReadtPLC_DB = new System.Timers.Timer();
        public System.Timers.Timer timer_checkConnectPLC = new System.Timers.Timer();




        
        public static AppCore Ins
        {
            get
            {
                return _ins == null ? _ins = new AppCore() : _ins;
            }
        }
        public AppCore()
        {
            var process = Process.GetProcessesByName($"{Assembly.GetEntryAssembly().GetName().Name}");
            if (process.Length > 1)
            {
                process[1].Kill();
            }
        }

        public async Task Init()
        {
            //CreateLog();
            _rabbitService.ConfigsRabbitMQ();
            _rabbitService.PushMessage(Encoding.ASCII.GetBytes("Connecting_Rabbit"));
            await InitDB();
            InitGateway();
            await InitPLC();
            InitEvents();
            StartShowUI();
        }
        public async Task InitDB() 
        {
            DatabaseServices.Init(); 
        }
        public async Task InitGateway() 
        {
            try
            {
                _gatewayServices.InitOpenServer(GatewayIp, int.Parse(GatewayPort));
                _gatewayServices.InitConnectPrinter(PrinterIp,int.Parse(PrinterPort));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString() + ex.StackTrace);
                throw ex;
            }
        }

        public async Task InitPLC()
        {
            try
            {
                if (PlcIp != null && PlcPort != null)
                {
                    _client = new MitsubishiClient(MitsubishiVersion.Qna_3E, PlcIp, int.Parse(PlcPort));
                    _client.Open();
                }

                timer_checkConnectPLC.Interval = 1000;
                timer_checkConnectPLC.Elapsed += Timer_checkConnectPLC_Elapsed;
                timer_checkConnectPLC.Start();

                timer_checkReadtPLC.Interval = 500;
                timer_checkReadtPLC.Elapsed += Timer_checkReadPLC_Elapsed;
                timer_checkReadtPLC.Start();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString() + ex.StackTrace);
                throw ex;
            }
        }

        private void Timer_checkConnectPLC_Elapsed(object? sender, ElapsedEventArgs e)
        {
            if (PlcIp == null && PlcPort == null) return;
            timer_checkConnectPLC.Stop();
            try
            {
                lock (this)
                {
                    if (_client != null)
                    {
                        _client.Close();
                    }
                    _client = new MitsubishiClient(MitsubishiVersion.Qna_3E, PlcIp, int.Parse(PlcPort));
                    _client.Open();
                    isConnectedPLC = _client.Connected;         
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString() + ex.StackTrace);
                throw ex;
            }
            finally
            {
                timer_checkConnectPLC.Start();
            }
        }
        private void Timer_checkReadPLC_Elapsed(object? sender, ElapsedEventArgs e)
        {
            try
            {
                if (isConnectedPLC)
                {
                    if (_client != null)
                    {
                        ushort Start = 1000;
                        ushort Length = 1;
                        var currentLossCode = _PlcServices.ReadValuePLC(_client, Start, Length);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString() + ex.StackTrace);
                throw ex;
            }
            finally
            {
                timer_checkReadtPLC.Start();
            }
        }
        public async Task ResetCounter(uint Start)
        {
            try
            {
                if (isConnectedPLC)
                {
                    if (_client != null)
                    {
                        bool trigger = true;
                        bool reset = false;
                        _PlcServices.SendDataPLC(_client, Start, trigger);
                        _PlcServices.SendDataPLC(_client, Start, reset);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString() + ex.StackTrace);
                throw ex;
            }
            finally
            {
                timer_checkReadtPLC.Start();
            }
        }

        public void InitEvents()
        {
            try
            {
                _gatewayServices.OnChangeOver += GatewayServices_OnChangeOver1;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString() + ex.StackTrace);
                throw ex;
            }
           
        }
        private async Task GatewayServices_OnChangeOver1(uint Address)
        {
            await ResetCounter(Address);
            _getBatchServices.ChangeOver();
        }
        public void CreateLog()
        {
            lock (this)
            {
                string logFilePath = $"{Environment.GetEnvironmentVariable("FOLDER_PATH")}log_{System.DateTime.Now.ToString("yyyyMMdd")}.txt";
                try
                {
                    if (!File.Exists(logFilePath))
                    {
                        using (var stream = File.Create(logFilePath)) { }
                    }
                }
                catch (Exception ex)
                {
                    WriteLogToFile(ex.Message + ex.StackTrace.ToString());
                    throw ex;
                }
            }

        }
        public void WriteLogToFile(string logEntry)
        {
            lock (this)
            {
                try
                {
                    string logFilePath = $"{Environment.GetEnvironmentVariable("FOLDER_PATH")}log_{System.DateTime.Now.ToString("yyyyMMdd")}.txt";
                    File.AppendAllText(logFilePath, logEntry + Environment.NewLine);
                }
                catch (Exception ex)
                {
                    WriteLogToFile(ex.Message + ex.StackTrace.ToString());
                    throw ex;
                }
            }

        }

    }
}
