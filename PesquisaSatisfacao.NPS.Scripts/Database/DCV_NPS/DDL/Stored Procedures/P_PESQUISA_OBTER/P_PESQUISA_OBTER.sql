USE [DCV_NPS]
GO

/*----------------------------------------

          SERVIDOR sdaysp03d001

----------------------------------------*/


IF OBJECT_ID('nps.P_PESQUISA_OBTER', 'P') IS NULL
  EXEC ('CREATE PROCEDURE nps.P_PESQUISA_OBTER AS SELECT 1')
ELSE
  EXEC SP_BACKUPOBJ 'P_PESQUISA_OBTER', nps
GO

ALTER PROCEDURE nps.P_PESQUISA_OBTER
(
  @Cpf  VARCHAR(14)
) 
AS
/*  
  Procedure: nps.P_PESQUISA_OBTER
  Objetivo : Retornar pesquisa NPS por CPF para o cliente responder
             Utilizada pela API do ODA
  Analista : RODRIGO LUIZ COCATE
  Data     : 12/05/2021
  *** Histórico de Alterações ****************************************      
  Item  Data        Analista          Descrição

  ********************************************************************      
*/  
BEGIN

  SET NOCOUNT ON
  SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED

  SELECT
     CodPesquisa
    ,DataHoraGeracao
    ,DataHoraEnvio
    ,StatusRetornoEnvio
    ,CpfCNpj
    ,Nome
    ,Respondida
    ,DataHoraResposta
    ,Nota
    ,CodMotivo
    ,DescOutroMotivo
    ,CodStatusAtendimento
  FROM
    Pesquisa
  WHERE 
    CpfCnpj = @Cpf

END
GO