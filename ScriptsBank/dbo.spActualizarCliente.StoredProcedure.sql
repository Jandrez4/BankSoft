USE [BankSoft]
GO
/****** Object:  StoredProcedure [dbo].[spActualizarCliente]    Script Date: 10/11/2023 12:32:38 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[spActualizarCliente]
	@Id_Cliente int,
	@Nombre varchar(30),
	@Apellido varchar(30),
	@Documento bigint,
	@Tipo_Cuenta varchar(10),
	@Origen_Apertura_cuenta varchar(50),
	@Num_Cuenta bigint,
	@Tipo_Cliente varchar(15),
	@Tipo_Documento varchar(2)
AS
BEGIN
	UPDATE CLIENTE SET Nombre = @Nombre, Apellido = @Apellido, Documento = @Documento, Tipo_Cuenta = @Tipo_Cuenta,
	Origen_Apertura_Cuenta = @Origen_Apertura_cuenta, Num_Cuenta = @Num_Cuenta,Tipo_Cliente = @Tipo_Cliente, Tipo_Documento = @Tipo_Documento
	WHERE Id_Cliente = @Id_Cliente
END
GO
