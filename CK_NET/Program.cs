using CK_NET.ViewHoaDon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CK_NET
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // form test khong can dung Application.Run(new Form1());
            //Application.Run(new frmDanhSachAssets());
            //Application.Run(new frmDanhSachUser());
            Application.Run(new Login());
        }
    }
}
