USE DCV_NPS
GO

BEGIN TRAN
IF EXISTS (SELECT TOP 1 * FROM dbo.Motivo)
BEGIN
	DELETE FROM dbo.Motivo
END

INSERT INTO Motivo (CodMotivo, Descricao, Ordenacao) 
VALUES
	(1, 'Falta de resolutividade', 1),
	(2, 'Demora no retorno', 2),
	(3, 'Mau atendimento nos canais', 3),
	(4, 'Procedimentos confusos', 4),
	(5, 'Dificuldade em contatar o banco', 5),
	(6, 'Dificuldade de negociação', 6),
	(7, 'Não concordo com valores/juros', 7),
	(8, 'Outros', 8),

	(9, 'Resolutividade', 1),
	(10, 'agilidade no retorno', 2 ),
	(11, 'educação e empatia no atendimento', 3),
	(12, 'clareza de informações', 4),
	(13, 'facilidade em contatar o banco', 5),
	(14, 'facilidade de negociação', 6),
	(15, 'ótimos valores e/ou preços', 7)

--COMMIT
--ROLLBACK
