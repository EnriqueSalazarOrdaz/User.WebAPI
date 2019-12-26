CREATE TABLE [dbo].[AddressRelationShip]
(
	[ID] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
	[AddressID] UNIQUEIDENTIFIER NOT NULL ,
	[ExternalTypeID] UNIQUEIDENTIFIER NOT NULL, 
	[AddressRelationType] SMALLINT NOT NULL,

	[Active] BIT NOT NULL, 
    [CreationDate] DATETIME NOT NULL, 
    [DeleteDate] DATETIME NULL, 
    [CompanyID] UNIQUEIDENTIFIER NOT NULL, 
    [InstanceID] UNIQUEIDENTIFIER NOT NULL,
    CONSTRAINT [FK_AddressRelationShip_AddressID] FOREIGN KEY ([AddressID]) REFERENCES [Address]([ID]), 
	--CONSTRAINT [FK_AddressRelationShip_UserID] FOREIGN KEY ([ExternalTypeID]) REFERENCES [User]([UserID])
)
