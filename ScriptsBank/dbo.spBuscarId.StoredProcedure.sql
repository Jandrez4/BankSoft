USE [BankSoft]
GO
/****** Object:  StoredProcedure [dbo].[spBuscarId]    Script Date: 10/11/2023 12:32:38 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[spBuscarId]
	@Id_Cliente INT
AS
BEGIN
	SELECT Id_Cliente 'ID', Nombre 'NOMBRE', Apellido 'APELLIDOS', Documento 'DOCUMENTO', Tipo_Cliente 'TIPO CLIENTE',
		   Origen_Apertura_Cuenta 'ORIGEN CUENTA',  Tipo_Cuenta 'TIPO CUENTA',
		   Num_Cuenta 'NUMERO CUENTA', Tipo_Documento 'TIPO DOCUMENTO'
	FROM CLIENTE
	WHERE Id_Cliente = @Id_Cliente
END
GO
