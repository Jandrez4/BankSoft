USE [BankSoft]
GO
/****** Object:  StoredProcedure [dbo].[spCrearRetiro]    Script Date: 10/11/2023 12:32:38 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[spCrearRetiro]
	@Id_Cliente int,
	@Documento BIGINT,
	@Num_Cuenta BIGINT,
	@Valor_Retiro MONEY
AS

BEGIN
	 INSERT INTO RETIRO VALUES (@Id_Cliente, @Documento, @Num_Cuenta, @Valor_Retiro)
END
GO
