/****** Object:  Table [dbo].[BuildEventCode]    ******/
CREATE TABLE [dbo].[BuildEventCode] (
	[Id] Int IDENTITY(1, 1) NOT NULL
	, [EventCode] NVarChar(100)  NOT NULL
	, [Description] NVarChar(1500)  NULL
	, PRIMARY KEY NONCLUSTERED (
		Id ASC
		)
);


