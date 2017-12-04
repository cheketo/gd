-----------------------------------------------
-- SELECCION DE BASE DE DATOS - INICIO
-- Se selecciona la base de datos 'GD2C2017'.
-----------------------------------------------

USE [GD2C2017]
GO

-----------------------------------------------
-- SELECCION DE BASE DE DATOS - FIN
-----------------------------------------------



-----------------------------------------------
-- CREACION DEL SCHEMA - INICIO
-- Crea el schema si no existe.
-----------------------------------------------

IF NOT EXISTS (
SELECT  schema_name
FROM    information_schema.schemata
WHERE   schema_name = 'SQL_86' )
BEGIN
EXEC sp_executesql N'CREATE SCHEMA SQL_86'
END

-----------------------------------------------
-- CREACION DEL SCHEMA - FIN
-----------------------------------------------



-----------------------------------------------
-- ELIMINACION DE VISTAS - INICIO
-- Elimina las vistas si existen.
-----------------------------------------------

IF OBJECT_ID ( 'SQL_86.vw_listado_empresas', 'V') IS NOT NULL
DROP VIEW SQL_86.vw_listado_empresas
GO

IF OBJECT_ID ( 'SQL_86.vw_listado_sucursales', 'V') IS NOT NULL
DROP VIEW SQL_86.vw_listado_sucursales
GO

IF OBJECT_ID ( 'SQL_86.vw_listado_roles', 'V') IS NOT NULL
DROP VIEW SQL_86.vw_listado_roles
GO

IF OBJECT_ID ( 'SQL_86.vw_listado_facturas', 'V') IS NOT NULL
DROP VIEW SQL_86.vw_listado_facturas
GO

-----------------------------------------------
-- ELIMINACION DE VISTAS - FIN
-----------------------------------------------



-----------------------------------------------
-- ELIMINACION STOREPROCEDURE - INICIO
-- Elimina storeprocedure si existen.
-----------------------------------------------

IF OBJECT_ID('SQL_86.ClientesConMasPagos', 'P') IS NOT NULL
DROP PROC SQL_86.ClientesConMasPagos
GO

-----------------------------------------------
-- ELIMINACION STOREPROCEDURE - FIN
-----------------------------------------------


-----------------------------------------------
-- ELIMINACION DE TABLAS - INICIO
-- Elimina las tablas si existen.
-----------------------------------------------

IF OBJECT_ID ( 'SQL_86.rel_roles_funcionalidades', 'U') IS NOT NULL
DROP TABLE SQL_86.rel_roles_funcionalidades
GO

IF OBJECT_ID ( 'SQL_86.devoluciones_items', 'U' ) IS NOT NULL
DROP TABLE SQL_86.devoluciones_items
GO

IF OBJECT_ID ( 'SQL_86.devoluciones', 'U' ) IS NOT NULL
DROP TABLE SQL_86.devoluciones
GO

IF OBJECT_ID ( 'SQL_86.facturas_items', 'U') IS NOT NULL
DROP TABLE SQL_86.facturas_items
GO

IF OBJECT_ID ( 'SQL_86.rel_roles_usuarios', 'U') IS NOT NULL
DROP TABLE SQL_86.rel_roles_usuarios
GO

IF OBJECT_ID ( 'SQL_86.usuarios', 'U' ) IS NOT NULL
DROP TABLE SQL_86.usuarios
GO

IF OBJECT_ID ( 'SQL_86.roles', 'U' ) IS NOT NULL
DROP TABLE SQL_86.roles
GO

IF OBJECT_ID ( 'SQL_86.funcionalidades', 'U' ) IS NOT NULL
DROP TABLE SQL_86.funcionalidades
GO

IF OBJECT_ID ( 'SQL_86.facturas', 'U' ) IS NOT NULL
DROP TABLE SQL_86.facturas
GO

IF OBJECT_ID ( 'SQL_86.pagos', 'U' ) IS NOT NULL
DROP TABLE SQL_86.pagos
GO

IF OBJECT_ID ( 'SQL_86.medios_pagos', 'U') IS NOT NULL
DROP TABLE SQL_86.medios_pagos
GO

IF OBJECT_ID ( 'SQL_86.sucursales', 'U' ) IS NOT NULL
DROP TABLE SQL_86.sucursales
GO

