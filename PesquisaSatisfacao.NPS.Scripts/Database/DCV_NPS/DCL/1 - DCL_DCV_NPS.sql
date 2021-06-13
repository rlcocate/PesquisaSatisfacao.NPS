USE DCV_NPS
GO

/*----------------------------------------

        SERVIDOR sdaysp03d001

----------------------------------------*/
IF NOT EXISTS (SELECT 1 FROM sys.schemas WHERE name = 'nps')
BEGIN
  EXEC('CREATE SCHEMA [nps] AUTHORIZATION dbo')
END
GO
