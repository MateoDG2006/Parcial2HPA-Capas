using System;

namespace Parcial2HPACapas.Entidades
{
    /// <summary>
    /// Representa un pedido. Se usa para llenar la grilla del modulo de Pedidos
    /// y la lista de "ultimos pedidos" del tablero.
    /// </summary>
    public class Pedido
    {
        /// <summary>Identificador del pedido.</summary>
        public int Id { get; set; }

        /// <summary>Nombre del cliente que realizo el pedido.</summary>
        public string Cliente { get; set; }

        /// <summary>Fecha en que se registro el pedido.</summary>
        public DateTime Fecha { get; set; }

        /// <summary>Monto total del pedido.</summary>
        public decimal Total { get; set; }

        /// <summary>Estado del pedido (Pendiente, Enviado, Entregado, Cancelado).</summary>
        public string Estado { get; set; }
    }
}