IF OBJECT_ID ( 'SQL_86.rendiciones', 'U' ) IS NOT NULL
DROP TABLE SQL_86.rendiciones
GO

IF OBJECT_ID ( 'SQL_86.clientes', 'U' ) IS NOT NULL
DROP TABLE SQL_86.clientes
GO

IF OBJECT_ID ( 'SQL_86.empresas', 'U' ) IS NOT NULL
DROP TABLE SQL_86.empresas
GO

IF OBJECT_ID ( 'SQL_86.rubros', 'U' ) IS NOT NULL
DROP TABLE SQL_86.rubros
GO

-----------------------------------------------
-- ELIMINACION DE TABLAS - FIN
-----------------------------------------------



-----------------------------------------------
-- CREACION DE TABLAS - INICIO
-- Crean las tablas de la base de datos.
-----------------------------------------------

-- Table SQL_86.clientes
CREATE TABLE SQL_86.clientes (
	id INT IDENTITY(1,1) PRIMARY KEY,
	dni VARCHAR(8) UNIQUE NOT NULL,
	apellido VARCHAR(50) NOT NULL,
	nombre VARCHAR(50) NOT NULL,
	fecha_nacimiento DATETIME NOT NULL,
	mail VARCHAR(60) NOT NULL,
	direccion VARCHAR(100) NOT NULL,
	cp VARCHAR(10) NOT NULL,
	piso VARCHAR(4) NULL,
	depto VARCHAR(4) NULL,
	telefono VARCHAR(15) NULL,
	localidad VARCHAR(100) NULL,
	estado CHAR(1) NOT NULL
)
GO


-- Table SQL_86.rubros
CREATE TABLE SQL_86.rubros (
   id INT PRIMARY KEY IDENTITY(1,1),
   descripcion VARCHAR(100) NOT NULL
)
GO


-- Table SQL_86.empresas
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

ALTER TABLE SQL_86.empresas WITH CHECK ADD CONSTRAINT FK_id_rubro_empresa FOREIGN KEY( id_rubro )
REFERENCES SQL_86.rubros (id)
GO

ALTER TABLE SQL_86.empresas CHECK CONSTRAINT FK_id_rubro_empresa
GO


-- Table SQL_86.sucursales
CREATE TABLE SQL_86.sucursales (
  id INT IDENTITY(1,1) PRIMARY KEY,
  estado CHAR(1) NOT NULL,
  nombre VARCHAR(50) NOT NULL,
  direccion VARCHAR(100) NOT NULL,
  cp VARCHAR(10) UNIQUE NOT NULL
)
GO


-- Table SQL_86.rendiciones
CREATE TABLE SQL_86.rendiciones (
  id INT IDENTITY(1,1) PRIMARY KEY,
  fecha DATETIME NOT NULL,
  id_empresa INT NOT NULL,
  total DECIMAL(20,2) NOT NULL,
  importe DECIMAL(20,2) NOT NULL,
)
GO

ALTER TABLE SQL_86.rendiciones WITH CHECK ADD CONSTRAINT FK_id_empresa_rendicion FOREIGN KEY( id_empresa )
REFERENCES SQL_86.empresas (id)
GO

ALTER TABLE SQL_86.rendiciones CHECK CONSTRAINT FK_id_empresa_rendicion
GO


-- Table SQL_86.facturas
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
  id_rendicion INT,
  id_pago INT
)
GO

ALTER TABLE SQL_86.facturas WITH CHECK ADD CONSTRAINT FK_id_empresa_factura FOREIGN KEY( id_empresa )
REFERENCES SQL_86.empresas (id)
GO

ALTER TABLE SQL_86.facturas CHECK CONSTRAINT FK_id_empresa_factura
GO

ALTER TABLE SQL_86.facturas WITH CHECK ADD CONSTRAINT FK_id_cliente_factura FOREIGN KEY( id_cliente )
REFERENCES SQL_86.clientes (id)
GO

ALTER TABLE SQL_86.facturas CHECK CONSTRAINT FK_id_cliente_factura
GO

ALTER TABLE SQL_86.facturas WITH CHECK ADD CONSTRAINT FK_id_sucursal_factura FOREIGN KEY( id_sucursal )
REFERENCES SQL_86.sucursales (id)
GO

