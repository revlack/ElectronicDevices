USE [ElectronicDevices]
GO

DELETE [Device]

GO

INSERT INTO [Device]
           ([CategoryId]
           ,[Name]
           ,[ImageUrl]
           ,[Price]
           ,[Description])
     VALUES
           (
		   (select CategoryId from Category where Description = 'Laptop')
		   ,'Lenovo IdeaPad'           
		    ,'https://images-na.ssl-images-amazon.com/images/I/71EbLbg9-yL._SL1500_.jpg'
           ,2000.20
           ,'Bring home the perfect companion for you to watch movies, play games, browse the web and, most importantly, be more productive at work')


GO

INSERT INTO [Device]
           ([CategoryId]
           ,[Name]
           ,[ImageUrl]
           ,[Price]
           ,[Description])
     VALUES
           (
		   (select CategoryId from Category where Description = 'Laptop')
		   ,'DOS Laptop'           
		    ,'https://images-na.ssl-images-amazon.com/images/I/51tTmpz3CNL._SL1125_.jpg'
           ,1800.99
           ,'Pre-installed Software: None | In the Box: Laptop with included battery, charger and manual. Perfect for hackers')

GO


INSERT INTO [Device]
           ([CategoryId]
           ,[Name]
           ,[ImageUrl]
           ,[Price]
           ,[Description])
     VALUES
           (
		   (select CategoryId from Category where Description = 'Smartphone')
		   ,'Lenovo K8 Note'           
		    ,'https://images-na.ssl-images-amazon.com/images/I/71k02lWMTUL._SL1500_.jpg'
           ,999.00
           ,'Packed with a 10-core processor plus up to 4GB of RAM & 64GB of internal storage to give you plenty of space for your photos, music and favourite apps. With 200% higher performance')
		   

GO

INSERT INTO [Device]
           ([CategoryId]
           ,[Name]
           ,[ImageUrl]
           ,[Price]
           ,[Description])
     VALUES
           (
		   (select CategoryId from Category where Description = 'Smartphone')
		   ,'Google Pixel 3 XL'           
		    ,'https://images-na.ssl-images-amazon.com/images/I/31Lm9Np8K8L.jpg'
           ,299.00
           ,'With a powerful battery, massive internal storage, impressive cameras and innovative features, there’s more to pixel 3 xl than meets the eye. Its 16 cm (6. 3) OLED bezel-less display with notch and its 82 percent body-to-display ratio, offers you an impressive viewing experience. Whether you’re bar hopping with friends, or you’re going on a team lunch with your colleagues - capture each and every moment in beautiful photos.')
		   

