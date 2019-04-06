CREATE DATABASE ElectronicDevices
GO
USE ElectronicDevices;
GO
CREATE TABLE Category  
(  
   CategoryId int IDENTITY (1,1) NOT NULL,  
   Description NVARCHAR(500) NOT NULL,
   CONSTRAINT PK_Category_CategoryId PRIMARY KEY CLUSTERED (CategoryId)  
);  
GO
CREATE TABLE Device 
(  
   DeviceId int IDENTITY (1,1) NOT NULL,  
   CategoryId int NOT NULL,  
   Name NVARCHAR(500) NOT NULL,  
   ImageUrl NVARCHAR(500) NOT NULL,  
   Price float NOT NULL,  
   Description NVARCHAR(500) NOT NULL,
   CONSTRAINT DeviceCategoy PRIMARY KEY CLUSTERED (DeviceId), 
   FOREIGN KEY (CategoryId) REFERENCES Category(CategoryId)
);  