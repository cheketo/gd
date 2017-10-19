USE [GD2C2017]
GO


IF EXISTS ( SELECT *
			FROM INFORMATION_SCHEMA.TABLES
			WHERE TABLE_SCHEMA = 'SQL_86'
				AND TABLE_NAME = 'rel_roles_funcionalidades'
)
BEGIN
	DROP TABLE SQL_86.rel_roles_funcionalidades
END
GO

IF EXISTS ( SELECT *
			FROM INFORMATION_SCHEMA.TABLES
			WHERE TABLE_SCHEMA = 'SQL_86'
				AND TABLE_NAME = 'roles'
)
BEGIN
	DROP TABLE SQL_86.roles
END
GO

IF EXISTS ( SELECT *
			FROM INFORMATION_SCHEMA.TABLES
			WHERE TABLE_SCHEMA = 'SQL_86'
				AND TABLE_NAME = 'pagos_devoluciones'
)
BEGIN
	DROP TABLE SQL_86.pagos_devoluciones
END
GO

IF EXISTS ( SELECT *
			FROM INFORMATION_SCHEMA.TABLES
			WHERE TABLE_SCHEMA = 'SQL_86'
				AND TABLE_NAME = 'pagos_detalles'
)
BEGIN
	DROP TABLE SQL_86.pagos_detalles
END
GO

IF EXISTS ( SELECT *
			FROM INFORMATION_SCHEMA.TABLES
			WHERE TABLE_SCHEMA = 'SQL_86'
				AND TABLE_NAME = 'pagos'
)
BEGIN
	DROP TABLE SQL_86.pagos
END
GO

IF EXISTS ( SELECT *
			FROM INFORMATION_SCHEMA.TABLES
			WHERE TABLE_SCHEMA = 'SQL_86'
				AND TABLE_NAME = 'medios_pagos'
)
BEGIN
	DROP TABLE SQL_86.medios_pagos
END
GO

IF EXISTS ( SELECT *
			FROM INFORMATION_SCHEMA.TABLES
			WHERE TABLE_SCHEMA = 'SQL_86'
				AND TABLE_NAME = 'facturas_items'
)
BEGIN
	DROP TABLE SQL_86.facturas_items
END
GO

IF EXISTS ( SELECT *
			FROM INFORMATION_SCHEMA.TABLES
			WHERE TABLE_SCHEMA = 'SQL_86'
				AND TABLE_NAME = 'usuarios'
)
BEGIN
	DROP TABLE SQL_86.usuarios
END
GO

IF EXISTS ( SELECT *
			FROM INFORMATION_SCHEMA.TABLES
			WHERE TABLE_SCHEMA = 'SQL_86'
				AND TABLE_NAME = 'funcionalidades'
)
BEGIN
	DROP TABLE SQL_86.funcionalidades
END
GO

IF EXISTS ( SELECT *
			FROM INFORMATION_SCHEMA.TABLES
			WHERE TABLE_SCHEMA = 'SQL_86'
				AND TABLE_NAME = 'facturas'
)
BEGIN
	DROP TABLE SQL_86.facturas
END
GO

IF EXISTS ( SELECT *
			FROM INFORMATION_SCHEMA.TABLES
			WHERE TABLE_SCHEMA = 'SQL_86'
				AND TABLE_NAME = 'sucursales'
)
BEGIN
	DROP TABLE SQL_86.sucursales
END
GO

IF EXISTS ( SELECT *
			FROM INFORMATION_SCHEMA.TABLES
			WHERE TABLE_SCHEMA = 'SQL_86'
				AND TABLE_NAME = 'rendiciones'
)
BEGIN
	DROP TABLE SQL_86.rendiciones
END
GO

IF EXISTS ( SELECT *
			FROM INFORMATION_SCHEMA.TABLES
			WHERE TABLE_SCHEMA = 'SQL_86'
				AND TABLE_NAME = 'clientes'
)
BEGIN
	DROP TABLE SQL_86.clientes
END
GO

IF EXISTS ( SELECT *
			FROM INFORMATION_SCHEMA.TABLES
			WHERE TABLE_SCHEMA = 'SQL_86'
				AND TABLE_NAME = 'empresas'
)
BEGIN
	DROP TABLE SQL_86.empresas
END
GO

IF EXISTS ( SELECT *
			FROM INFORMATION_SCHEMA.TABLES
			WHERE TABLE_SCHEMA = 'SQL_86'
				AND TABLE_NAME = 'rubros'
)
BEGIN
	DROP TABLE SQL_86.rubros
END
GO



/****** Inicio creacion tablas ******/

