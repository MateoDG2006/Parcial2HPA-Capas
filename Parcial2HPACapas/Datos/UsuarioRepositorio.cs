using System;
using MySql.Data.MySqlClient;
using Parcial2HPACapas.Entidades;

namespace Parcial2HPACapas.Datos
{
    /// <summary>
    /// Acceso a datos de la tabla "usuarios". Solo ejecuta procedimientos
    /// almacenados; no contiene reglas de negocio. Convierte filas en entidades.
    /// </summary>
    public class UsuarioRepositorio
    {
        /// <summary>
        /// Obtiene un usuario por su correo. Devuelve <c>null</c> si no existe.
        /// Ejecuta el procedimiento almacenado <c>sp_obtener_usuario_por_correo</c>.
        /// </summary>
        public Usuario ObtenerPorCorreo(string correo)
        {
            using (MySqlConnection conexion = ConexionBD.ObtenerConexion())
            using (var comando = new MySqlCommand("sp_obtener_usuario_por_correo", conexion))
            {
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("p_correo", correo);

                conexion.Open();
                using (MySqlDataReader lector = comando.ExecuteReader())
                {
                    if (!lector.Read())
                        return null;

                    return new Usuario
                    {
                        Id = Convert.ToInt32(lector["id"]),
                        Correo = lector["correo"].ToString(),
                        Nombre = lector["nombre"].ToString(),
                        PasswordHash = lector["password_hash"].ToString(),
                        Salt = lector["salt"].ToString(),
                        Rol = lector["rol"].ToString(),
                        Activo = Convert.ToBoolean(lector["activo"])
                    };
                }
            }
        }

        /// <summary>
        /// Inserta un usuario nuevo ejecutando <c>sp_registrar_usuario</c>.
        /// </summary>
        public void Insertar(Usuario usuario)
        {
            using (MySqlConnection conexion = ConexionBD.ObtenerConexion())
            using (var comando = new MySqlCommand("sp_registrar_usuario", conexion))
            {
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("p_nombre", usuario.Nombre);
                comando.Parameters.AddWithValue("p_correo", usuario.Correo);
                comando.Parameters.AddWithValue("p_password_hash", usuario.PasswordHash);
                comando.Parameters.AddWithValue("p_salt", usuario.Salt);
                comando.Parameters.AddWithValue("p_rol", usuario.Rol);

                conexion.Open();
                comando.ExecuteNonQuery();
            }
        }
    }
}
