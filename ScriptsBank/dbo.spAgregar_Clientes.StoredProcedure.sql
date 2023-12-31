USE [BankSoft]
GO
/****** Object:  StoredProcedure [dbo].[spAgregar_Clientes]    Script Date: 10/11/2023 12:32:38 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[spAgregar_Clientes]
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
	INSERT INTO CLIENTE VALUES(@Nombre,@Apellido,@Documento,@Tipo_Cuenta,@Origen_Apertura_cuenta,
								@Num_Cuenta,@Tipo_Cliente,@Tipo_Documento)
END

GO