ALTER TABLE SQL_86.facturas CHECK CONSTRAINT FK_id_sucursal_factura
GO

ALTER TABLE SQL_86.facturas WITH CHECK ADD CONSTRAINT FK_id_rendicion_factura FOREIGN KEY( id_rendicion )
REFERENCES SQL_86.rendiciones (id)
GO

ALTER TABLE SQL_86.facturas CHECK CONSTRAINT FK_id_rendicion_factura
GO


-- Table SQL_86.facturas_items
CREATE TABLE SQL_86.facturas_items (
  id INT IDENTITY(1,1) PRIMARY KEY,
  id_factura INT NOT NULL,
  monto DECIMAL(10,2) NOT NULL,
  cantidad INT NOT NULL
)
GO

ALTER TABLE SQL_86.facturas_items WITH CHECK ADD CONSTRAINT FK_id_factura_factura_item FOREIGN KEY( id_factura )
REFERENCES SQL_86.facturas (id)
GO

ALTER TABLE SQL_86.facturas_items CHECK CONSTRAINT FK_id_factura_factura_item
GO


-- Table SQL_86.medios_pagos
CREATE TABLE SQL_86.medios_pagos (
  id INT IDENTITY(1,1) PRIMARY KEY,
  nombre VARCHAR(50) UNIQUE NOT NULL
)
GO


-- Table SQL_86.pagos
CREATE TABLE SQL_86.pagos (
  id INT IDENTITY(1,1) PRIMARY KEY,
  importe DECIMAL(10,2) NOT NULL,
  fecha DATETIME NOT NULL,
  estado CHAR(1) NOT NULL,
  id_medio INT NOT NULL,
  id_cliente INT NOT NULL
)
GO

ALTER TABLE SQL_86.pagos WITH CHECK ADD CONSTRAINT FK_id_medio_pago FOREIGN KEY( id_medio )
REFERENCES SQL_86.medios_pagos (id)
GO

ALTER TABLE SQL_86.pagos CHECK CONSTRAINT FK_id_medio_pago
GO

ALTER TABLE SQL_86.pagos WITH CHECK ADD CONSTRAINT FK_id_cliente_pago FOREIGN KEY( id_cliente )
REFERENCES SQL_86.clientes (id)
GO

ALTER TABLE SQL_86.pagos CHECK CONSTRAINT FK_id_cliente_pago
GO

-- Table SQL_86.devoluciones
CREATE TABLE SQL_86.devoluciones (
  id INT IDENTITY(1,1) PRIMARY KEY,
  id_cliente INT NOT NULL,
  importe DECIMAL(10,2) NOT NULL,
  motivo NVARCHAR(255),
  fecha DATETIME NOT NULL
)
GO

ALTER TABLE SQL_86.devoluciones WITH CHECK ADD CONSTRAINT FK_id_devolucion_cliente FOREIGN KEY( id_cliente )
REFERENCES SQL_86.clientes (id)
GO

ALTER TABLE SQL_86.devoluciones CHECK CONSTRAINT FK_id_devolucion_cliente
GO

-- Table SQL_86.devoluciones_items
CREATE TABLE SQL_86.devoluciones_items (
  id INT IDENTITY(1,1) PRIMARY KEY,
  id_devolucion INT NOT NULL,
  id_factura INT NOT NULL,
  id_pago INT NOT NULL,
  importe DECIMAL(10,2) NOT NULL
)
GO

ALTER TABLE SQL_86.devoluciones_items WITH CHECK ADD CONSTRAINT FK_id_devolucion_devolucion_item FOREIGN KEY( id_devolucion )
REFERENCES SQL_86.devoluciones (id)
GO

ALTER TABLE SQL_86.devoluciones_items CHECK CONSTRAINT FK_id_devolucion_devolucion_item
GO

ALTER TABLE SQL_86.devoluciones_items WITH CHECK ADD CONSTRAINT FK_id_factura_devolucion_item FOREIGN KEY( id_factura )
REFERENCES SQL_86.facturas (id)
GO

ALTER TABLE SQL_86.devoluciones_items CHECK CONSTRAINT FK_id_factura_devolucion_item
GO

