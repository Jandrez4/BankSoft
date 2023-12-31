USE [BankSoft]
GO
/****** Object:  Table [dbo].[CONSIGNACION]    Script Date: 10/11/2023 12:32:38 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CONSIGNACION](
	[Id_Consignacion] [int] IDENTITY(1,1) NOT NULL,
	[Id_Cliente] [int] NULL,
	[Documen_Envia] [bigint] NULL,
	[Documen_Recibe] [bigint] NULL,
	[Num_Cuenta] [bigint] NULL,
	[Valor_Consignacion] [money] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Consignacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[CONSIGNACION]  WITH CHECK ADD  CONSTRAINT [FK_Consignacion_CLIENTE] FOREIGN KEY([Id_Cliente])
REFERENCES [dbo].[CLIENTE] ([Id_Cliente])
GO
ALTER TABLE [dbo].[CONSIGNACION] CHECK CONSTRAINT [FK_Consignacion_CLIENTE]
GO
