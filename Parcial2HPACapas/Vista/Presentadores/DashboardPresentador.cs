using System;
using Parcial2HPACapas.Negocio;
using Parcial2HPACapas.Vista.Contratos;

namespace Parcial2HPACapas.Vista.Presentadores
{
    /// <summary>
    /// Presentador del tablero. Pide los totales y los ultimos pedidos a la capa
    /// de Negocio y actualiza la Vista.
    /// </summary>
    public class DashboardPresentador
    {
        private readonly IDashboardVista _vista;
        private readonly DashboardService _dashboardService;

        /// <summary>Crea el presentador del tablero.</summary>
        public DashboardPresentador(IDashboardVista vista, DashboardService dashboardService)
        {
            _vista = vista;
            _dashboardService = dashboardService;
        }

        /// <summary>Carga los datos del tablero en la Vista.</summary>
        public void Cargar()
        {
            try
            {
                _vista.MostrarResumen(_dashboardService.ObtenerResumen());
                _vista.MostrarUltimosPedidos(_dashboardService.ObtenerUltimosPedidos(8));
            }
            catch (Exception ex)
            {
                _vista.MostrarError(ex.Message);
            }
        }
    }
}
