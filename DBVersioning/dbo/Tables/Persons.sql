CREATE TABLE [dbo].[Persons] (
    [Id]          INT           NOT NULL,
    [FirstName]   NVARCHAR (20) NOT NULL,
    [LastName]    NVARCHAR (20) NOT NULL,
    [Address]     NVARCHAR (50) NOT NULL,
    [PhoneNumber] VARCHAR (20)  NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

