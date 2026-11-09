-- =====================================================================
-- 03_procedimientos_almacenados.sql
-- Proposito: Crear los procedimientos almacenados que usa la aplicacion.
-- Ejecutar DESPUES de 02.
--
-- Todos se definen con SQL SECURITY DEFINER: se ejecutan con los permisos
-- del creador (administrador). Asi el usuario de la aplicacion solo necesita
-- permiso EXECUTE sobre estos procedimientos y NO acceso directo a las tablas
-- (principio de privilegios minimos).
-- =====================================================================

USE parcial2_hpa;

DROP PROCEDURE IF EXISTS sp_obtener_usuario_por_correo;
DROP PROCEDURE IF EXISTS sp_registrar_usuario;
DROP PROCEDURE IF EXISTS sp_dashboard_resumen;
DROP PROCEDURE IF EXISTS sp_listar_pedidos;
DROP PROCEDURE IF EXISTS sp_listar_ultimos_pedidos;

DELIMITER $$

-- Devuelve los datos del usuario (incluido hash y salt) por su correo.
-- Lo usa el login para VERIFICAR el hash en la capa de Negocio.
CREATE DEFINER = CURRENT_USER PROCEDURE sp_obtener_usuario_por_correo(IN p_correo VARCHAR(120))
    SQL SECURITY DEFINER
BEGIN
    SELECT id, correo, nombre, password_hash, salt, rol, activo
    FROM usuarios
    WHERE correo = p_correo
    LIMIT 1;
END$$

-- Registra un usuario nuevo con su hash y salt ya calculados por la aplicacion.
CREATE DEFINER = CURRENT_USER PROCEDURE sp_registrar_usuario(
    IN p_nombre        VARCHAR(120),
    IN p_correo        VARCHAR(120),
    IN p_password_hash VARCHAR(255),
    IN p_salt          VARCHAR(255),
    IN p_rol           VARCHAR(40))
    SQL SECURITY DEFINER
BEGIN
    INSERT INTO usuarios (nombre, correo, password_hash, salt, rol, activo)
    VALUES (p_nombre, p_correo, p_password_hash, p_salt, p_rol, 1);
END$$

-- Devuelve, en una sola fila, todos los totales del tablero.
CREATE DEFINER = CURRENT_USER PROCEDURE sp_dashboard_resumen()
    SQL SECURITY DEFINER
BEGIN
    SELECT
        (SELECT COUNT(*) FROM usuarios)                 AS total_usuarios,
        (SELECT COUNT(*) FROM clientes)                 AS total_clientes,
        (SELECT COUNT(*) FROM empleados)                AS total_empleados,
        (SELECT COUNT(*) FROM proveedores)              AS total_proveedores,
        (SELECT COUNT(*) FROM productos)                AS total_productos,
        (SELECT COUNT(*) FROM pedidos)                  AS total_pedidos,
        (SELECT COALESCE(SUM(total),0) FROM pedidos)    AS monto_total_pedidos;
END$$

-- Lista todos los pedidos con el nombre del cliente.
CREATE DEFINER = CURRENT_USER PROCEDURE sp_listar_pedidos()
    SQL SECURITY DEFINER
BEGIN
    SELECT p.id, c.nombre AS cliente, p.fecha, p.total, p.estado
    FROM pedidos p
    INNER JOIN clientes c ON c.id = p.cliente_id
    ORDER BY p.fecha DESC, p.id DESC;
END$$

-- Lista los ultimos N pedidos (para la lista del tablero).
CREATE DEFINER = CURRENT_USER PROCEDURE sp_listar_ultimos_pedidos(IN p_cantidad INT)
    SQL SECURITY DEFINER
BEGIN
    SELECT p.id, c.nombre AS cliente, p.fecha, p.total, p.estado
    FROM pedidos p
    INNER JOIN clientes c ON c.id = p.cliente_id
    ORDER BY p.fecha DESC, p.id DESC
    LIMIT p_cantidad;
END$$

DELIMITER ;
