CREATE TABLE [dbo].[jobs]
(
  [Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1),
  [Name] NVARCHAR(MAX) NOT NULL,
  [Description] NVARCHAR(MAX) NOT NULL
)
