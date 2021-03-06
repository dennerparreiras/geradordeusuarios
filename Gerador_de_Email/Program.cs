﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gerador_de_Email
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            bool admin = false;
            if (args.Length > 0)
                admin = (args[0] == "--admin") ? true : false;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MainForm formularioPrincipal = new MainForm(admin);
            Application.Run(formularioPrincipal);
        }
    }
}
