using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCinfo
{
    public partial class PCInfo : Form
    {
        List<string> ipadress;
        public PCInfo()
        {
            
            InitializeComponent();
            GetInfo();

        }

       

        

        private static bool ConnectionISGood(string host)
        {              //host is ip or dns name


            Ping pingSender = new Ping();
            PingOptions options = new PingOptions();

            options.DontFragment = false;

            // Create a buffer of 32 bytes of data to be transmitted.
            string data = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            byte[] buffer = Encoding.ASCII.GetBytes(data);
            int timeout = 120;
            try
            {

                PingReply reply = pingSender.Send(host, timeout, buffer, options);
                if (reply.Status == IPStatus.Success)
                    return true;
                else
                    return false;
            }
            catch
            {
                return false;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            bool flag = ConnectionISGood("172.16.0.100");
            this.lbllocalnet.Text = flag ? "ДА" : "НЕТ";
            this.lbllocalnet.ForeColor= flag ? Color.Green: Color.Red;

            flag = ConnectionISGood("ya.ru");
            this.lblglobalnet.Text = flag ? "ДА" : "НЕТ";
            this.lblglobalnet.ForeColor = flag ? Color.Green: Color.Red;

            flag = ConnectionISGood("10.10.51.1");
            this.lblEMTS.Text =  flag ? "ДА" : "НЕТ";
            this.lblEMTS.ForeColor = flag ? Color.Green: Color.Red;

            this.lbllocalnet.Visible = true;
            this.lblglobalnet.Visible = true;
            this.lblEMTS.Visible = true;
        }

       
    }
}
