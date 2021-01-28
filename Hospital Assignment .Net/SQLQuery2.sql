GO
ALTER LOGIN [sa] WITH DEFAULT_DATABASE=[master]
GO
USE [master]
GO
ALTER LOGIN [sa] WITH PASSWORD=N'newpassword' 
GO

InstallPackage EntityFramework