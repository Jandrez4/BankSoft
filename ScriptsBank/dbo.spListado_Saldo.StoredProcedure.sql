USE [BankSoft]
GO
/****** Object:  StoredProcedure [dbo].[spListado_Saldo]    Script Date: 10/11/2023 12:32:38 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[spListado_Saldo]
AS
BEGIN
	SELECT SALDO.Id_Saldo 'ID_SALDO', CLIENTE.Id_Cliente 'ID_CLIENTE', 
			CLIENTE.Documento 'DOCUMENTO',CLIENTE.Num_Cuenta 'NUM_CUENTA',SALDO.Saldo_Actual 'SALDO'

	FROM CLIENTE INNER JOIN SALDO ON SALDO.Id_Cliente = CLIENTE.Id_Cliente 
END
GO
