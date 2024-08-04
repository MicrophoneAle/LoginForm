using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace LoginFormProject
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new LoginForm());

        }
    }
}