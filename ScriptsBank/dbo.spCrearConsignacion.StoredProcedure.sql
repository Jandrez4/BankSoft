USE [BankSoft]
GO
/****** Object:  StoredProcedure [dbo].[spCrearConsignacion]    Script Date: 10/11/2023 12:32:38 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[spCrearConsignacion]
	@Id_Cliente INT,
	@Documento_Envia BIGINT,
	@Documento_Cliente BIGINT,
	@Num_Cuenta BIGINT,
	@Valor_Consignacion MONEY
AS
BEGIN
	INSERT INTO CONSIGNACION VALUES (@Id_Cliente, @Documento_Envia,@Documento_Cliente, @Num_Cuenta, @Valor_Consignacion)
END
GO
