
USE [ElectronicDevices]
GO

DELETE FROM  [Category]
GO

INSERT INTO [dbo].[Category]
           ([Description])
     VALUES
           ('Smartphone')
GO

INSERT INTO [dbo].[Category]
           ([Description])
     VALUES
           ('Laptop')
GO


