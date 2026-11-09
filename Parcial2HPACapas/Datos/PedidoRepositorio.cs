using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using Parcial2HPACapas.Entidades;

namespace Parcial2HPACapas.Datos
{
    /// <summary>
    /// Acceso a datos de la tabla "pedidos".
    /// </summary>
    public class PedidoRepositorio
    {
        /// <summary>Lista todos los pedidos (<c>sp_listar_pedidos</c>).</summary>
        public List<Pedido> ListarTodos()
        {
            using (MySqlConnection conexion = ConexionBD.ObtenerConexion())
            using (var comando = new MySqlCommand("sp_listar_pedidos", conexion))
            {
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                conexion.Open();
                return LeerPedidos(comando);
            }
        }

        /// <summary>
        /// Lista los ultimos N pedidos (<c>sp_listar_ultimos_pedidos</c>), para el tablero.
        /// </summary>
        public List<Pedido> ListarUltimos(int cantidad)
        {
            using (MySqlConnection conexion = ConexionBD.ObtenerConexion())
            using (var comando = new MySqlCommand("sp_listar_ultimos_pedidos", conexion))
            {
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("p_cantidad", cantidad);
                conexion.Open();
                return LeerPedidos(comando);
            }
        }

        /// <summary>Convierte el resultado del comando en una lista de pedidos.</summary>
        private static List<Pedido> LeerPedidos(MySqlCommand comando)
        {
            var pedidos = new List<Pedido>();
            using (MySqlDataReader lector = comando.ExecuteReader())
            {
                while (lector.Read())
                {
                    pedidos.Add(new Pedido
                    {
                        Id = Convert.ToInt32(lector["id"]),
                        Cliente = lector["cliente"].ToString(),
                        Fecha = Convert.ToDateTime(lector["fecha"]),
                        Total = Convert.ToDecimal(lector["total"]),
                        Estado = lector["estado"].ToString()
                    });
                }
            }
            return pedidos;
        }
    }
}
