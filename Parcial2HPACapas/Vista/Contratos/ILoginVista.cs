using System;
using Parcial2HPACapas.Entidades;

namespace Parcial2HPACapas.Vista.Contratos
{
    /// <summary>
    /// Contrato de la Vista de inicio de sesion (MVP - Vista pasiva).
    /// El formulario implementa esta interfaz; el Presentador solo conoce el
    /// contrato, nunca el formulario concreto, lo que permite probarlo sin UI.
    /// </summary>
    public interface ILoginVista
    {
        /// <summary>Correo escrito por el usuario.</summary>
        string Correo { get; }

        /// <summary>Contrasena escrita por el usuario.</summary>
        string Contrasena { get; }

        /// <summary>Evento que la Vista dispara cuando se pide iniciar sesion.</summary>
        event EventHandler IniciarSesionSolicitado;

        /// <summary>Muestra un mensaje (de validacion o error) al usuario.</summary>
        void MostrarMensaje(string mensaje);

        /// <summary>Habilita o deshabilita el estado "cargando" de la Vista.</summary>
        void EstablecerCargando(bool cargando);

        /// <summary>Notifica a la Vista que la autenticacion fue correcta.</summary>
        void AutenticacionCorrecta(Usuario usuario);
    }
}