ALTER TABLE SQL_86.devoluciones_items WITH CHECK ADD CONSTRAINT FK_id_pago_devolucion_item FOREIGN KEY( id_pago )
REFERENCES SQL_86.pagos (id)
GO

ALTER TABLE SQL_86.devoluciones_items CHECK CONSTRAINT FK_id_pago_devolucion_item
GO

--Crea FK para la tabla facturas relacionando el id de pago
ALTER TABLE SQL_86.facturas WITH CHECK ADD CONSTRAINT FK_id_pago_factura FOREIGN KEY( id_pago )
REFERENCES SQL_86.pagos (id)
GO

ALTER TABLE SQL_86.facturas CHECK CONSTRAINT FK_id_pago_factura
GO


-- Table SQL_86.roles
CREATE TABLE SQL_86.roles (
  id INT IDENTITY(1,1) PRIMARY KEY,
  nombre VARCHAR(50) UNIQUE NOT NULL,
  estado CHAR(1) NOT NULL
)
GO


-- Table SQL_86.usuarios
CREATE TABLE SQL_86.usuarios (
  id INT IDENTITY(1,1) PRIMARY KEY,
  usuario VARCHAR(50) UNIQUE NOT NULL,
  password NVARCHAR(64) NOT NULL,
  intentos INT NOT NULL,
  estado CHAR(1) NOT NULL,
  id_sucursal INT NOT NULL
)
GO

ALTER TABLE SQL_86.usuarios WITH CHECK ADD CONSTRAINT FK_id_sucursal_usuario FOREIGN KEY( id_sucursal )
REFERENCES SQL_86.sucursales (id)
GO

ALTER TABLE SQL_86.usuarios CHECK CONSTRAINT FK_id_sucursal_usuario
GO


-- Table SQL_86.rel_roles_usuarios
CREATE TABLE SQL_86.rel_roles_usuarios (
  id_rol INT NOT NULL,
  id_usuario INT NOT NULL,
  PRIMARY KEY (id_rol, id_usuario)
)
GO

ALTER TABLE SQL_86.rel_roles_usuarios WITH CHECK ADD CONSTRAINT FK_id_rol_rol_usuario FOREIGN KEY( id_rol )
REFERENCES SQL_86.roles (id)
GO

ALTER TABLE SQL_86.rel_roles_usuarios CHECK CONSTRAINT FK_id_rol_rol_usuario
GO

ALTER TABLE SQL_86.rel_roles_usuarios WITH CHECK ADD CONSTRAINT FK_id_usuario_rol_usuario FOREIGN KEY( id_usuario )
REFERENCES SQL_86.usuarios (id)
GO

ALTER TABLE SQL_86.rel_roles_usuarios CHECK CONSTRAINT FK_id_usuario_rol_usuario
GO


-- Table SQL_86.funcionalidades
CREATE TABLE SQL_86.funcionalidades (
  id INT IDENTITY(1,1) PRIMARY KEY,
  nombre VARCHAR(50) UNIQUE NOT NULL
)
GO


-- Table SQL_86.rel_roles_funcionalidades
CREATE TABLE SQL_86.rel_roles_funcionalidades (
  id_rol INT NOT NULL,
  id_funcionalidad INT NOT NULL,
  PRIMARY KEY (id_rol, id_funcionalidad)
)
GO
 
ALTER TABLE SQL_86.rel_roles_funcionalidades WITH CHECK ADD CONSTRAINT FK_id_rol_rol_funcionalidad FOREIGN KEY( id_rol )
REFERENCES SQL_86.roles (id)
GO

ALTER TABLE SQL_86.rel_roles_funcionalidades CHECK CONSTRAINT FK_id_rol_rol_funcionalidad
GO

ALTER TABLE SQL_86.rel_roles_funcionalidades WITH CHECK ADD CONSTRAINT FK_id_funcionalidad_rol_funcionalidad FOREIGN KEY( id_funcionalidad )
REFERENCES SQL_86.funcionalidades (id)
GO

ALTER TABLE SQL_86.rel_roles_funcionalidades CHECK CONSTRAINT FK_id_funcionalidad_rol_funcionalidad
GO

-----------------------------------------------
-- CREACION DE TABLAS - FIN
-----------------------------------------------



-----------------------------------------------
-- CREACION DE TRIGGERS - INICIO
-----------------------------------------------

