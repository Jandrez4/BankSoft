USE [BankSoft]
GO
/****** Object:  StoredProcedure [dbo].[spListado_Consignaciones]    Script Date: 10/11/2023 12:32:38 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[spListado_Consignaciones]
AS
BEGIN
	SELECT CONSIGNACION.Id_Consignacion 'ID_CONSIGNACION', CLIENTE.Id_Cliente 'ID_CLIENTE', 
			CONSIGNACION.Documen_Envia 'DOCUMENTO_ENVIA', CLIENTE.Documento 'DOCUEMNTO_RECIBE',
			CLIENTE.Num_Cuenta 'NUM_CUENTA',CONSIGNACION.Valor_Consignacion 'CONSIGNACION'

	FROM CLIENTE INNER JOIN CONSIGNACION ON CONSIGNACION.Id_Cliente = CLIENTE.Id_Cliente 
END
GO
