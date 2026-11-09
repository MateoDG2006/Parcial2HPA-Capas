-- =====================================================================
-- 04_datos_iniciales_mock.sql
-- Proposito: Cargar datos de prueba (mockups).
-- Ejecutar DESPUES de 03.
--
-- IMPORTANTE (usuarios): el hash y el salt fueron generados con el MISMO
-- algoritmo de la aplicacion:
--     hash = Base64( SHA256( UTF8( salt + contrasena ) ) )
-- Credenciales de prueba (correo / contrasena):
--     admin@utp.ac.pa     / Admin123*     (rol Administrador)
--     usuario@utp.ac.pa   / Usuario123*   (rol Usuario)
--     invitado@utp.ac.pa  / Invitado123*  (rol Invitado)
-- =====================================================================

USE parcial2_hpa;

-- Limpieza para poder re-ejecutar (respeta llaves foraneas).
DELETE FROM pedidos;
DELETE FROM productos;
DELETE FROM proveedores;
DELETE FROM empleados;
DELETE FROM clientes;
DELETE FROM usuarios;
ALTER TABLE pedidos     AUTO_INCREMENT = 1;
ALTER TABLE productos   AUTO_INCREMENT = 1;
ALTER TABLE proveedores AUTO_INCREMENT = 1;
ALTER TABLE empleados   AUTO_INCREMENT = 1;
ALTER TABLE clientes    AUTO_INCREMENT = 1;
ALTER TABLE usuarios    AUTO_INCREMENT = 1;

-- Usuarios (hash y salt precalculados, coinciden con Sha256HashService)
INSERT INTO usuarios (nombre, correo, password_hash, salt, rol, activo) VALUES
('Administrador',       'admin@utp.ac.pa',    '1yOK3nxMVwC3r1TfxBKEGiw1CHtRcQpbbrEfPqJY0U8=', 'Y1I0cHMyMDI2U2FsdEFkbQ==', 'Administrador', 1),
('Usuario de Prueba',   'usuario@utp.ac.pa',  'MmWwETMsKnrvja11dMByePeebx6II2qygh15tGfxDcg=', 'Y1I0cHMyMDI2U2FsdFVzcg==', 'Usuario',       1),
('Usuario Invitado',    'invitado@utp.ac.pa', 'i1uthv9a7zPKdAxdTmjf+/zbOjUkhvg/4QU3FwgAXnw=', 'Y1I0cHMyMDI2U2FsdEludg==', 'Invitado',      1);

-- Clientes
INSERT INTO clientes (nombre, correo, telefono, activo) VALUES
('Comercial La Victoria',   'ventas@lavictoria.com',  '6000-1001', 1),
('Distribuidora Istmo',     'compras@istmo.com',      '6000-1002', 1),
('Tecno Soluciones S.A.',   'info@tecnosol.com',      '6000-1003', 1),
('Importadora El Dorado',   'contacto@eldorado.com',  '6000-1004', 1),
('Servicios Globales',      'admin@globales.com',     '6000-1005', 1),
('Mayorista Central',       'pedidos@central.com',    '6000-1006', 1);

-- Empleados
INSERT INTO empleados (nombre, cargo, activo) VALUES
('Ana Gomez',     'Vendedora',          1),
('Luis Perez',    'Almacen',            1),
('Carla Diaz',    'Atencion al cliente',1),
('Jorge Mora',    'Supervisor',         1);

-- Proveedores
INSERT INTO proveedores (nombre, telefono) VALUES
('Suministros Panama',   '200-3001'),
('Global Parts',         '200-3002'),
('Tech Importers',       '200-3003');

-- Productos
INSERT INTO productos (nombre, precio, stock) VALUES
('Teclado mecanico',      35.00, 40),
('Mouse inalambrico',     18.50, 55),
('Monitor 24 pulgadas',  150.00, 12),
('Laptop Core i5',       820.00,  8),
('Impresora multifuncional', 210.00, 6),
('Disco solido 1TB',      95.00, 25),
('Memoria RAM 16GB',      60.00, 30),
('Audifonos con microfono', 25.00, 48);

-- Pedidos (referencian clientes 1..6)
INSERT INTO pedidos (cliente_id, fecha, total, estado) VALUES
(1, '2026-10-20 09:15:00', 185.00, 'Entregado'),
(2, '2026-10-22 11:40:00', 820.00, 'Enviado'),
(3, '2026-10-25 14:05:00', 150.00, 'Pendiente'),
(4, '2026-10-28 10:30:00', 275.50, 'Entregado'),
(5, '2026-11-01 08:50:00',  95.00, 'Cancelado'),
(1, '2026-11-03 16:20:00', 120.00, 'Enviado'),
(6, '2026-11-04 13:10:00', 430.00, 'Pendiente'),
(2, '2026-11-05 09:00:00',  60.00, 'Entregado'),
(3, '2026-11-06 15:45:00', 210.00, 'Enviado'),
(4, '2026-11-07 12:25:00',  43.50, 'Pendiente');