-- Trigger SQL_86.tr_claves_usuarios
CREATE TRIGGER SQL_86.tr_claves_usuarios ON SQL_86.usuarios 
AFTER INSERT,UPDATE
AS
	DECLARE @id INT;
	DECLARE @intentos INT;
	DECLARE @password NVARCHAR(64);
	DECLARE @estado CHAR(1);

	SELECT @password = i.password, @id=i.id, @intentos=i.intentos FROM INSERTED i;
	IF(@password!=(SELECT password FROM SQL_86.usuarios WHERE id=@id) OR NOT EXISTS (SELECT * FROM DELETED))
		SELECT @password = CONVERT(NVARCHAR(64),HASHBYTES('SHA2_256', CONVERT(VARCHAR(64),@password)),2);

	IF(@intentos>2)
		SET @estado = 'I';
	ELSE
		SET @estado = 'A';

	UPDATE SQL_86.usuarios SET password = @password, estado=@estado WHERE id=@id;
	PRINT 'Se ejecuto el trigger tr_claves_usuarios.';
GO

-- Trigger SQL_86.tr_devolver_factura
CREATE TRIGGER SQL_86.tr_devolver_factura ON SQL_86.devoluciones_items 
AFTER INSERT
AS
	DECLARE @idFactura INT,@idPago INT;
	DECLARE @importeFactura DECIMAL(10,2);
	DECLARE CR CURSOR FAST_FORWARD FOR SELECT id_factura FROM INSERTED;
	
	OPEN CR 
	FETCH NEXT FROM CR INTO @idFactura

	WHILE @@FETCH_STATUS = 0 
	BEGIN 
		SELECT @idPago=i.id_pago,@importeFactura=i.importe FROM INSERTED i WHERE id_factura=@idFactura;
		UPDATE SQL_86.facturas SET estado='D', id_pago=NULL WHERE id=@idFactura;
		UPDATE SQL_86.pagos SET importe=importe-@importeFactura WHERE id=@idPago;
		FETCH NEXT FROM CR into @idFactura
	END

	CLOSE CR
	DEALLOCATE CR


GO

-- Trigger SQL_86.tr_modificar_estado_pago
CREATE TRIGGER SQL_86.tr_modificar_estado_pago ON SQL_86.pagos
AFTER UPDATE
AS
	DECLARE @idPago INT;
	DECLARE @importe DECIMAL(10,2);

	SELECT @idPago = i.id, @importe = i.importe FROM INSERTED i;
	IF(NOT @importe>0)
		UPDATE SQL_86.pagos SET estado='I' WHERE id=@idPago;
GO

-----------------------------------------------
-- CREACION DE TRIGGERS - FIN
-----------------------------------------------



-----------------------------------------------
-- CREACION PROCEDIMIENTOS - INICIO
-----------------------------------------------

-- Procedimiento Clientes con mas pagos.
CREATE PROCEDURE SQL_86.ClientesConMasPagos(@Anio int, @Trimestre int)
AS BEGIN
	SELECT TOP 5 c.Nombre, c.Apellido, ISNULL(count(*),0) "cantidadPagos" 
	FROM SQL_86.Pagos p, SQL_86.Clientes c
	WHERE YEAR(fecha) = @Anio
		AND p.id = c.id
		AND MONTH(fecha) BETWEEN ((3 * @Trimestre) - 2) and (3 * @Trimestre)
	GROUP BY c.id, c.Nombre, c.Apellido
	ORDER BY "cantidadPagos" DESC
END
GO

-----------------------------------------------
-- CREACION PROCEDIMIENTOS - FIN
-----------------------------------------------



-----------------------------------------------
-- CREACION DE VISTAS - INICIO
-----------------------------------------------

-- Vista SQL_86.vw_listado_empresas
CREATE VIEW SQL_86.vw_listado_empresas AS
SELECT a.id,a.nombre,a.cuit,a.direccion,b.descripcion as rubro,a.estado,a.porcentaje_rendicion FROM SQL_86.empresas a
JOIN SQL_86.rubros b ON (b.id=a.id_rubro)
GO

