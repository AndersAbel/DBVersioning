CREATE TABLE [dbo].[Brands]
(
	[Id] INT NOT NULL PRIMARY KEY,
	Name nvarchar(20) not null
	constraint UK_Brands_Name UNIQUE
)
