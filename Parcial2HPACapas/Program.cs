using System;
using System.Windows.Forms;
using Parcial2HPACapas.Vista.Formularios;

namespace Parcial2HPACapas
{
    /// <summary>
    /// Punto de entrada de la aplicacion. Arranca mostrando el formulario de
    /// inicio de sesion; al autenticarse, el propio login abre el tablero (MDI).
    /// </summary>
    internal static class Program
    {
        /// <summary>Metodo principal de la aplicacion.</summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmLogin());
        }
    }
}
