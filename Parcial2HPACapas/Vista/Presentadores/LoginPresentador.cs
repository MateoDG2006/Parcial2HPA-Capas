using System;
using Parcial2HPACapas.Entidades;
using Parcial2HPACapas.Negocio;
using Parcial2HPACapas.Vista.Contratos;

namespace Parcial2HPACapas.Vista.Presentadores
{
    /// <summary>
    /// Presentador del inicio de sesion. Es el intermediario del patron MVP:
    /// escucha el evento de la Vista, pide a la capa de Negocio que autentique y
    /// devuelve el resultado a la Vista. No contiene logica de UI ni de datos.
    /// </summary>
    public class LoginPresentador
    {
        private readonly ILoginVista _vista;
        private readonly AutenticacionService _autenticacionService;

        /// <summary>Crea el presentador y se suscribe al evento de la Vista.</summary>
        public LoginPresentador(ILoginVista vista, AutenticacionService autenticacionService)
        {
            _vista = vista;
            _autenticacionService = autenticacionService;
            _vista.IniciarSesionSolicitado += AlIniciarSesion;
        }

        /// <summary>Maneja la solicitud de inicio de sesion de la Vista.</summary>
        private void AlIniciarSesion(object sender, EventArgs e)
        {
            try
            {
                _vista.EstablecerCargando(true);

                Usuario usuario = _autenticacionService.IniciarSesion(
                    _vista.Correo, _vista.Contrasena);

                // Guarda la sesion global y avisa a la Vista
                Sesion.UsuarioActual = usuario;
                _vista.AutenticacionCorrecta(usuario);
            }
            catch (Exception ex)
            {
                // Validaciones y errores de autenticacion llegan aqui
                _vista.MostrarMensaje(ex.Message);
            }
            finally
            {
                _vista.EstablecerCargando(false);
            }
        }
    }
}
