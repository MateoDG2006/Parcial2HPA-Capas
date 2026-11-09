using Parcial2HPACapas.Entidades;

namespace Parcial2HPACapas.Negocio.Contratos
{
    /// <summary>
    /// CONTRATO #1 (independiente). Su UNICA responsabilidad es GENERAR el hash
    /// de una contrasena en texto plano, junto con un salt aleatorio.
    /// Cumple el Principio de Responsabilidad Unica: no sabe verificar.
    /// </summary>
    public interface IHashService
    {
        /// <summary>
        /// Genera el hash de una contrasena en texto plano y un salt aleatorio.
        /// </summary>
        /// <param name="textoPlano">Contrasena en texto plano a proteger.</param>
        /// <returns>Un <see cref="ResultadoHash"/> con el hash y el salt generados.</returns>
        ResultadoHash GenerarHash(string textoPlano);
    }
}
