namespace Parcial2HPACapas.Negocio.Contratos
{
    /// <summary>
    /// CONTRATO #2 (independiente). Su UNICA responsabilidad es VERIFICAR si una
    /// contrasena en texto plano coincide con el hash almacenado. No sabe generar
    /// hashes: separa claramente "crear" de "comprobar".
    /// </summary>
    public interface IVerificarHashService
    {
        /// <summary>
        /// Verifica si una contrasena en texto plano coincide con el hash guardado.
        /// </summary>
        /// <param name="textoPlano">Contrasena ingresada por el usuario.</param>
        /// <param name="hashAlmacenado">Hash guardado en la base de datos.</param>
        /// <param name="saltAlmacenado">Salt guardado junto al hash.</param>
        /// <returns><c>true</c> si coinciden; de lo contrario <c>false</c>.</returns>
        bool Verificar(string textoPlano, string hashAlmacenado, string saltAlmacenado);
    }
}
