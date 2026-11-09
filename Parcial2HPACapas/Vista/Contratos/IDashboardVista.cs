using System.Collections.Generic;
using Parcial2HPACapas.Entidades;

namespace Parcial2HPACapas.Vista.Contratos
{
    /// <summary>
    /// Contrato de la Vista del tablero (pantalla de inicio dentro del MDI).
    /// </summary>
    public interface IDashboardVista
    {
        /// <summary>Muestra los totales en las tarjetas.</summary>
        void MostrarResumen(ResumenDashboard resumen);

        /// <summary>Muestra la lista de ultimos pedidos.</summary>
        void MostrarUltimosPedidos(List<Pedido> pedidos);

        /// <summary>Muestra un mensaje de error.</summary>
        void MostrarError(string mensaje);
    }
}
