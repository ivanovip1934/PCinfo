﻿using PCInfo.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCinfo
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            PCInfo pCInfo = new PCInfo();
            Model model = new Model();
            MainPresenter mainPresenter = new MainPresenter(pCInfo,model);
            Application.Run(pCInfo);
        }
    }
}
