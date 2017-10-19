SELECT DISTINCT [Cliente-Dni]
      ,[Cliente-Apellido]
      ,[Cliente-Nombre]
      ,[Cliente-Fecha_Nac]
      ,[Cliente_Mail]
      ,[Cliente_Direccion]
      ,[Cliente_Codigo_Postal]
FROM gd_esquema.Maestra
ORDER BY [Cliente-Dni] asc

SELECT * FROM SQL_86.clientes

SELECT DISTINCT Empresa_Rubro, Rubro_Descripcion
FROM gd_esquema.Maestra

SELECT * FROM SQL_86.rubros

SELECT DISTINCT Empresa_Rubro, Rubro_Descripcion
FROM gd_esquema.Maestra

SELECT * FROM SQL_86.empresas

SELECT DISTINCT Empresa_Nombre
	,Empresa_Cuit
	,Empresa_Direccion
	,Empresa_Rubro
	,'A'
	,0.00
FROM gd_esquema.Maestra

SELECT DISTINCT *
FROM gd_esquema.Maestra
WHERE ItemRendicion_nro IS NOT NULL
ORDER BY Rendicion_Nro


-- Las rendiciones son mensuales, Nro_rendicion y ItemRendicion_Nro varian de acuerdo con la factura por lo que no es posible sacar el id de rendicion de esta informacion
-- Habria que sumar todas las facturas que tengan un mismo mes y crear una rendicion
SELECT r.*
FROM gd_esquema.Maestra r
WHERE Rendicion_Nro IS NOT NULL AND Pago_nro = ItemPago_nro
ORDER BY Rendicion_Nro

-- Selecciona los datos respecto de las rendiciones
SELECT DISTINCT r.Factura_Total,
		r.ItemRendicion_Importe,
		(SELECT SUM(total) FROM gd_esquema.Maestra WHERE Rendicion_Fecha=r.Rendicion_Fecha) AS Rendicion_Total,
		(SELECT SUM(ItemRendicion_Importe) FROM gd_esquema.Maestra WHERE Rendicion_Fecha=r.Rendicion_Fecha) AS Ganancia_PagoAgil,
		r.Rendicion_Fecha,
		r.Pago_Fecha,
		r.Factura_Fecha,
		r.Factura_Fecha_Vencimiento,
		r.Empresa_Nombre,
		CAST ((ItemRendicion_Importe*100)/Factura_Total AS decimal (4,2)) AS Porcentaje_Ganancia,
		CAST ((Factura_Total/10) AS DECIMAL (8,2)) AS Factura_Ganancia
FROM gd_esquema.Maestra r
WHERE Rendicion_Nro IS NOT NULL
ORDER BY Rendicion_Fecha,Pago_Fecha

