using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Parcial2HPACapas.Datos;
using Parcial2HPACapas.Entidades;
using Parcial2HPACapas.Negocio;
using Parcial2HPACapas.Vista.Contratos;
using Parcial2HPACapas.Vista.Presentadores;

namespace Parcial2HPACapas.Vista.Formularios
{
    /// <summary>
    /// Modulo de Pedidos (formulario hijo del MDI). Implementa
    /// <see cref="IPedidosVista"/>; el Presentador le entrega la lista de pedidos.
    /// </summary>
    public partial class FrmPedidos : Form, IPedidosVista
    {
        private readonly PedidosPresentador _presentador;

        /// <summary>Construye el modulo y arma su presentador.</summary>
        public FrmPedidos()
        {
            InitializeComponent();
            _presentador = new PedidosPresentador(this, new PedidoService(new PedidoRepositorio()));
        }

        private void FrmPedidos_Load(object sender, EventArgs e)
        {
            _presentador.Cargar();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            _presentador.Cargar();
        }

        /// <inheritdoc/>
        public void MostrarPedidos(List<Pedido> pedidos)
        {
            dgvPedidos.DataSource = pedidos;
            GrillaHelper.FormatearPedidos(dgvPedidos);
            lblTotal.Text = "Total de pedidos: " + pedidos.Count;
        }

        /// <inheritdoc/>
        public void MostrarError(string mensaje)
        {
            MessageBox.Show(
                "No se pudieron cargar los pedidos.\n\nDetalle: " + mensaje,
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
