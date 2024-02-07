using PCInfo.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCinfo
{
    internal class MainPresenter
    {

        private readonly IPCinfo _view;
        private readonly IModel _model;
       
        public MainPresenter(IPCinfo view, IModel model)
        {
            _view = view;
            _model = model;
            SetInfoArm();
            _view.NetTestClick += _view_NetTestClick;
        }

        private void SetInfoArm() {
            PCInfoData pCInfoData = _model.GetInfo();
            _view.SetUserName(pCInfoData.UserName);
            _view.SetPCName(pCInfoData.PCName);
            _view.SetAddress(pCInfoData.Address);
        }

        private void _view_NetTestClick(object sender, EventArgs e)
        {
            _view.SetLocalNet(_model.ConnectionISGood("172.16.0.100"));
            _view.SetNetwork(_model.ConnectionISGood("ya.ru"));
            _view.SetEMTS(_model.ConnectionISGood("10.10.51.1"));           
        }
    }
}
