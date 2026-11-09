using System;

namespace Parcial2HPACapas.Entidades
{
    /// <summary>
    /// Representa a un usuario del sistema. Es una clase "pura" (POCO) que solo
    /// transporta datos entre las capas; no contiene logica de negocio ni acceso
    /// a datos. El manejo seguro de la contrasena se hace con <c>PasswordHash</c>
    /// y <c>Salt</c>, nunca guardando la contrasena en texto plano.
    /// </summary>
    public class Usuario
    {
        /// <summary>Identificador unico del usuario (clave primaria en la BD).</summary>
        public int Id { get; set; }

        /// <summary>Correo electronico; se usa como nombre de inicio de sesion.</summary>
        public string Correo { get; set; }

        /// <summary>Nombre completo mostrado en la interfaz.</summary>
        public string Nombre { get; set; }

        /// <summary>Hash de la contrasena (resultado de SHA-256 en Base64).</summary>
        public string PasswordHash { get; set; }

        /// <summary>Salt aleatorio (Base64) usado para generar y verificar el hash.</summary>
        public string Salt { get; set; }

        /// <summary>Rol del usuario (Administrador, Usuario, Invitado, etc.).</summary>
        public string Rol { get; set; }

        /// <summary>Indica si la cuenta esta activa y puede iniciar sesion.</summary>
        public bool Activo { get; set; }
    }
}
