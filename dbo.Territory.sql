CREATE TABLE [dbo].[Territory] (
    [Id]       VARCHAR (2)  NOT NULL,
    [Localité] VARCHAR (25) NOT NULL,
    [LastBorrowing] DATE NULL DEFAULT getdate(), 
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

