using System;
using MySql.Data.MySqlClient;
using Parcial2HPACapas.Entidades;

namespace Parcial2HPACapas.Datos
{
    /// <summary>
    /// Acceso a datos de los totales del tablero. Ejecuta un unico procedimiento
    /// almacenado que devuelve todos los conteos en una sola fila.
    /// </summary>
    public class DashboardRepositorio
    {
        /// <summary>
        /// Obtiene los totales del tablero ejecutando <c>sp_dashboard_resumen</c>.
        /// </summary>
        public ResumenDashboard ObtenerResumen()
        {
            using (MySqlConnection conexion = ConexionBD.ObtenerConexion())
            using (var comando = new MySqlCommand("sp_dashboard_resumen", conexion))
            {
                comando.CommandType = System.Data.CommandType.StoredProcedure;

                conexion.Open();
                using (MySqlDataReader lector = comando.ExecuteReader())
                {
                    var resumen = new ResumenDashboard();
                    if (lector.Read())
                    {
                        resumen.TotalUsuarios = Convert.ToInt32(lector["total_usuarios"]);
                        resumen.TotalClientes = Convert.ToInt32(lector["total_clientes"]);
                        resumen.TotalEmpleados = Convert.ToInt32(lector["total_empleados"]);
                        resumen.TotalProveedores = Convert.ToInt32(lector["total_proveedores"]);
                        resumen.TotalProductos = Convert.ToInt32(lector["total_productos"]);
                        resumen.TotalPedidos = Convert.ToInt32(lector["total_pedidos"]);
                        resumen.MontoTotalPedidos = Convert.ToDecimal(lector["monto_total_pedidos"]);
                    }
                    return resumen;
                }
            }
        }
    }
}
