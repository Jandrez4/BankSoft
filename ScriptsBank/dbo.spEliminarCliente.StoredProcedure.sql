USE [BankSoft]
GO
/****** Object:  StoredProcedure [dbo].[spEliminarCliente]    Script Date: 10/11/2023 12:32:38 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[spEliminarCliente]
	@Id_Cliente int
AS
BEGIN
	DELETE Cliente where Id_Cliente = @Id_Cliente
END 
GO
