using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDREJ_1._5
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }

    //The variable Lang is the language of the program
    static class Lang
    {
        public static string Value { get; set; }
    }

    //Variable RegistyK - registry
    static class RegistyK
    {
        public static RegistryKey reg = Registry.CurrentUser;
    }

    //?????
    static class Window
    {
        public static int Value { get; set; }
    }
}
