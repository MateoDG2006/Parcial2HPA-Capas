-- =====================================================================
-- 02_crear_tablas.sql
-- Proposito: Crear las tablas del sistema (esquema).
-- Ejecutar DESPUES de 01. Representa la "Capa de Entidades" en la BD.
-- =====================================================================

USE parcial2_hpa;

-- Se eliminan en orden inverso de dependencias para poder re-ejecutar el script.
DROP TABLE IF EXISTS pedidos;
DROP TABLE IF EXISTS productos;
DROP TABLE IF EXISTS proveedores;
DROP TABLE IF EXISTS empleados;
DROP TABLE IF EXISTS clientes;
DROP TABLE IF EXISTS usuarios;

-- Usuarios del sistema (login). NUNCA se guarda la contrasena en texto plano:
-- se guarda el hash (SHA-256 en Base64) y el salt que lo acompana.
CREATE TABLE usuarios (
    id             INT AUTO_INCREMENT PRIMARY KEY,
    nombre         VARCHAR(120)  NOT NULL,
    correo         VARCHAR(120)  NOT NULL,
    password_hash  VARCHAR(255)  NOT NULL,
    salt           VARCHAR(255)  NOT NULL,
    rol            VARCHAR(40)   NOT NULL DEFAULT 'Usuario',
    activo         TINYINT(1)    NOT NULL DEFAULT 1,
    fecha_creacion DATETIME      NOT NULL DEFAULT CURRENT_TIMESTAMP,
    CONSTRAINT uq_usuarios_correo UNIQUE (correo)
) ENGINE=InnoDB;

-- Catalogos usados por las tarjetas del tablero.
CREATE TABLE clientes (
    id       INT AUTO_INCREMENT PRIMARY KEY,
    nombre   VARCHAR(120) NOT NULL,
    correo   VARCHAR(120),
    telefono VARCHAR(30),
    activo   TINYINT(1) NOT NULL DEFAULT 1
) ENGINE=InnoDB;

CREATE TABLE empleados (
    id     INT AUTO_INCREMENT PRIMARY KEY,
    nombre VARCHAR(120) NOT NULL,
    cargo  VARCHAR(80),
    activo TINYINT(1) NOT NULL DEFAULT 1
) ENGINE=InnoDB;

CREATE TABLE proveedores (
    id       INT AUTO_INCREMENT PRIMARY KEY,
    nombre   VARCHAR(120) NOT NULL,
    telefono VARCHAR(30)
) ENGINE=InnoDB;

CREATE TABLE productos (
    id     INT AUTO_INCREMENT PRIMARY KEY,
    nombre VARCHAR(120)  NOT NULL,
    precio DECIMAL(10,2) NOT NULL DEFAULT 0,
    stock  INT           NOT NULL DEFAULT 0
) ENGINE=InnoDB;

-- Pedidos. El total se guarda ya calculado para simplificar la lectura.
CREATE TABLE pedidos (
    id         INT AUTO_INCREMENT PRIMARY KEY,
    cliente_id INT           NOT NULL,
    fecha      DATETIME      NOT NULL DEFAULT CURRENT_TIMESTAMP,
    total      DECIMAL(10,2) NOT NULL DEFAULT 0,
    estado     VARCHAR(30)   NOT NULL DEFAULT 'Pendiente',
    CONSTRAINT fk_pedidos_cliente
        FOREIGN KEY (cliente_id) REFERENCES clientes(id)
) ENGINE=InnoDB;
