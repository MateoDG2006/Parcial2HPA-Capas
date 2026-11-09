-- =====================================================================
-- 05_crear_usuario_privilegios_minimos.sql
-- Proposito: Crear el usuario de BD que usara la APLICACION, con los
-- PRIVILEGIOS MINIMOS necesarios.
-- Ejecutar DE ULTIMO (necesita que los procedimientos de 03 ya existan).
--
-- Estrategia de seguridad:
--   - La aplicacion NO usa root.
--   - Este usuario SOLO puede EJECUTAR los procedimientos almacenados.
--   - No tiene SELECT/INSERT/UPDATE/DELETE directo sobre las tablas.
--   Como los procedimientos son SQL SECURITY DEFINER, se ejecutan con los
--   permisos del creador, por lo que este usuario no necesita tocar las
--   tablas directamente.
--
-- Esta clave debe coincidir con la cadena de conexion de App.config.
-- Cambiela en un entorno real.
-- =====================================================================

-- Se elimina primero para poder re-ejecutar el script.
DROP USER IF EXISTS 'app_hpa'@'localhost';

CREATE USER 'app_hpa'@'localhost' IDENTIFIED BY 'AppHpa2026!';

-- Permiso EXECUTE solo sobre los procedimientos que usa la aplicacion.
GRANT EXECUTE ON PROCEDURE parcial2_hpa.sp_obtener_usuario_por_correo TO 'app_hpa'@'localhost';
GRANT EXECUTE ON PROCEDURE parcial2_hpa.sp_registrar_usuario           TO 'app_hpa'@'localhost';
GRANT EXECUTE ON PROCEDURE parcial2_hpa.sp_dashboard_resumen           TO 'app_hpa'@'localhost';
GRANT EXECUTE ON PROCEDURE parcial2_hpa.sp_listar_pedidos              TO 'app_hpa'@'localhost';
GRANT EXECUTE ON PROCEDURE parcial2_hpa.sp_listar_ultimos_pedidos      TO 'app_hpa'@'localhost';

FLUSH PRIVILEGES;

-- Comprobacion (opcional): muestra los privilegios otorgados.
SHOW GRANTS FOR 'app_hpa'@'localhost';
