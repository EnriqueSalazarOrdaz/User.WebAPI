﻿CREATE TABLE [dbo].[Address]
(
	[ID] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [ZipCode] NVARCHAR(50) NOT NULL, 
    [Country] NVARCHAR(50) NOT NULL, 
    [State] NVARCHAR(50) NOT NULL, 
    [AddressType] SMALLINT NOT NULL DEFAULT 1,

    [Active] BIT NOT NULL, 
    [CreationDate] DATETIME NOT NULL, 
    [DeleteDate] DATETIME NULL, 
    [CompanyID] UNIQUEIDENTIFIER NOT NULL, 
    [InstanceID] UNIQUEIDENTIFIER NOT NULL
)
