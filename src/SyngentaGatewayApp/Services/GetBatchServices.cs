using iSoft.Common.Utils;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SyngentaGatewayApp.DeserializedClass;
using SyngentaGatewayApp.Entity;
using System;
using System.Collections.Generic;
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
        string LogginUrl = "https://auth.i-soft.com.vn/api/v1/auths/login";
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
        public async Task InitLoginWebHost()
        {
            try
            {
                //PingJeksonHost();
                //if (isConnectWebApp)
                //{
                    _token = await GetToken(LogginUrl, WebUsername, WebPassword);
                    CallGetsListBatch(_token);
                //}
                //else 
                //{
                    //Console.WriteLine("Disconnect Server");
                    //Console.ReadLine();
                //}
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString() + ex.StackTrace);
                throw ex;
            }

        }
        public async Task<byte[]> GetToken(string Url, string UserName, string Password)
        {
            try
            {
                var req = new LoginRequestModel()
                {
                     Username="admin6",
                     Password= "g73acCChdeozEND9MvWAIPFM4XGSfHKBOYv9IvRCYA8"
                };
                var AuthData = await HttpUtil.PostDataAsForm(Url, null, req);
                //if (AuthData == null || AuthData.Status == "FAIL") return null;
                //return Encoding.ASCII.GetBytes(AuthData.Data.AccessToken);
                TestAPI myDeserializedClass = JsonConvert.DeserializeObject<TestAPI>(AuthData);
                return Encoding.ASCII.GetBytes(myDeserializedClass.Data.AccessToken);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString() + ex.StackTrace);
                throw ex;

            }
        }
        public async Task CallGetsListBatch(byte[] token)
        {
            try
            {
                var ListBatch = await HttpUtil.GetData<Root>(WebUrlGetBatch, token);
                var data = ListBatch;
                if (ListBatch == null || ListBatch.Status == "401")
                {
                    InitLoginWebHost();
                };

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString() + ex.StackTrace);
                InitLoginWebHost();
            }
        }


        public void ChangeOver()
        {
            CallGetsListBatch(_token);
        }
    }
}
