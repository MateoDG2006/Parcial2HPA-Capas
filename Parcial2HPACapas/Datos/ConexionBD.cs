using System;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace Parcial2HPACapas.Datos
{
    /// <summary>
    /// Punto unico de acceso a la base de datos. Lee la cadena de conexion desde
    /// App.config (clave "ConexionMySql"), que apunta al usuario de BD con
    /// PRIVILEGIOS MINIMOS (no root). Centralizar la conexion aqui evita repetir
    /// la cadena y facilita cambiar el servidor en un solo lugar.
    /// </summary>
    public static class ConexionBD
    {
        private const string NombreConexion = "ConexionMySql";

        /// <summary>
        /// Crea y devuelve una nueva conexion MySQL (sin abrir todavia).
        /// </summary>
        /// <exception cref="ConfigurationErrorsException">
        /// Si no existe la cadena de conexion en App.config.
        /// </exception>
        public static MySqlConnection ObtenerConexion()
        {
            ConnectionStringSettings config = ConfigurationManager.ConnectionStrings[NombreConexion];
            if (config == null || string.IsNullOrWhiteSpace(config.ConnectionString))
            {
                throw new ConfigurationErrorsException(
                    "No se encontro la cadena de conexion '" + NombreConexion + "' en App.config.");
            }

            return new MySqlConnection(config.ConnectionString);
        }

        /// <summary>
        /// Prueba la conexion con la base de datos. Util para diagnosticar.
        /// </summary>
        /// <returns><c>true</c> si se pudo abrir la conexion.</returns>
        public static bool ProbarConexion(out string mensajeError)
        {
            mensajeError = null;
            try
            {
                using (MySqlConnection conexion = ObtenerConexion())
                {
                    conexion.Open();
                    return true;
                }
            }
            catch (Exception ex)
            {
                mensajeError = ex.Message;
                return false;
            }
        }
    }
}