-- Vista SQL_86.vw_listado_sucursales
CREATE VIEW SQL_86.vw_listado_sucursales AS
SELECT id,(CASE WHEN estado = 'A' THEN 'Activo' ELSE 'Inactivo' END) AS estado,nombre,direccion,cp as Codigo_Postal FROM SQL_86.sucursales
GO

-- Vista SQL_86.vw_listado_roles
CREATE VIEW SQL_86.vw_listado_roles AS
SELECT id,(CASE WHEN estado = 'A' THEN 'Activo' ELSE 'Inactivo' END) AS estado,nombre FROM SQL_86.roles
GO

-- Vista SQL_86.vw_listado_facturas
CREATE VIEW SQL_86.vw_listado_facturas AS
SELECT a.*,(CASE
			WHEN a.estado = 'F' THEN 'Rendida'
			WHEN a.estado = 'D' THEN 'Devuelta'
			WHEN a.estado = 'P' THEN 'Pendiente'
			WHEN a.estado = 'A' THEN 'Pagada'
			ELSE 'Inactiva'
		END) AS texto_estado,b.nombre AS empresa,CONCAT(c.nombre,', ',c.apellido) AS cliente
FROM SQL_86.facturas a
JOIN SQL_86.empresas b ON (b.id=a.id_empresa)
JOIN SQL_86.clientes c ON (c.id=a.id_cliente)
GO

-----------------------------------------------
-- CREACION DE VISTAS - FIN
-----------------------------------------------


-----------------------------------------------
-- INSERCION DE DATOS - INICIO
-- Inserta los datos de la tabla master
-- a las diferentes tablas
-----------------------------------------------

--Inserta Datos en la tabla clientes.
INSERT INTO SQL_86.clientes ( dni, apellido, nombre, fecha_nacimiento, mail, direccion, cp, estado )
SELECT DISTINCT [Cliente-Dni]
	,[Cliente-Apellido]
	,[Cliente-Nombre]
	,[Cliente-Fecha_Nac]
	,[Cliente_Mail]
	,[Cliente_Direccion]
	,[Cliente_Codigo_Postal]
	,'A'
FROM gd_esquema.Maestra 


--Inserta datos en la tabla rubros.
SET IDENTITY_INSERT SQL_86.rubros ON

INSERT INTO SQL_86.rubros ( id, descripcion )
SELECT DISTINCT Empresa_Rubro 
	,Rubro_Descripcion
FROM gd_esquema.Maestra

SET IDENTITY_INSERT SQL_86.rubros OFF


--Inserta datos en la tabla empresas.
INSERT INTO SQL_86.empresas ( nombre, cuit, direccion, id_rubro, estado, porcentaje_rendicion )
SELECT DISTINCT Empresa_Nombre
	,Empresa_Cuit
	,Empresa_Direccion
	,Empresa_Rubro
	,'A'
	,(SELECT TOP 1 (([ItemRendicion_Importe]*100)/[Factura_Total]) AS porcentaje FROM gd_esquema.Maestra WHERE [ItemRendicion_Importe]>0 ORDER BY Rendicion_Fecha DESC)
	--,(SELECT TOP 1 DATEPART(dd,Rendicion_Fecha) AS dia FROM gd_esquema.Maestra WHERE [ItemRendicion_Importe]>0 ORDER BY Rendicion_Fecha DESC)
FROM gd_esquema.Maestra


--Inserta datos en la tabla sucursales.
INSERT INTO SQL_86.sucursales ( nombre, direccion, cp, estado ) VALUES ( 'casa central', 'casa central', '0', 'A')

INSERT INTO SQL_86.sucursales ( nombre, direccion, cp, estado )
SELECT DISTINCT Sucursal_nombre
	,Sucursal_Dirección
	,Sucursal_codigo_postal
	, 'A'
FROM gd_esquema.Maestra
WHERE Sucursal_Nombre IS NOT NULL
ORDER BY Sucursal_Nombre


-- Inserta datos en la tabla rendciones.
SET IDENTITY_INSERT SQL_86.rendiciones ON

INSERT INTO SQL_86.rendiciones ( id, fecha, id_empresa, total, importe )
SELECT [Rendicion_Nro] 
	,[Rendicion_Fecha]
	,1
	,[Factura_Total]
	,[ItemRendicion_Importe]