-- -----------------------------------------------------
-- Table SQL_86.clientes
-- -----------------------------------------------------
CREATE TABLE SQL_86.clientes (
	id INT IDENTITY(1,1) PRIMARY KEY,
	dni CHAR(8) NOT NULL,
	apellido VARCHAR(50) NOT NULL,
	nombre VARCHAR(50) NOT NULL,
	fecha_nacimiento DATETIME NOT NULL,
	mail VARCHAR(60) NOT NULL,
	direccion VARCHAR(100) NOT NULL,
	cp VARCHAR(10) NOT NULL,
	piso VARCHAR(4) NULL,
	depto VARCHAR(4) NULL,
	telefono VARCHAR(15) NULL,
	localidad VARCHAR(100) NULL
)
GO

-- Volver los campos a nulos despues.


-- -----------------------------------------------------
-- Table SQL_86.rubros
-- -----------------------------------------------------
CREATE TABLE SQL_86.rubros (
   id INT PRIMARY KEY,
   descripcion VARCHAR(100) NOT NULL
)
GO


-- -----------------------------------------------------
-- Table SQL_86.empresas
-- -----------------------------------------------------
CREATE TABLE SQL_86.empresas (
  id INT IDENTITY(1,1) PRIMARY KEY,
  nombre VARCHAR(100) NOT NULL,
  cuit NVARCHAR(50) UNIQUE NOT NULL,
  direccion NVARCHAR(255) NOT NULL,
  id_rubro INT NOT NULL,
  estado CHAR(1) NOT NULL,
  porcentaje_rendicion DECIMAL(4,2) NOT NULL
)
GO

ALTER TABLE SQL_86.empresas WITH CHECK ADD  CONSTRAINT FK_id_rubro_empresa FOREIGN KEY( id_rubro )
REFERENCES SQL_86.rubros (id)
GO

ALTER TABLE SQL_86.empresas CHECK CONSTRAINT FK_id_rubro_empresa
GO


-- -----------------------------------------------------
-- Table SQL_86.sucursales
-- -----------------------------------------------------
CREATE TABLE SQL_86.sucursales (
  id INT IDENTITY(1,1) PRIMARY KEY,
  estado CHAR(1) NOT NULL,
  nombre VARCHAR(50) NOT NULL,
  direccion VARCHAR(100) NOT NULL,
  cp VARCHAR(10) UNIQUE NOT NULL
)
GO


-- -----------------------------------------------------
-- Table SQL_86.rendiciones
-- -----------------------------------------------------
CREATE TABLE SQL_86.rendiciones (
  id INT IDENTITY(1,1) PRIMARY KEY,
  fecha DATETIME NOT NULL,
  id_empresa INT NOT NULL,
  total DECIMAL(20,2) NOT NULL,
  cantidad_facturas INT NOT NULL,
  importe DECIMAL(20,2) NOT NULL,
  porcentaje_rendicion DECIMAL(4,2) NOT NULL,
  estado CHAR(1) NOT NULL
)
GO

ALTER TABLE SQL_86.rendiciones WITH CHECK ADD  CONSTRAINT FK_id_empresa_rendicion FOREIGN KEY( id_empresa )
REFERENCES SQL_86.empresas (id)
GO

ALTER TABLE SQL_86.rendiciones CHECK CONSTRAINT FK_id_empresa_rendicion
GO


-- -----------------------------------------------------
-- Table SQL_86.facturas
-- -----------------------------------------------------
CREATE TABLE SQL_86.facturas (
  id INT IDENTITY(1,1) PRIMARY KEY,
  numero INT NOT NULL,
  fecha DATETIME NOT NULL,
  importe DECIMAL(10,2) NOT NULL,
  fecha_vencimiento DATETIME NOT NULL,
  id_empresa INT NOT NULL,
  id_cliente INT NOT NULL,
  estado CHAR(1) NOT NULL,
  id_sucursal INT NOT NULL,
  id_rendicion INT NOT NULL
)
GO

ALTER TABLE SQL_86.facturas WITH CHECK ADD  CONSTRAINT FK_id_empresa_factura FOREIGN KEY( id_empresa )
REFERENCES SQL_86.empresas (id)
GO

ALTER TABLE SQL_86.facturas CHECK CONSTRAINT FK_id_empresa_factura
GO

ALTER TABLE SQL_86.facturas WITH CHECK ADD  CONSTRAINT FK_id_cliente_factura FOREIGN KEY( id_cliente )
REFERENCES SQL_86.clientes (id)
GO

ALTER TABLE SQL_86.facturas CHECK CONSTRAINT FK_id_cliente_factura
GO

