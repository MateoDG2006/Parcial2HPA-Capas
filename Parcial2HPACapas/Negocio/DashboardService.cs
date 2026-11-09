using System.Collections.Generic;
using Parcial2HPACapas.Datos;
using Parcial2HPACapas.Entidades;

namespace Parcial2HPACapas.Negocio
{
    /// <summary>
    /// Logica de negocio del tablero: obtiene los totales para las tarjetas y la
    /// lista de ultimos pedidos. Delega el acceso a datos en el repositorio.
    /// </summary>
    public class DashboardService
    {
        private readonly DashboardRepositorio _dashboardRepositorio;
        private readonly PedidoRepositorio _pedidoRepositorio;

        /// <summary>Crea el servicio con sus repositorios.</summary>
        public DashboardService(
            DashboardRepositorio dashboardRepositorio,
            PedidoRepositorio pedidoRepositorio)
        {
            _dashboardRepositorio = dashboardRepositorio;
            _pedidoRepositorio = pedidoRepositorio;
        }

        /// <summary>Obtiene los totales a mostrar en las tarjetas del tablero.</summary>
        public ResumenDashboard ObtenerResumen()
        {
            return _dashboardRepositorio.ObtenerResumen();
        }

        /// <summary>Obtiene los ultimos pedidos para la lista del tablero.</summary>
        public List<Pedido> ObtenerUltimosPedidos(int cantidad = 8)
        {
            return _pedidoRepositorio.ListarUltimos(cantidad);
        }
    }
}
