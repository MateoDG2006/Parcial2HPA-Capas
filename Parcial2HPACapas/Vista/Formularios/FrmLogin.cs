using System;
using System.Windows.Forms;
using Parcial2HPACapas.Datos;
using Parcial2HPACapas.Entidades;
using Parcial2HPACapas.Negocio;
using Parcial2HPACapas.Vista.Contratos;
using Parcial2HPACapas.Vista.Presentadores;

namespace Parcial2HPACapas.Vista.Formularios
{
    /// <summary>
    /// Vista de inicio de sesion (MVP). El formulario es "pasivo": no contiene
    /// logica de negocio, solo expone datos y eventos e implementa
    /// <see cref="ILoginVista"/>. Toda la logica la maneja el Presentador.
    /// </summary>
    public partial class FrmLogin : Form, ILoginVista
    {
        private readonly LoginPresentador _presentador;

        /// <summary>
        /// Construye la Vista y "cablea" el patron MVP: una sola implementacion
        /// (<see cref="Sha256HashService"/>) cubre los dos contratos de hash.
        /// </summary>
        public FrmLogin()
        {
            InitializeComponent();

            var hashService = new Sha256HashService();
            var autenticacionService = new AutenticacionService(
                new UsuarioRepositorio(), hashService, hashService);

            _presentador = new LoginPresentador(this, autenticacionService);
        }

        /// <inheritdoc/>
        public string Correo => txtCorreo.Text;

        /// <inheritdoc/>
        public string Contrasena => txtContrasena.Text;

        /// <inheritdoc/>
        public event EventHandler IniciarSesionSolicitado;

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            lblMensaje.Text = string.Empty;
            IniciarSesionSolicitado?.Invoke(this, EventArgs.Empty);
        }

        private void chkMostrar_CheckedChanged(object sender, EventArgs e)
        {
            txtContrasena.UseSystemPasswordChar = !chkMostrar.Checked;
        }

        /// <inheritdoc/>
        public void MostrarMensaje(string mensaje)
        {
            lblMensaje.Text = mensaje;
        }

        /// <inheritdoc/>
        public void EstablecerCargando(bool cargando)
        {
            btnIngresar.Enabled = !cargando;
            btnIngresar.Text = cargando ? "Validando..." : "Ingresar";
            UseWaitCursor = cargando;
        }

        /// <inheritdoc/>
        public void AutenticacionCorrecta(Usuario usuario)
        {
            // Oculta el login y abre el tablero (MDI) de forma modal.
            Hide();
            using (var dashboard = new FrmDashboard())
            {
                dashboard.ShowDialog();
            }

            // Al cerrar sesion regresamos al login, limpio.
            Sesion.CerrarSesion();
            txtContrasena.Clear();
            lblMensaje.Text = string.Empty;
            txtCorreo.Focus();
            Show();
        }
    }
}
