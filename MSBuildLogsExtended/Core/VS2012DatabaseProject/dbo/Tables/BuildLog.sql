/****** Object:  Table [dbo].[BuildLog]    ******/
CREATE TABLE [dbo].[BuildLog] (
	[Id] BigInt IDENTITY(1, 1) NOT NULL
	, [BuildId] BigInt  NOT NULL
	, [BuildEventCodeId] Int  NOT NULL
	, [Message] NVarChar(1500)  NULL
	, [EventTime] DateTime  NOT NULL
	, PRIMARY KEY NONCLUSTERED (
		Id ASC
		)
	, CONSTRAINT FK_BuildLog_Build FOREIGN KEY (BuildId) 
	    REFERENCES [dbo].[Build] (Id) 
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
	, CONSTRAINT FK_BuildLog_BuildEventCode FOREIGN KEY (BuildEventCodeId) 
	    REFERENCES [dbo].[BuildEventCode] (Id) 
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
);