ALTER TABLE SQL_86.facturas WITH CHECK ADD  CONSTRAINT FK_id_sucursal_factura FOREIGN KEY( id_sucursal )
REFERENCES SQL_86.sucursales (id)
GO

ALTER TABLE SQL_86.facturas CHECK CONSTRAINT FK_id_sucursal_factura
GO


-- -----------------------------------------------------
-- Table SQL_86.facturas_items
-- -----------------------------------------------------
CREATE TABLE SQL_86.facturas_items (
  id INT IDENTITY(1,1) PRIMARY KEY,
  id_factura INT NOT NULL,
  monto DECIMAL(10,2) NOT NULL,
  cantidad INT NOT NULL
)
GO

ALTER TABLE SQL_86.facturas_items WITH CHECK ADD  CONSTRAINT FK_id_factura_factura_item FOREIGN KEY( id_factura )
REFERENCES SQL_86.facturas (id)
GO

ALTER TABLE SQL_86.facturas_items CHECK CONSTRAINT FK_id_factura_factura_item
GO


-- -----------------------------------------------------
-- Table SQL_86.medios_pagos
-- -----------------------------------------------------
CREATE TABLE SQL_86.medios_pagos (
  id INT IDENTITY(1,1) PRIMARY KEY,
  nombre VARCHAR(50) UNIQUE NOT NULL
)
GO


-- -----------------------------------------------------
-- Table SQL_86.pagos
-- -----------------------------------------------------
CREATE TABLE SQL_86.pagos (
  id INT IDENTITY(1,1) PRIMARY KEY,
  importe DECIMAL(10,2) NOT NULL,
  fecha DATETIME NOT NULL,
  id_medio INT NOT NULL,
  estado CHAR(1) NOT NULL
)
GO
  

ALTER TABLE SQL_86.pagos WITH CHECK ADD  CONSTRAINT FK_id_medio_pago FOREIGN KEY( id_medio )
REFERENCES SQL_86.medios_pagos (id)
GO

ALTER TABLE SQL_86.pagos CHECK CONSTRAINT FK_id_medio_pago
GO


-- -----------------------------------------------------
-- Table SQL_86.roles
-- -----------------------------------------------------
CREATE TABLE SQL_86.roles (
  id INT IDENTITY(1,1) PRIMARY KEY,
  nombre VARCHAR(50) UNIQUE NOT NULL,
)
GO

-- -----------------------------------------------------
-- Table SQL_86.usuarios
-- -----------------------------------------------------
CREATE TABLE SQL_86.usuarios (
  id INT IDENTITY(1,1) PRIMARY KEY,
  usuario VARCHAR(50) UNIQUE NOT NULL,
  password VARCHAR(150) NOT NULL,
  id_rol INT NOT NULL,
  id_sucursal INT NOT NULL
)
GO

ALTER TABLE SQL_86.usuarios WITH CHECK ADD  CONSTRAINT FK_id_sucursal_usuario FOREIGN KEY( id_sucursal )
REFERENCES SQL_86.sucursales (id)
GO

ALTER TABLE SQL_86.usuarios CHECK CONSTRAINT FK_id_sucursal_usuario
GO


-- -----------------------------------------------------
-- Table SQL_86.funcionalidades
-- -----------------------------------------------------
CREATE TABLE SQL_86.funcionalidades (
  id INT IDENTITY(1,1) PRIMARY KEY,
  nombre VARCHAR(50) UNIQUE NOT NULL
)
GO


-- -----------------------------------------------------
-- Table SQL_86.rel_roles_funcionalidades
-- -----------------------------------------------------
CREATE TABLE SQL_86.rel_roles_funcionalidades (
  id_rol INT NOT NULL,
  id_funcionalidad INT NOT NULL,
  PRIMARY KEY (id_rol, id_funcionalidad)
)
GO
 
ALTER TABLE SQL_86.rel_roles_funcionalidades WITH CHECK ADD  CONSTRAINT FK_id_rol_rol_funcionalidad FOREIGN KEY( id_rol )
REFERENCES SQL_86.roles (id)
GO

ALTER TABLE SQL_86.rel_roles_funcionalidades CHECK CONSTRAINT FK_id_rol_rol_funcionalidad
GO

ALTER TABLE SQL_86.rel_roles_funcionalidades WITH CHECK ADD  CONSTRAINT FK_id_funcionalidad_rol_funcionalidad FOREIGN KEY( id_funcionalidad )
REFERENCES SQL_86.funcionalidades (id)
GO

ALTER TABLE SQL_86.rel_roles_funcionalidades CHECK CONSTRAINT FK_id_funcionalidad_rol_funcionalidad
GO


