CREATE TABLE [dbo].[film]
(
	[Id] NUMERIC NOT NULL , 
    [name] NCHAR(10) NOT NULL, 
    [desc] NCHAR(10) NOT NULL, 
    [start_date] DATE NOT NULL, 
    [end_date] DATE NOT NULL, 
    [price] INT NOT NULL, 
    [theatre_id] NCHAR(10) NOT NULL FOREIGN KEY ([Id]) REFERENCES [dbo].[Theatre] ([Id]) ON DELETE CASCADE , 
    CONSTRAINT [PK_film] PRIMARY KEY ([Id]) 
)