using PCinfo;
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
    public interface IPCinfo
    {
        void SetUserName(string userName);
        void SetPCName(string pcName);
        void SetAddress(List<string> address);
        void SetLocalNet(bool flag);
        void SetNetwork(bool flag);
        void SetEMTS(bool flag); 

        event EventHandler NetTestClick;

    }


    public partial class PCInfo : Form, IPCinfo
    {

        public PCInfo()
        {
            InitializeComponent();

            this.butTestNet.Click += ButTestNet_Click;           

        }

        

        public void SetUserName(string userName)
        {
            this.lblusername.Text = userName;
            this.lblusername.Visible = true;

        }
        public void SetPCName(String pcName)
        {
            this.lblpcname.Text = pcName;
            this.lblpcname.Visible = true;
        }
        public void SetAddress(List<string> address)
        {
            this.lblipadress.Text = String.Empty;
            foreach (string addressItem in address)
            {
                this.lblipadress.Text += $"{addressItem}\n";                
            }
            this.lblipadress.Visible = true;
        }
        public void SetLocalNet (bool flag)          
        {
            this.lbllocalnet.Text = flag==true?"ДА":"НЕТ";
            this.lbllocalnet.ForeColor = flag ? Color.Green : Color.Red;
            this.lbllocalnet.Visible = true;
        }
        public void SetNetwork(bool flag)
        {
            this.lblglobalnet.Text = flag == true ? "ДА" : "НЕТ";
            this.lblglobalnet.ForeColor = flag ? Color.Green : Color.Red;
            this.lblglobalnet.Visible = true;
        }
        public void SetEMTS(bool flag)
        {
            this.lblEMTS.Text = flag == true ? "ДА" : "НЕТ";
            this.lblEMTS.ForeColor = flag ? Color.Green : Color.Red;
            this.lblEMTS.Visible = true;
        }

        public event EventHandler NetTestClick;

        private void ButTestNet_Click(object sender, EventArgs e)
        {
             NetTestClick?.Invoke(this, EventArgs.Empty);
        }
    }
}




//private void button2_Click(object sender, EventArgs e)
//    {

//        bool flag = ConnectionISGood("172.16.0.100");
//        this.lbllocalnet.Text = flag ? "ДА" : "НЕТ";
//        this.lbllocalnet.ForeColor= flag ? Color.Green: Color.Red;

//        flag = ConnectionISGood("ya.ru");
//        this.lblglobalnet.Text = flag ? "ДА" : "НЕТ";
//        this.lblglobalnet.ForeColor = flag ? Color.Green: Color.Red;

//        flag = ConnectionISGood("10.10.51.1");
//        this.lblEMTS.Text =  flag ? "ДА" : "НЕТ";
//        this.lblEMTS.ForeColor = flag ? Color.Green: Color.Red;

//        this.lbllocalnet.Visible = true;
//        this.lblglobalnet.Visible = true;
//        this.lblEMTS.Visible = true;
//    }


//}

