/****** Object:  Table [dbo].[Build]    ******/
CREATE TABLE [dbo].[Build] (
	[Id] BigInt IDENTITY(1, 1) NOT NULL
	, [SolutionId] Int  NOT NULL
	, [Name] NVarChar(100)  NOT NULL
	, [Description] NVarChar(1500)  NULL
	, [BuildStartTime] DateTime  NOT NULL
	, PRIMARY KEY NONCLUSTERED (
		Id ASC
		)
	, CONSTRAINT FK_Build_Solution FOREIGN KEY (SolutionId) 
	    REFERENCES [dbo].[Solution] (Id) 
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
);


