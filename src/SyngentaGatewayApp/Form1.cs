
using SyngentaGatewayApp.AppCore;
using System.Text;
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

        private void btnReadPrinter_Click(object sender, EventArgs e)
        {
 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AppCore.AppCore.Ins.ResetCounter(2);
        }
    }
}
