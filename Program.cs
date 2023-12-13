using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto3.C_Presentacion;

namespace Proyecto3
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
<<<<<<< HEAD
            Application.Run(new Form_CRUD_Prod());
=======
            Application.Run(new Fnt_Login());
>>>>>>> 9b73fd40d7cd32e79318724f3e142d2d800aad52
        }
    }
}
