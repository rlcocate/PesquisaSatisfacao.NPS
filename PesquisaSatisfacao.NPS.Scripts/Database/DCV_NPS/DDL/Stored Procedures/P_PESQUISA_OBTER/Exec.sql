USE [DCV_NPS]
GO

/*----------------------------------------

          SERVIDOR sdaysp03d001

----------------------------------------*/

SET STATISTICS IO ON
SET STATISTICS XML ON

EXEC nps.P_PESQUISA_OBTER '12345678909'

SET STATISTICS XML OFF
SET STATISTICS IO OFF