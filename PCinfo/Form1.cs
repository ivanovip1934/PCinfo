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
    public partial class Form1 : Form
    {
        List<string> ipadress;
        public Form1()
        {
            
            InitializeComponent();
            GetInfo();

        }

        private void GetInfo()
        {
            this.labelusername.Text =WindowsIdentity.GetCurrent().Name.Replace("OMSU\\","");
            this.labelpcname.Text = Environment.MachineName;
            this.ipadress = ShowIPv4Address();
            this.labelipadress.Text = String.Empty;
            
            foreach (string ip in ipadress) {

                this.labelipadress.Text +=$"{ip}\n";
            }
            
            this.labelpcname.Visible = true;
            this.labelusername.Visible = true;
            this.labelipadress.Visible = true;
            
        }

        private static  List<string> ShowIPv4Address()
        {

            List<string> IpAddress = new List<string>();
            NetworkInterface[] adapters = NetworkInterface.GetAllNetworkInterfaces();
            NetworkInterface[] etheradapters = adapters.Where(a => a.NetworkInterfaceType == NetworkInterfaceType.Ethernet).ToArray();
            if (etheradapters != null)
                foreach (NetworkInterface ad in etheradapters) {                
                    {
                        foreach (UnicastIPAddressInformation ip in ad.GetIPProperties().UnicastAddresses)
                        {
                            if (ip.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                            {
                                //Console.WriteLine($"{ip.Address}");
                                IpAddress.Add(ip.Address.ToString());
                            }
                        }
                    }
                }
            return IpAddress;
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
            this.labellocalnet.Text = flag ? "ДА" : "НЕТ";
            this.labellocalnet.ForeColor= flag ? Color.Green: Color.Red;

            flag = ConnectionISGood("ya.ru");
            this.labelglobalnet.Text = flag ? "ДА" : "НЕТ";
            this.labelglobalnet.ForeColor = flag ? Color.Green: Color.Red;

            flag = ConnectionISGood("10.10.51.1");
            this.labelemtsnet.Text =  flag ? "ДА" : "НЕТ";
            this.labelemtsnet.ForeColor = flag ? Color.Green: Color.Red;

            this.labellocalnet.Visible = true;
            this.labelglobalnet.Visible = true;
            this.labelemtsnet.Visible = true;
        }

       
    }
}
