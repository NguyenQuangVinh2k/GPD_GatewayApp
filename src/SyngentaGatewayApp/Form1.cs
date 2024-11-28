
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SyngentaGatewayApp.AppCore;
using SyngentaGatewayApp.Entity;
using System.Drawing.Drawing2D;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SyngentaGatewayApp
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        #region Singleton parttern
        private static Form1 _Instance = null;
        public AppCore.AppCore app = new AppCore.AppCore();
        public static Form1 Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new Form1();
                }
                return _Instance;
            }
        }
        #endregion  
        public byte[] InternalToken;
        private async void btnOpenSer_Click(object sender, EventArgs e)
        {

        }
        private void btnCloseSer_Click(object sender, EventArgs e)
        {


        }
        private void bntServerRead_Click(object sender, EventArgs e)
        {

        }

        private void btnServerSend_Click(object sender, EventArgs e)
        {

        }



        private void btnConnectPrinter_Click(object sender, EventArgs e)
        {

        }
        private void btnDisconnectPrinter_Click(object sender, EventArgs e)
        {

        }
        private void btnSendPrinter_Click(object sender, EventArgs e)
        {
        }

        private async Task btnReadPrinter_ClickAsync(object sender, EventArgs e)
        {
           
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var data = await AppCore.AppCore.Ins.getTokenServer();
                Root1 myDeserializedClass = JsonConvert.DeserializeObject<Root1>(data);
                InternalToken = Encoding.ASCII.GetBytes(myDeserializedClass.res.token.token);
                MessageBox.Show("Get token success !!!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + $"\r\n{ex.StackTrace}");
            }

        }

        private async void button2_ClickAsync(object sender, EventArgs e)
        {
            try
            {
                var URL = txtURL.Text.Trim(); 
                MessageBox.Show("Token: " + Encoding.ASCII.GetString(InternalToken));
                var data = await AppCore.AppCore.Ins.CallBatchList(URL, InternalToken);
                txtServerSend.Text = data;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + $"\r\n{ex.StackTrace}");
            }
        }
    }
}
