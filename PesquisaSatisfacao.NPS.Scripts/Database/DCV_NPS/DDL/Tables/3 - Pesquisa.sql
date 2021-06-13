USE NPS
GO

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

IF NOT EXISTS (SELECT id FROM sysobjects WHERE name = 'Pesquisa')
BEGIN
	CREATE TABLE dbo.Pesquisa
	(
		CodPesquisa						INT	IDENTITY(1,1)	NOT NULL,
		DataHoraGeracao				DATETIME					NOT NULL,
		[Url]									VARCHAR(256)			NULL,
		DataHoraEnvio					DATETIME					NULL,
		StatusRetornoEnvio		VARCHAR(100)			NULL,
		CpfCnpj								NVARCHAR(50)			COLLATE Latin1_General_CI_AI_KS NOT NULL,
		Nome									NVARCHAR(218)			NOT NULL,
		Respondida						BIT								NULL,
		DataHoraResposta			DATETIME					NULL,
		Nota									TINYINT						NULL,
		CodMotivo							SMALLINT					NULL,
		DescOutroMotivo				VARCHAR(5000)			NULL,
		CodStatusAtendimento	TINYINT						NULL,

		CONSTRAINT PK_Pesquisa
		PRIMARY KEY CLUSTERED (CodPesquisa ASC)
		WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 80) 
		ON [PRIMARY],

		CONSTRAINT FK_Pesquisa_Motivo
		FOREIGN KEY (CodMotivo)
		REFERENCES dbo.Motivo (CodMotivo),

		CONSTRAINT FK_Pesquisa_StatusAtendimento
		FOREIGN KEY (CodStatusAtendimento)
		REFERENCES dbo.StatusAtendimento (CodStatusAtendimento),
	) ON [PRIMARY]
END
GO