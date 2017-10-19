/****** Script para el comando SelectTopNRows de SSMS  ******/
SELECT TOP 10000 [Cliente-Dni]
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
  WHERE ItemRendicion_nro IS NOT NULL
  order BY Rendicion_Fecha


SELECT Total, ItemRendicion_Importe, Nro_Factura
FROM [GD2C2017].[gd_esquema].[Maestra]
WHERE ItemRendicion_nro IS NOT NULL


SELECT  SUM(Total), SUM(ItemRendicion_Importe)
FROM [GD2C2017].[gd_esquema].[Maestra]
WHERE ItemRendicion_nro IS NOT NULL AND Nro_Factura in (10364, 10310, 10423);



  