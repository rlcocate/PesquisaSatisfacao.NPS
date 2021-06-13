USE DCV_NPS
GO

BEGIN TRAN
IF EXISTS (SELECT TOP 1 * FROM dbo.StatusAtendimento)
BEGIN
	DELETE FROM dbo.StatusAtendimento
END

INSERT INTO StatusAtendimento (CodStatusAtendimento, Descricao) 
VALUES
	(1, 'Não foi atendida'),	
	(2, 'Foi parcialmente atendida'),
	(3, 'Sim, foi totalmente atendida')


--COMMIT
--ROLLBACK
