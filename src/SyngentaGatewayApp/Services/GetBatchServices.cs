using iSoft.Common.ExtensionMethods;
using iSoft.Common.Utils;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SyngentaGatewayApp.DeserializedClass;
using SyngentaGatewayApp.Entity;
using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace SyngentaGatewayApp.Services
{
    public class GetBatchServices
    {
        private bool isConnectWebApp;
        private byte[] _token;
        string WebIpAddress = Environment.GetEnvironmentVariable("WEB_IP");
        string WebPort = Environment.GetEnvironmentVariable("WEB_PORT");
        string WebUsername = Environment.GetEnvironmentVariable("WEB_USERNAME");
        string WebPassword = Environment.GetEnvironmentVariable("WEB_PASSWORD");
        string WebUrlGetBatch = Environment.GetEnvironmentVariable("WEB_URL_GET_BATCH");
        string LoginUrl = "http://192.168.10.15:8080/TrackAndTraceServer/token/getUserByUsername?username=operator";
        public void PingJeksonHost()
        {
            try
            {
                isConnectWebApp = HttpUtil.PingHost(WebIpAddress, int.Parse(WebPort));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString() + ex.StackTrace);
                throw ex;
            }
        }
        public async Task<string> GetToken(string Url, string UserName, string Password)
        {
            try
            {
                var req = new LoginRequestModel()
                {
                    Username = "operator",
                    Password = "Syngenta2@"
                };
                MessageBox.Show($"Account:{req.ToJson()}");
                var AuthData = await HttpUtil.PostData(Url, req.ToJson());
                if (AuthData == null)
                {
                    throw new Exception("AuthData null");
                }
                else
                {
                    MessageBox.Show(AuthData.ToString());
                }
                return AuthData.ToJson();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<string> GetBatchList(string Url,byte[] token) 
        {
            try
            {
                var Data = await HttpUtil.GetData(Url, token);
               
                if (Data == null)
                {
                    throw new Exception("Data null");
                }
                else
                {
                    MessageBox.Show(Data);
                }
                return Data;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}
