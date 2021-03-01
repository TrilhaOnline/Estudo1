USE [DBTRILHA]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_TRL_GET_CARS]	
AS
BEGIN
  SELECT idCar
      ,nameCar
      ,versionCar
      ,yearCar
      ,hourValueCar
  FROM [dbo].[TB_TRL_CARS]
END

GO


