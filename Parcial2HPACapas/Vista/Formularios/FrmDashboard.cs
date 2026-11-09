using System;
using System.Globalization;
using System.Windows.Forms;
using Parcial2HPACapas.Entidades;

namespace Parcial2HPACapas.Vista.Formularios
{
    /// <summary>
    /// Ventana principal (contenedor MDI). Muestra el menu lateral a la izquierda,
    /// la hora actual arriba a la derecha y, en la parte inferior del menu, quien
    /// inicio sesion. Los modulos (Inicio, Pedidos) se abren como formularios hijos.
    /// </summary>
    public partial class FrmDashboard : Form
    {
        // Cultura en espanol para mostrar la fecha con nombres de dia y mes.
        private readonly CultureInfo _culturaEs = new CultureInfo("es-ES");

        /// <summary>Construye la ventana principal.</summary>
        public FrmDashboard()
        {
            InitializeComponent();
        }

        private void FrmDashboard_Load(object sender, EventArgs e)
        {
            // Garantiza que el menu y la barra superior queden sobre el area MDI.
            pnlLateral.BringToFront();
            pnlSuperior.BringToFront();
            MostrarUsuarioSesion();
            ActualizarReloj();
            timerReloj.Start();
            AbrirInicio();
        }

        /// <summary>Muestra, abajo del menu, el usuario que inicio sesion.</summary>
        private void MostrarUsuarioSesion()
        {
            if (Sesion.HaySesion)
            {
                lblNombreUsuario.Text = Sesion.UsuarioActual.Nombre;
                lblRolUsuario.Text = Sesion.UsuarioActual.Rol;
            }
            else
            {
                lblNombreUsuario.Text = "Invitado";
                lblRolUsuario.Text = "Sin sesion";
            }
        }

        /// <summary>Actualiza la hora y la fecha mostradas en la barra superior.</summary>
        private void ActualizarReloj()
        {
            DateTime ahora = DateTime.Now;
            lblReloj.Text = ahora.ToString("HH:mm:ss");
            lblFecha.Text = ahora.ToString("dddd, dd 'de' MMMM 'de' yyyy", _culturaEs);
        }

        private void timerReloj_Tick(object sender, EventArgs e)
        {
            ActualizarReloj();
        }

        /// <summary>
        /// Abre un formulario hijo dentro del area MDI, maximizado. Si ya existe
        /// uno del mismo tipo abierto, solo lo activa en vez de duplicarlo.
        /// </summary>
        private void AbrirHijo(Form hijo, string titulo)
        {
            foreach (Form abierto in MdiChildren)
            {
                if (abierto.GetType() == hijo.GetType())
                {
                    hijo.Dispose();
                    abierto.Activate();
                    lblTituloModulo.Text = titulo;
                    return;
                }
            }

            hijo.MdiParent = this;
            hijo.WindowState = FormWindowState.Maximized;
            hijo.Show();
            lblTituloModulo.Text = titulo;
        }

        private void AbrirInicio()
        {
            AbrirHijo(new FrmInicio(), "Inicio");
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            AbrirInicio();
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            AbrirHijo(new FrmPedidos(), "Pedidos");
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(
                "Desea cerrar la sesion?", "Cerrar sesion",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                timerReloj.Stop();
                Close();
            }
        }
    }
}
