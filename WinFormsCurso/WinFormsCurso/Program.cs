using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsCurso
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
            //Application.Run(new Frm_HelloWorld());
            //Application.Run(new Frm_DemonstracaoKey());
            //Application.Run(new Frm_ValidaSenha());
            //Application.Run(new Frm_Mascara());
            //Application.Run(new Frm_ValidaCPF());
            //Application.Run(new Frm_ValidaCPF2());
            //Application.Run(new Frm_Principal());
            //Application.Run(new Frm_MenuPrincipal());
            //Application.Run(new Frm_PrincipalMenu_MDI());
            Application.Run(new Frm_PrincipalMenu_UC());
            //Application.Run(new Frm_MouseEventos());
            //Application.Run(new Frm_MouseCapture());
            //Application.Run(new Frm_MouseCursor());
            //Application.Run(new Frm_MenuFlutuante());
        }
    }
}
