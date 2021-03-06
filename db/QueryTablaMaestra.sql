/****** Script para el comando SelectTopNRows de SSMS  ******/
SELECT [Cliente-Dni]
      ,[Cliente-Apellido]
      ,[Cliente-Nombre]
      ,[Cliente-Fecha_Nac]
      ,[Cliente_Mail]
      ,[Cliente_Direccion]
      ,[Cliente_Codigo_Postal]
      ,[Nro_Factura]
      ,[Factura_Fecha]
      ,[Factura_Total]
      ,[Factura_Fecha_Vencimiento]
      ,[ItemFactura_Monto]
      ,[ItemFactura_Cantidad]
      ,[Empresa_Nombre]
      ,[Empresa_Cuit]
      ,[Empresa_Direccion]
      ,[Empresa_Rubro]
      ,[Rubro_Descripcion]
      ,[Pago_nro]
      ,[Pago_Fecha]
      ,[ItemPago_nro]
      ,[Total]
      ,[FormaPagoDescripcion]
      ,[Sucursal_Nombre]
      ,[Sucursal_Dirección]
      ,[Sucursal_Codigo_Postal]
      ,[Rendicion_Nro]
      ,[Rendicion_Fecha]
      ,[ItemRendicion_nro]
      ,[ItemRendicion_Importe]
  FROM [GD2C2017].[gd_esquema].[Maestra]
  --WHERE Nro_Factura IN (
  --WHERE [Pago_nro] IS NOT NULL AND [Rendicion_Nro] IS NULL
 -- order BY Nro_Factura


--- PARA CONCER LAS FACTURAS QUE NO TIENEN PAGOS NI RENDICIONES
SELECT Nro_Factura
FROM [GD2C2017].[gd_esquema].[Maestra]
GROUP BY Nro_Factura
HAVING (COUNT(Nro_Factura)/(COUNT(Nro_Factura)/3)!=3)


SELECT DISTINCT Nro_Factura
FROM [GD2C2017].[gd_esquema].[Maestra]
WHERE Pago_nro IS NULL AND Rendicion_Nro IS NULL



--17324
SELECT DISTINCT Nro_Factura
FROM [GD2C2017].[gd_esquema].[Maestra]
WHERE Pago_nro IS NULL AND Rendicion_Nro IS  NULL
ORDER BY Nro_Factura

SELECT DISTINCT m.Nro_Factura
FROM (SELECT *
		FROM [GD2C2017].[gd_esquema].[Maestra]
		WHERE Pago_nro IS NOT NULL
	 ) m
WHERE m.Pago_nro IS NOT NULL AND m.Rendicion_Nro IS NULL



SELECT DISTINCT Nro_Factura
FROM [GD2C2017].[gd_esquema].[Maestra]
WHERE Nro_Factura NOT IN (SELECT DISTINCT Nro_Factura FROM [GD2C2017].[gd_esquema].[Maestra] WHERE Pago_nro IS NOT NULL OR Rendicion_Nro IS NOT NULL )

SELECT a.*
FROM [GD2C2017].[gd_esquema].[Maestra] a
JOIN (SELECT DISTINCT Nro_Factura FROM [GD2C2017].[gd_esquema].[Maestra] WHERE Pago_nro IS NOT NULL OR Rendicion_Nro IS NOT NULL) b ON (a.Nro_Factura!=b.Nro_Factura)




SELECT f.Nro_Factura
FROM [GD2C2017].[gd_esquema].[Maestra] f
JOIN [GD2C2017].[gd_esquema].[Maestra] p ON (p.Nro_Factura=f.Nro_Factura)
WHERE p.Pago_nro IS NULL
OUTER JOIN [GD2C2017].[gd_esquema].[Maestra] r ON (r.Nro_Factura=f.Nro_Factura)





SELECT DISTINCT [ItemRendicion_nro]
	,[Nro_Factura]
	,[Factura_Fecha]
	,[Factura_Total]
	,[Factura_Fecha_Vencimiento]
FROM [GD2C2017].[gd_esquema].[Maestra]
WHERE [Pago_nro] IS NOT NULL 
ORDER BY [Pago_nro]

SELECT *
FROM SQL_86.rendiciones

SELECT *
FROM SQL_86.pagos


SELECT DISTINCT [Nro_Factura]
	,[Factura_Total]
	,[Rendicion_Nro]
    ,[Rendicion_Fecha]
    ,[ItemRendicion_nro]
	,[ItemRendicion_Importe]
FROM [GD2C2017].[gd_esquema].[Maestra] 
WHERE ItemRendicion_nro IS NOT NULL 
ORDER BY [Rendicion_Nro]

SELECT DISTINCT [Pago_nro] 
	, c.id AS id_cliente
	, [Pago_Fecha]
	, mp.id AS id_medio_pago
	, [Total]
FROM ( [GD2C2017].[gd_esquema].[Maestra] m 
		JOIN SQL_86.clientes c ON c.dni = m.[Cliente-Dni] 
	) JOIN SQL_86.medios_pagos mp ON mp.nombre = m.FormaPagoDescripcion   
WHERE [Pago_nro] IS NOT NULL
ORDER BY [Pago_nro]







/****** Script para el comando SelectTopNRows de SSMS  ******/
SELECT DISTINCT Nro_Factura, Pago_nro, Rendicion_Nro
  FROM [GD2C2017].[gd_esquema].[Maestra]
  WHERE Nro_Factura IN (
SELECT Nro_Factura
FROM [GD2C2017].[gd_esquema].[Maestra]
GROUP BY Nro_Factura
HAVING (COUNT(Nro_Factura)/(COUNT(Nro_Factura)/3)!=3)
)
ORDER BY Nro_Factura




  