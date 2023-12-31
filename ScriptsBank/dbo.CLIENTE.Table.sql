USE [BankSoft]
GO
/****** Object:  Table [dbo].[CLIENTE]    Script Date: 10/11/2023 12:32:38 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CLIENTE](
	[Id_Cliente] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](30) NULL,
	[Apellido] [varchar](30) NULL,
	[Documento] [bigint] NULL,
	[Tipo_Cuenta] [varchar](10) NULL,
	[Origen_Apertura_Cuenta] [varchar](50) NULL,
	[Num_Cuenta] [bigint] NULL,
	[Tipo_Cliente] [varchar](15) NULL,
	[Tipo_Documento] [varchar](2) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Cliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
