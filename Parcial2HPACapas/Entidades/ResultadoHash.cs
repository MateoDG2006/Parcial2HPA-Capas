namespace Parcial2HPACapas.Entidades
{
    /// <summary>
    /// Objeto de transferencia que agrupa el resultado de generar un hash:
    /// el <see cref="Hash"/> calculado y el <see cref="Salt"/> aleatorio que lo
    /// acompana. Ambos deben almacenarse juntos para poder verificar despues.
    /// </summary>
    public class ResultadoHash
    {
        /// <summary>Hash de la contrasena en Base64.</summary>
        public string Hash { get; set; }

        /// <summary>Salt aleatorio en Base64 usado al generar el hash.</summary>
        public string Salt { get; set; }

        /// <summary>Crea un resultado de hash con su salt asociado.</summary>
        public ResultadoHash(string hash, string salt)
        {
            Hash = hash;
            Salt = salt;
        }
    }
}
