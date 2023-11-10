USE [BankSoft]
GO
/****** Object:  StoredProcedure [dbo].[spListado_Retiros]    Script Date: 10/11/2023 12:32:38 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[spListado_Retiros]
AS
BEGIN
	SELECT RETIRO.Id_Retiro 'ID_RETIRO', CLIENTE.Id_Cliente 'ID_CLIENTE', CLIENTE.Documento 'DOCUMENTO', 
					CLIENTE.Num_Cuenta 'NUM_CUENTA', RETIRO.Valor_Retiro 'RETIRO'

	FROM CLIENTE INNER JOIN RETIRO ON RETIRO.Id_Cliente = CLIENTE.Id_Cliente 
END
GO
