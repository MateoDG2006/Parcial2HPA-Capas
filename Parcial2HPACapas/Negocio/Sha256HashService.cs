using System;
using System.Security.Cryptography;
using System.Text;
using Parcial2HPACapas.Entidades;
using Parcial2HPACapas.Negocio.Contratos;

namespace Parcial2HPACapas.Negocio
{
    /// <summary>
    /// Implementacion concreta del hashing de contrasenas usando SHA-256 con salt.
    /// Una sola clase implementa los DOS contratos independientes
    /// (<see cref="IHashService"/> e <see cref="IVerificarHashService"/>).
    ///
    /// Gracias al desacoplamiento, si manana se cambia a BCrypt/Argon2 solo se
    /// reemplaza esta clase, sin tocar la Vista, el Presentador ni la Base de Datos.
    ///
    /// Esquema:  hash = Base64( SHA256( UTF8( salt + textoPlano ) ) )
    /// </summary>
    public class Sha256HashService : IHashService, IVerificarHashService
    {
        /// <inheritdoc/>
        public ResultadoHash GenerarHash(string textoPlano)
        {
            if (textoPlano == null)
                throw new ArgumentNullException(nameof(textoPlano));

            string salt = GenerarSalt();
            string hash = CalcularHash(textoPlano, salt);
            return new ResultadoHash(hash, salt);
        }

        /// <inheritdoc/>
        public bool Verificar(string textoPlano, string hashAlmacenado, string saltAlmacenado)
        {
            if (textoPlano == null || hashAlmacenado == null || saltAlmacenado == null)
                return false;

            string hashCalculado = CalcularHash(textoPlano, saltAlmacenado);
            return ComparacionSegura(hashCalculado, hashAlmacenado);
        }

        /// <summary>Genera un salt aleatorio de 16 bytes y lo devuelve en Base64.</summary>
        private static string GenerarSalt()
        {
            byte[] bytes = new byte[16];
            using (var rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(bytes);
            }
            return Convert.ToBase64String(bytes);
        }

        /// <summary>Calcula el hash SHA-256 (Base64) de (salt + textoPlano) en UTF-8.</summary>
        private static string CalcularHash(string textoPlano, string salt)
        {
            using (var sha = SHA256.Create())
            {
                byte[] entrada = Encoding.UTF8.GetBytes(salt + textoPlano);
                byte[] hash = sha.ComputeHash(entrada);
                return Convert.ToBase64String(hash);
            }
        }

        /// <summary>
        /// Compara dos cadenas en tiempo (casi) constante para no filtrar
        /// informacion por el tiempo de respuesta ("timing attack").
        /// </summary>
        private static bool ComparacionSegura(string a, string b)
        {
            if (a.Length != b.Length)
                return false;

            int diferencia = 0;
            for (int i = 0; i < a.Length; i++)
                diferencia |= a[i] ^ b[i];

            return diferencia == 0;
        }
    }
}
