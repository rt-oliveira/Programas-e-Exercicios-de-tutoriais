USE [Loja]
GO
/****** Object:  Table [dbo].[tb_clientes] ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_clientes](
	[codigo_cliente] [int] IDENTITY(1,1) NOT NULL,
	[nome_cliente] [nvarchar](50) NOT NULL,
	[endereco] [nvarchar](50) NOT NULL,
	[bairro] [nvarchar](30) NOT NULL,
	[cidade] [nvarchar](30) NOT NULL,
	[estado] [varchar](2) NOT NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[tb_clientes] ON 
GO
INSERT [dbo].[tb_clientes] ([codigo_cliente], [nome_cliente], [endereco], [bairro], [cidade], [estado]) VALUES (1, N'Joao', N'Rua das Flores', N'Jd. Colorado', N'Mogi das Cruzes', N'SP')
GO
INSERT [dbo].[tb_clientes] ([codigo_cliente], [nome_cliente], [endereco], [bairro], [cidade], [estado]) VALUES (2, N'Maria', N'Rua ABC', N'Jd. Pink', N'Parati', N'RJ')
GO
INSERT [dbo].[tb_clientes] ([codigo_cliente], [nome_cliente], [endereco], [bairro], [cidade], [estado]) VALUES (3, N'Eduardo', N'Rua DEF', N'Vila Flor', N'Cabo Frio', N'RJ')
GO
INSERT [dbo].[tb_clientes] ([codigo_cliente], [nome_cliente], [endereco], [bairro], [cidade], [estado]) VALUES (4, N'Isabella', N'Rua XYZ', N'Vila Velha', N'Mogi das Cruzes', N'SP')
GO
INSERT [dbo].[tb_clientes] ([codigo_cliente], [nome_cliente], [endereco], [bairro], [cidade], [estado]) VALUES (5, N'Maria Rosa', N'Rua Joao XXIII', N'Vila Nova', N'Poá', N'SP')
GO
SET IDENTITY_INSERT [dbo].[tb_clientes] OFF
GO
