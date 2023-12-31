USE [BankSoft]
GO
/****** Object:  StoredProcedure [dbo].[spListado_Reportes]    Script Date: 10/11/2023 12:32:38 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[spListado_Reportes]
AS
BEGIN
	SELECT REPORTES_MENSUALES.Id_Reporte 'ID_Reporte', CLIENTE.Id_Cliente 'ID_CLIENTE', CLIENTE.Documento 'DOCUMENTO', 
					CLIENTE.Num_Cuenta 'NUM_CUENTA', SALDO.Saldo_Actual 'SALDO'

	FROM CLIENTE INNER JOIN REPORTES_MENSUALES ON REPORTES_MENSUALES.Id_Cliente = CLIENTE.Id_Cliente INNER JOIN
	SALDO ON REPORTES_MENSUALES.Id_Cliente = SALDO.Id_Cliente
END
GO
