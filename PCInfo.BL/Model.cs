using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace PCInfo.BL
{
    public interface IModel {
        PCInfoData GetInfo();
        bool ConnectionISGood(string host);
    }

    public class Model:IModel
    {
        public PCInfoData GetInfo()
        {
            PCInfoData pcinfo = new PCInfoData();
            pcinfo.PCName = WindowsIdentity.GetCurrent().Name.Replace("OMSU\\", "");
            pcinfo.PCName = Environment.MachineName;
            pcinfo.Address = ShowIPv4Address();
            return pcinfo;

        }
        private  List<string> ShowIPv4Address()
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
        public  bool ConnectionISGood(string host)
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

    }
}