FROM ( SELECT DISTINCT [Nro_Factura]
	,[Factura_Total]
	,[Rendicion_Nro]
    ,[Rendicion_Fecha]
	,[ItemRendicion_Importe]
	FROM [GD2C2017].[gd_esquema].[Maestra] 
	WHERE ItemRendicion_nro IS NOT NULL 
) r
ORDER BY [Rendicion_Nro] 

SET IDENTITY_INSERT SQL_86.rendiciones OFF


-- Inserta datos en la tabla medios_pagos.
INSERT INTO SQL_86.medios_pagos ( nombre )
SELECT DISTINCT [FormaPagoDescripcion]
FROM [GD2C2017].[gd_esquema].[Maestra]
WHERE [FormaPagoDescripcion] IS NOT NULL 


-- Inserta datos en la tabla pagos.
SET IDENTITY_INSERT SQL_86.pagos ON
GO

INSERT INTO SQL_86.pagos ( id, importe, fecha, id_medio, id_cliente, estado )
SELECT DISTINCT [Pago_nro] 
	, [Total]
	, [Pago_Fecha]
	, mp.id AS id_medio_pago
	, c.id AS id_cliente
	, 'A' AS estado
FROM ( [GD2C2017].[gd_esquema].[Maestra] m 
		JOIN SQL_86.clientes c ON c.dni = m.[Cliente-Dni] 
	) JOIN SQL_86.medios_pagos mp ON mp.nombre = m.FormaPagoDescripcion   
WHERE [Pago_nro] IS NOT NULL
ORDER BY [Pago_nro]
GO

SET IDENTITY_INSERT SQL_86.pagos OFF
GO


-- Inserta facturas rendidas en la tabla facturas.
SET IDENTITY_INSERT SQL_86.facturas ON
GO

INSERT INTO SQL_86.facturas (id,numero,fecha,importe,fecha_vencimiento,id_empresa,id_cliente,estado,id_sucursal,id_rendicion,id_pago)
SELECT DISTINCT m.Nro_Factura AS id
	,m.Nro_Factura
	,m.Factura_Fecha
	,m.Factura_Total
	,m.Factura_Fecha_Vencimiento
	,1
	,c.id as cliente
	,'F'
	,1
	,m.Rendicion_Nro
	,m.Pago_nro
FROM ([GD2C2017].[gd_esquema].[Maestra] m JOIN SQL_86.clientes c ON c.dni = m.[Cliente-Dni])
WHERE m.Pago_nro IS NOT NULL AND Rendicion_Nro IS NOT NULL AND m.Nro_Factura NOT IN (SELECT id FROM SQL_86.facturas)
GO


-- Inserta facturas pagadas en la tabla facturas.
INSERT INTO SQL_86.facturas (id,numero,fecha,importe,fecha_vencimiento,id_empresa,id_cliente,estado,id_sucursal,id_rendicion,id_pago)
SELECT DISTINCT m.Nro_Factura AS id
	,m.Nro_Factura
	,m.Factura_Fecha
	,m.Factura_Total
	,m.Factura_Fecha_Vencimiento
	,1
	,c.id as cliente
	,'A'
	,1
	,NULL
	,m.Pago_nro
FROM ([GD2C2017].[gd_esquema].[Maestra] m JOIN SQL_86.clientes c ON c.dni = m.[Cliente-Dni])
WHERE m.Pago_nro IS NOT NULL AND Rendicion_Nro IS NULL AND m.Nro_Factura NOT IN (SELECT id FROM SQL_86.facturas)
GO


-- Inserta facturas pendientes en la tabla facturas.
INSERT INTO SQL_86.facturas (id,numero,fecha,importe,fecha_vencimiento,id_empresa,id_cliente,estado,id_sucursal,id_rendicion,id_pago)
SELECT DISTINCT m.Nro_Factura AS id
	,m.Nro_Factura
	,m.Factura_Fecha
	,m.Factura_Total
	,m.Factura_Fecha_Vencimiento
	,1
	,c.id as cliente
	,'P'
	,1
	,NULL
	,NULL
FROM ([GD2C2017].[gd_esquema].[Maestra] m JOIN SQL_86.clientes c ON c.dni = m.[Cliente-Dni])
WHERE m.Pago_nro IS NULL AND Rendicion_Nro IS NULL AND m.Nro_Factura NOT IN (SELECT id FROM SQL_86.facturas)
GO
SET IDENTITY_INSERT SQL_86.facturas OFF
GO


