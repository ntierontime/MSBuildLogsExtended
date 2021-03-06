/****** Object:  StoredProcedure [dbo].[msbep_SqlLogger]    Script Date: 10/30/2016 8:16:54 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[msbep_SqlLogger]
    @BuildId    int = NULL,
    @BuildName    nvarchar(100) = NULL,
    @Event        nvarchar(100),
    @Message    nvarchar(1000) = NULL,
    @ClearLog    bit = 0 
AS 
BEGIN 

-- BuildId not-in-use, there will be a new table Build
DECLARE @EventTime DATETIME;
SET @EventTime = GETDATE();
--IF ( @ClearLog = 1)
--BEGIN 
--    DELETE FROM [dbo].BuildLogs
--    WHERE BuildId = @BuildId
--END 

DECLARE @SolutionName VARCHAR(100);
DECLARE @SolutionBuildName VARCHAR(100);
SET @SolutionName = (SELECT TOP 1 Item FROM dbo.SplitStrings_Moden(@BuildName, ',') WHERE RowNumber=1)
SET @SolutionBuildName = (SELECT TOP 1 Item FROM dbo.SplitStrings_Moden(@BuildName, ',') WHERE RowNumber=2)

IF (NOT EXISTS(SELECT [Name] FROM [dbo].[Solution] WHERE [Name]=@SolutionName))
BEGIN
INSERT INTO [dbo].[Solution]
           ([Name]
           ,[Description])
     VALUES
           (@SolutionName
           ,@SolutionName)
END


IF (NOT EXISTS(SELECT a.[Name] FROM [dbo].[Build] a INNER JOIN [dbo].[Solution] b ON a.[SolutionId]=b.[Id] WHERE a.[Name]=@SolutionBuildName AND b.[Name]=@SolutionName))
BEGIN

DECLARE @SolutionId INT;

SET @SolutionId = (SELECT TOP 1 Id FROM [dbo].[Solution] WHERE [Name]=@SolutionName)

INSERT INTO [dbo].[Build]
           (
		   [SolutionId]
		   ,[Name]
           ,[Description]
		   ,[BuildStartTime])
     VALUES
           (
		   @SolutionId
		   ,@SolutionBuildName
           ,@SolutionBuildName
		   ,@EventTime)
END

DECLARE @SolutionBuildId INT;
SET @SolutionBuildId = (SELECT TOP 1 a.[Id] FROM [dbo].[Build] a INNER JOIN [dbo].[Solution] b ON a.[SolutionId]=b.[Id] WHERE a.[Name]=@SolutionBuildName AND b.[Name]=@SolutionName)

IF (NOT EXISTS(SELECT [EventCode] FROM [dbo].[BuildEventCode] WHERE [EventCode]=@Event))
BEGIN
	INSERT INTO [dbo].[BuildEventCode]
			   ([EventCode]
			   ,[Description])
		 VALUES
			   (@Event
			   ,@Event)
END

DECLARE @BuildEventCodeId INT;
SET @BuildEventCodeId=(SELECT TOP 1 [Id] FROM [dbo].[BuildEventCode] WHERE [EventCode]=@Event)

INSERT INTO [dbo].[BuildLog]
           ([BuildId]
           ,[BuildEventCodeId]
           ,[Message]
           ,[EventTime])
     VALUES
           (@SolutionBuildId
           ,@BuildEventCodeId
           ,@Message
		   ,@EventTime
		   )
END
GO


