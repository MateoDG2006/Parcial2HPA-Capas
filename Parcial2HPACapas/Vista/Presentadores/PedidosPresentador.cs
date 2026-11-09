using System;
using Parcial2HPACapas.Negocio;
using Parcial2HPACapas.Vista.Contratos;

namespace Parcial2HPACapas.Vista.Presentadores
{
    /// <summary>
    /// Presentador del modulo de Pedidos.
    /// </summary>
    public class PedidosPresentador
    {
        private readonly IPedidosVista _vista;
        private readonly PedidoService _pedidoService;

        /// <summary>Crea el presentador de pedidos.</summary>
        public PedidosPresentador(IPedidosVista vista, PedidoService pedidoService)
        {
            _vista = vista;
            _pedidoService = pedidoService;
        }

        /// <summary>Carga los pedidos en la Vista.</summary>
        public void Cargar()
        {
            try
            {
                _vista.MostrarPedidos(_pedidoService.ListarPedidos());
            }
            catch (Exception ex)
            {
                _vista.MostrarError(ex.Message);
            }
        }
    }
}
