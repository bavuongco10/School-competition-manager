using System;
using System.Windows.Forms;
using DevExpress.Skins;
using DevExpress.UserSkins;
using DevExpress.XtraEditors;

namespace OOP
{
    internal static class Program
    {
        /// <summary>
        ///     The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            WindowsFormsSettings.SetDPIAware();
            SkinManager.EnableFormSkins();
            BonusSkins.Register();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
    }
}