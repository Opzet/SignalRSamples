﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wisej.Web;

namespace SignalrServer
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        ///[STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            Application.MainPage = new FrmServer();
        }
    }
}
