using System.Collections.Generic;
using Parcial2HPACapas.Datos;
using Parcial2HPACapas.Entidades;

namespace Parcial2HPACapas.Negocio
{
    /// <summary>
    /// Logica de negocio del modulo de Pedidos.
    /// </summary>
    public class PedidoService
    {
        private readonly PedidoRepositorio _pedidoRepositorio;

        /// <summary>Crea el servicio con su repositorio.</summary>
        public PedidoService(PedidoRepositorio pedidoRepositorio)
        {
            _pedidoRepositorio = pedidoRepositorio;
        }

        /// <summary>Devuelve todos los pedidos registrados.</summary>
        public List<Pedido> ListarPedidos()
        {
            return _pedidoRepositorio.ListarTodos();
        }
    }
}
