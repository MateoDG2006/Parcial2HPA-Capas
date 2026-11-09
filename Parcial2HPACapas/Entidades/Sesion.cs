namespace Parcial2HPACapas.Entidades
{
    /// <summary>
    /// Guarda, de forma global, el usuario que inicio sesion. El tablero lo lee
    /// para mostrar "quien inicio sesion" en la parte inferior del menu lateral.
    /// </summary>
    public static class Sesion
    {
        /// <summary>Usuario autenticado actualmente (null si no hay sesion).</summary>
        public static Usuario UsuarioActual { get; set; }

        /// <summary>Indica si hay un usuario con sesion iniciada.</summary>
        public static bool HaySesion => UsuarioActual != null;

        /// <summary>Cierra la sesion actual, limpiando el usuario.</summary>
        public static void CerrarSesion()
        {
            UsuarioActual = null;
        }
    }
}
