﻿USE NPS
GO

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

IF NOT EXISTS (SELECT id FROM sysobjects WHERE name = 'DadosCliente')
BEGIN
	CREATE TABLE dbo.DadosCliente
	(
		CodDadosCliente		INT	IDENTITY(1,1)	NOT NULL,
		CodPesquisa				INT								NOT NULL,
		Protocolo					NVARCHAR(60)			NOT NULL,
		Nivel							TINYINT						NOT NULL,
		Celular						NVARCHAR(50)			NULL,
		Email							NVARCHAR(200)			NULL,

		CONSTRAINT PK_DadosCliente
		PRIMARY KEY CLUSTERED (CodDadosCliente ASC)
		WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 80) 
		ON [PRIMARY],
		
		CONSTRAINT FK_DadosCliente_Pesquisa
		FOREIGN KEY (CodPesquisa)
		REFERENCES dbo.Pesquisa (CodPesquisa),

	) ON [PRIMARY]
END
GO