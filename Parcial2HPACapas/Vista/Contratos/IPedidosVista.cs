using System.Collections.Generic;
using Parcial2HPACapas.Entidades;

namespace Parcial2HPACapas.Vista.Contratos
{
    /// <summary>
    /// Contrato de la Vista del modulo de Pedidos.
    /// </summary>
    public interface IPedidosVista
    {
        /// <summary>Muestra la lista de pedidos en la grilla.</summary>
        void MostrarPedidos(List<Pedido> pedidos);

        /// <summary>Muestra un mensaje de error.</summary>
        void MostrarError(string mensaje);
    }
}
