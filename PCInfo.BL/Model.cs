using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace PCInfo.BL
{
    public interface IModel {
        void GetInfo();
    }

    public class Model:IModel
    {
        public void GetInfo()
        {
            //this.lblusername.Text = WindowsIdentity.GetCurrent().Name.Replace("OMSU\\", "");
            this.lblpcname.Text = Environment.MachineName;
            this.ipadress = ShowIPv4Address();
            this.lblipadress.Text = String.Empty;

            foreach (string ip in ipadress)
            {

                this.lblipadress.Text += $"{ip}\n";
            }

            this.lblpcname.Visible = true;
            this.lblusername.Visible = true;
            this.lblipadress.Visible = true;

        }
        private static List<string> ShowIPv4Address()
        {

            List<string> IpAddress = new List<string>();
            NetworkInterface[] adapters = NetworkInterface.GetAllNetworkInterfaces();
            NetworkInterface[] etheradapters = adapters.Where(a => a.NetworkInterfaceType == NetworkInterfaceType.Ethernet).ToArray();
            if (etheradapters != null)
                foreach (NetworkInterface ad in etheradapters)
                {
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

    }
}
