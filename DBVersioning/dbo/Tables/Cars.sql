CREATE TABLE [dbo].[Cars] (
    [Id]      INT           NOT NULL,
    [RegNo]   CHAR (6)      NOT NULL,
    [Colour]  NVARCHAR (10) NOT NULL,
    [NoSeats] TINYINT       NOT NULL,
    [Owner]   INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Cars_OwnerPerson] FOREIGN KEY ([Owner]) REFERENCES [dbo].[Persons] ([Id]),
	BrandId	  INT			NOT NULL
	CONSTRAINT FK_Cars_Brands FOREIGN KEY REFERENCES Brands (Id)
);


GO
CREATE UNIQUE NONCLUSTERED INDEX [UK_Cars_RegNo]
    ON [dbo].[Cars]([RegNo] ASC)
    INCLUDE([Owner]);


GO
CREATE NONCLUSTERED INDEX [IX_Cars_Owner]
    ON [dbo].[Cars]([Owner] ASC, [RegNo] ASC);

