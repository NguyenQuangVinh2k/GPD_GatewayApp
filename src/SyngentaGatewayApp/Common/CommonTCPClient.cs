using SuperSimpleTcp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace GPD_App.Common
{
    public class CommonTCPClient
    {
        string _ServerIp;
        int _ServerPort;
        bool _Ssl;
        public string Name;
        SimpleTcpClient _Client;
        public bool Connected => _Client != null && _Client.IsConnected;
        public event EventHandler<ConnectionEventArgs> OnConnectionEventRaise;
        public event EventHandler<DataReceivedEventArgs> OnDataReceive;
        public CommonTCPClient(string host, int port, string name, bool _ssl = false)
        {
            Init(host, port, name);
        }
        public void Connect()
        {
            try
            {
                _Client.Connect();
            }
            catch (Exception ex)
            {
            }
        }
        public void Disconnect()
        {
            try
            {
                _Client.Disconnect();
                //_Client.DisconnectAsync()
            }
            catch (Exception ex)
            {

            }
        }
        public void Init(string host, int port, string Name, bool _ssl = false)
        {
            _ServerIp = host;
            _ServerPort = port;
            _Ssl = _ssl;
            this.Name = Name;
            _Client = new SimpleTcpClient(_ServerIp, _ServerPort);

            _Client.Events.Connected += ConnectedHandler;
            _Client.Events.Disconnected += Disconnected;
            _Client.Events.DataReceived += DataReceived;
            _Client.Events.DataSent += DataSent;
            _Client.Keepalive.EnableTcpKeepAlives = true;
            _Client.Settings.MutuallyAuthenticate = false;
            _Client.Settings.AcceptInvalidCertificates = true;
            _Client.Settings.ConnectTimeoutMs = 300;
            _Client.Settings.NoDelay = true;

        }

        private void ConnectedHandler(object sender, ConnectionEventArgs e)
        {
            Console.WriteLine("*** Server " + e.IpPort + " connected");
            OnConnectionEventRaise?.Invoke(sender, e);
        }

        public void Disconnected(object sender, ConnectionEventArgs e)
        {
            Console.WriteLine("*** Server " + e.IpPort + " disconnected");
            OnConnectionEventRaise?.Invoke(sender, e);
        }

        public void DataReceived(object sender, DataReceivedEventArgs e)
        {
            OnDataReceive?.Invoke(sender, e);
        }

        private static void DataSent(object sender, DataSentEventArgs e)
        {
            //Console.WriteLine("[" + e.IpPort + "] sent " + e.BytesSent + " bytes");
        }
        public void Send(byte[] data)
        {
            if (_Client == null || !_Client.IsConnected) throw new Exception("Socket Server Can Not Be Connect");
            _Client.Send(data);
        }

        public async Task SendAsync(byte[] data)
        {
            if (_Client == null || !_Client.IsConnected) throw new Exception("Socket Server Can Not Be Connect");
            await _Client.SendAsync(data);
        }

        public void Logger(string msg)
        {
            Console.WriteLine(msg);
        }

    }
}
