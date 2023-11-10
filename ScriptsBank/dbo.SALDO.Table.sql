USE [BankSoft]
GO
/****** Object:  Table [dbo].[SALDO]    Script Date: 10/11/2023 12:32:38 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SALDO](
	[Id_Saldo] [int] IDENTITY(1,1) NOT NULL,
	[Id_Cliente] [int] NULL,
	[Documento] [bigint] NULL,
	[Num_Cuenta] [bigint] NULL,
	[Saldo_Actual] [money] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Saldo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[SALDO]  WITH CHECK ADD  CONSTRAINT [FK_Saldo_CLIENTE] FOREIGN KEY([Id_Cliente])
REFERENCES [dbo].[CLIENTE] ([Id_Cliente])
GO
ALTER TABLE [dbo].[SALDO] CHECK CONSTRAINT [FK_Saldo_CLIENTE]
GO
