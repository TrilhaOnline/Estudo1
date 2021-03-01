USE [DBTRILHA]
GO

/****** Object:  StoredProcedure [dbo].[SP_TRL_INSERT_CARS]    Script Date: 29/08/2020 11:06:08 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[SP_TRL_INSERT_CARS]
	@nameCar as varchar(50),
	@versionCar as varchar(50),
	@yearCar as varchar(4),
	@hourValueCar as decimal(5,2)
AS
BEGIN
  INSERT INTO [dbo].[TB_TRL_CARS](nameCar, versionCar, yearCar, hourValueCar)
  VALUES (@nameCar, @versionCar, @yearCar, @hourValueCar)
END



GO


