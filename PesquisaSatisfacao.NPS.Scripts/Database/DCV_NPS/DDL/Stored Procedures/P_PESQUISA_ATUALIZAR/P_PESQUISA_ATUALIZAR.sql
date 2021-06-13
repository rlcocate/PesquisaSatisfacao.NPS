USE [DCV_NPS]
GO

/*----------------------------------------

        SERVIDOR sdaysp03d001

----------------------------------------*/

IF OBJECT_ID('nps.P_PESQUISA_ATUALIZAR', 'P') IS NULL
  EXEC ('CREATE PROCEDURE nps.P_PESQUISA_ATUALIZAR AS SELECT 1')
ELSE
  EXEC SP_BACKUPOBJ 'P_PESQUISA_ATUALIZAR', nps
GO

ALTER PROCEDURE nps.P_PESQUISA_ATUALIZAR
(
  @CodPesquisa          INT
, @Respondida           BIT
, @Url                  VARCHAR(256)    = NULL
, @Nota                 TINYINT         = NULL
, @CodMotivo            INT             = NULL
, @DescOutroMotivo      VARCHAR(5000)   = NULL
, @CodStatusAtendimento TINYINT         = NULL
, @Disparada            BIT             = 0
, @StatusRetornoEnvio   VARCHAR(100)    = NULL
) AS
/*  
  Procedure: nps.P_PESQUISA_ATUALIZAR
  Objetivo : Atualização das Respostas da Pesquisa NPS pelo cliente
             Utilizada pela API do ODA
  Analista : RODRIGO LUIZ COCATE
  Data     : 11/05/2021
  *** Histórico de Alterações ****************************************      
  Item  Data        Analista          Descrição

  ********************************************************************      
*/  
BEGIN

  SET NOCOUNT ON

  UPDATE  Pesquisa
     SET  DataHoraEnvio         = CASE WHEN @Disparada  = 1 THEN GETDATE() ELSE DataHoraEnvio END
        , [Url]                 = ISNULL(@Url, [Url])
        , Respondida            = @Respondida
        , Nota                  = ISNULL(@Nota, Nota)
        , CodMotivo             = ISNULL(@CodMotivo, CodMotivo)
        , DescOutroMotivo       = ISNULL(@DescOutroMotivo, DescOutroMotivo)
        , CodStatusAtendimento  = ISNULL(@CodStatusAtendimento, CodStatusAtendimento)
        , DataHoraResposta      = CASE WHEN @Respondida = 1 THEN GETDATE() ELSE NULL END
        , StatusRetornoEnvio    = ISNULL(@StatusRetornoEnvio, StatusRetornoEnvio)
   WHERE  CodPesquisa           = @CodPesquisa

END
GO