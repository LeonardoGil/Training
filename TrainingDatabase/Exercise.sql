﻿CREATE TABLE [dbo].[Exercise]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [Description] VARCHAR(50) NOT NULL, 
    [Observation] VARCHAR(MAX) NULL
)
