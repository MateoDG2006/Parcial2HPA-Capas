using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using Parcial2HPACapas.Datos;
using Parcial2HPACapas.Entidades;
using Parcial2HPACapas.Negocio;
using Parcial2HPACapas.Vista.Contratos;
using Parcial2HPACapas.Vista.Presentadores;

namespace Parcial2HPACapas.Vista.Formularios
{
    /// <summary>
    /// Tablero (pantalla de inicio) mostrado como formulario hijo del MDI.
    /// Implementa <see cref="IDashboardVista"/>; su Presentador le entrega los
    /// totales y los ultimos pedidos.
    /// </summary>
    public partial class FrmInicio : Form, IDashboardVista
    {
        private readonly DashboardPresentador _presentador;

        /// <summary>Construye el tablero y arma su presentador.</summary>
        public FrmInicio()
        {
            InitializeComponent();
            var service = new DashboardService(new DashboardRepositorio(), new PedidoRepositorio());
            _presentador = new DashboardPresentador(this, service);
        }

        private void FrmInicio_Load(object sender, EventArgs e)
        {
            _presentador.Cargar();
        }

        /// <inheritdoc/>
        public void MostrarResumen(ResumenDashboard resumen)
        {
            flpTarjetas.Controls.Clear();
            flpTarjetas.Controls.Add(CrearTarjeta("Usuarios", resumen.TotalUsuarios.ToString()));
            flpTarjetas.Controls.Add(CrearTarjeta("Clientes", resumen.TotalClientes.ToString()));
            flpTarjetas.Controls.Add(CrearTarjeta("Empleados", resumen.TotalEmpleados.ToString()));
            flpTarjetas.Controls.Add(CrearTarjeta("Proveedores", resumen.TotalProveedores.ToString()));
            flpTarjetas.Controls.Add(CrearTarjeta("Productos", resumen.TotalProductos.ToString()));
            flpTarjetas.Controls.Add(CrearTarjeta("Pedidos", resumen.TotalPedidos.ToString()));
            flpTarjetas.Controls.Add(CrearTarjeta("Monto en pedidos",
                resumen.MontoTotalPedidos.ToString("C2", CultureInfo.GetCultureInfo("en-US"))));
        }

        /// <summary>Crea visualmente una tarjeta (titulo + valor) para el tablero.</summary>
        private Panel CrearTarjeta(string titulo, string valor)
        {
            var panel = new Panel
            {
                Size = new Size(168, 92),
                BackColor = Color.White,
                Margin = new Padding(9)
            };

            var lblValor = new Label
            {
                Dock = DockStyle.Fill,
                Text = valor,
                Font = new Font("Segoe UI", 16F, FontStyle.Bold),
                ForeColor = Color.FromArgb(41, 57, 85),
                TextAlign = ContentAlignment.MiddleCenter
            };

            var lblTitulo = new Label
            {
                Dock = DockStyle.Bottom,
                Height = 26,
                Text = titulo,
                Font = new Font("Segoe UI", 8.5F),
                ForeColor = Color.Gray,
                TextAlign = ContentAlignment.MiddleCenter
            };

            panel.Controls.Add(lblValor);
            panel.Controls.Add(lblTitulo);
            return panel;
        }

        /// <inheritdoc/>
        public void MostrarUltimosPedidos(List<Pedido> pedidos)
        {
            dgvUltimosPedidos.DataSource = pedidos;
            GrillaHelper.FormatearPedidos(dgvUltimosPedidos);
        }

        /// <inheritdoc/>
        public void MostrarError(string mensaje)
        {
            MessageBox.Show(
                "No se pudieron cargar los datos del tablero.\n\nDetalle: " + mensaje,
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
