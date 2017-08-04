CREATE TABLE [dbo].[Territory] (
    [Id]           INT           IDENTITY (1, 1) NOT NULL,
    [Number]       VARCHAR (3)   NOT NULL,
    [Locality]     VARCHAR (25)  NOT NULL,
    [CreationDate] DATETIME      DEFAULT (getdate()) NOT NULL,
    [PathImage]    VARCHAR (MAX) NULL,
    [IsDeleted]    BIT           DEFAULT ((0)) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    UNIQUE NONCLUSTERED ([Number] ASC),
    UNIQUE NONCLUSTERED ([Id] ASC)
);