-- Inserta datos en la tabla facturas_items.
INSERT INTO SQL_86.facturas_items (id_factura, monto, cantidad)
SELECT Nro_Factura
	,ItemFactura_Cantidad
	,ItemFactura_Monto
FROM [GD2C2017].[gd_esquema].[Maestra]
GROUP BY Nro_Factura, ItemFactura_Cantidad,ItemFactura_Monto
ORDER BY Nro_Factura, ItemFactura_Cantidad,ItemFactura_Monto
GO


-- Inserta datos en la tabla roles.
INSERT INTO SQL_86.roles (nombre,estado)VALUES
	('Administrador','A'),
	('Cobrador','A')
GO

-- Inserta funcionalidades y las relaciona con los roles
INSERT INTO SQL_86.funcionalidades (nombre) VALUES ('Clientes')
GO

INSERT INTO SQL_86.rel_roles_funcionalidades (id_rol,id_funcionalidad) VALUES 
	(1,@@IDENTITY),
	(2,@@IDENTITY)
GO

INSERT INTO SQL_86.funcionalidades (nombre) VALUES ('Empresas')
GO

INSERT INTO SQL_86.rel_roles_funcionalidades (id_rol,id_funcionalidad)VALUES
	(1,@@IDENTITY),
	(2,@@IDENTITY)
GO

INSERT INTO SQL_86.funcionalidades (nombre) VALUES ('Facturas')
GO

INSERT INTO SQL_86.rel_roles_funcionalidades (id_rol,id_funcionalidad) VALUES
	(1,@@IDENTITY),
	(2,@@IDENTITY)
GO

INSERT INTO SQL_86.funcionalidades (nombre) VALUES ('Sucursales')
GO

INSERT INTO SQL_86.rel_roles_funcionalidades (id_rol,id_funcionalidad) VALUES 
	(1,@@IDENTITY),
	(2,@@IDENTITY)
GO

INSERT INTO SQL_86.funcionalidades (nombre) VALUES ('Roles')
GO


-- Inserta usuarios y los relaciona con su rol.
INSERT INTO SQL_86.rel_roles_funcionalidades (id_rol,id_funcionalidad) VALUES 
	(1,@@IDENTITY)
GO

INSERT INTO SQL_86.funcionalidades (nombre) VALUES ('Pagos')
GO

INSERT INTO SQL_86.rel_roles_funcionalidades (id_rol,id_funcionalidad) VALUES 
	(1,@@IDENTITY),
	(2,@@IDENTITY)
GO

INSERT INTO SQL_86.funcionalidades (nombre) VALUES ('Devoluciones')
GO

INSERT INTO SQL_86.rel_roles_funcionalidades (id_rol,id_funcionalidad) VALUES 
	(1,@@IDENTITY),
	(2,@@IDENTITY)
GO

INSERT INTO SQL_86.funcionalidades (nombre) VALUES ('Rendiciones')
GO

INSERT INTO SQL_86.rel_roles_funcionalidades (id_rol,id_funcionalidad) VALUES 
	(1,@@IDENTITY)
GO

INSERT INTO SQL_86.funcionalidades (nombre) VALUES ('Reportes')
GO

INSERT INTO SQL_86.rel_roles_funcionalidades (id_rol,id_funcionalidad) VALUES 
	(1,@@IDENTITY)
GO

------------------------------------
-- INSERCION USUARIOS - INICIO
------------------------------------

-- Admin
INSERT INTO SQL_86.usuarios (usuario,password,intentos,estado,id_sucursal)VALUES('admin','w23e',0,'A',1)
GO

INSERT INTO SQL_86.rel_roles_usuarios (id_rol,id_usuario)VALUES(1,@@IDENTITY),(2,@@IDENTITY);
GO

-- Cobrador
INSERT INTO SQL_86.usuarios (usuario,password,intentos,estado,id_sucursal)VALUES('cobrador','cobrador',0,'A',2)
GO

INSERT INTO SQL_86.rel_roles_usuarios (id_rol,id_usuario)VALUES(2,@@IDENTITY);
GO

------------------------------------
-- INSERCION DE DATOS - FIN
------------------------------------


