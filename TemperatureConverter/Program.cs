/*
 * Licensed under MIT License. Copyright (c) 2017 Matthew Wright. See LICENSE.txt in solution root for further details.
 */

using System;
using System.Windows.Forms;

namespace TemperatureConverter
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmConverter());
        }
    }
}