-- -----------------------------------------------------
-- Table SQL_86.pagos_detalles
-- -----------------------------------------------------
CREATE TABLE SQL_86.pagos_detalles (
  id_pago INT NOT NULL,
  id_factura INT NOT NULL,
  PRIMARY KEY (id_pago, id_factura)
)
GO

ALTER TABLE SQL_86.pagos_detalles WITH CHECK ADD  CONSTRAINT FK_id_pago_pago_detalle FOREIGN KEY( id_pago )
REFERENCES SQL_86.pagos (id)
GO

ALTER TABLE SQL_86.pagos_detalles CHECK CONSTRAINT FK_id_pago_pago_detalle
GO

ALTER TABLE SQL_86.pagos_detalles WITH CHECK ADD  CONSTRAINT FK_id_factura_pago_detalle FOREIGN KEY( id_factura )
REFERENCES SQL_86.facturas (id)
GO

ALTER TABLE SQL_86.pagos_detalles CHECK CONSTRAINT FK_id_factura_pago_detalle
GO


-- -----------------------------------------------------
-- Table SQL_86.pagos_devoluciones
-- -----------------------------------------------------
CREATE TABLE SQL_86.pagos_devoluciones (
  id_devolucion INT IDENTITY(1,1) PRIMARY KEY,
  id_pago INT NOT NULL,
  fecha DATETIME NOT NULL,
  descripcion VARCHAR(150) NOT NULL
)
GO

ALTER TABLE SQL_86.pagos_devoluciones WITH CHECK ADD  CONSTRAINT FK_id_pago_pago_devolucion FOREIGN KEY( id_pago )
REFERENCES SQL_86.pagos (id)
GO

ALTER TABLE SQL_86.pagos_devoluciones CHECK CONSTRAINT FK_id_pago_pago_devolucion
GO

/****** fin creacion tablas ******/

INSERT INTO SQL_86.clientes ( dni, apellido, nombre, fecha_nacimiento, mail, direccion, cp )
SELECT DISTINCT [Cliente-Dni]
	,[Cliente-Apellido]
	,[Cliente-Nombre]
	,[Cliente-Fecha_Nac]
	,[Cliente_Mail]
	,[Cliente_Direccion]
	,[Cliente_Codigo_Postal]
FROM gd_esquema.Maestra 


INSERT INTO SQL_86.rubros ( id, descripcion )
SELECT DISTINCT Empresa_Rubro
	,Rubro_Descripcion
FROM gd_esquema.Maestra

-- Rubros: Agregar IDENTITY despues de importar registros de tabla maestra

INSERT INTO SQL_86.empresas ( nombre, cuit, direccion, id_rubro, estado, porcentaje_rendicion )
SELECT DISTINCT Empresa_Nombre
	,Empresa_Cuit
	,Empresa_Direccion
	,Empresa_Rubro
	,'A'
	,0 
FROM gd_esquema.Maestra

INSERT INTO SQL_86.sucursales ( nombre, direccion, cp, estado )
SELECT DISTINCT Sucursal_nombre
	,Sucursal_Dirección
	,Sucursal_codigo_postal
	, 'A'
FROM gd_esquema.Maestra
WHERE Sucursal_Nombre IS NOT NULL
ORDER BY Sucursal_Nombre

-- Insertar rendiciones finalizadas
INSERT INTO SQL_86.rendiciones ( total, fecha, id_empresa, cantidad_facturas, importe, porcentaje_rendicion, estado )
SELECT DISTINCT (SELECT SUM(total) FROM gd_esquema.Maestra WHERE MONTH(Rendicion_Fecha)=MONTH(r.Rendicion_Fecha)) AS Rendicion_Total,
		r.Rendicion_Fecha,
		1 AS id_empresa,
		(SELECT COUNT(*) FROM gd_esquema.Maestra WHERE MONTH(Rendicion_Fecha)=MONTH(r.Rendicion_Fecha)) AS Rendicion_Cantidad_Facturas,
		(SELECT SUM(ItemRendicion_Importe) FROM gd_esquema.Maestra WHERE MONTH(Rendicion_Fecha)=MONTH(r.Rendicion_Fecha)) AS Ganancia_PagoAgil,
		CAST ((ItemRendicion_Importe*100)/Factura_Total AS decimal (4,2)) AS Porcentaje_Ganancia,
		'F' AS estado
FROM gd_esquema.Maestra r
WHERE Rendicion_Nro IS NOT NULL
GROUP BY Rendicion_Total
ORDER BY Rendicion_Fecha


-- Insertar rendiciones pendientes