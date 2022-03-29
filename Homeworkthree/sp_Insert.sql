USE [LogoDb]
GO
/****** Object:  StoredProcedure [dbo].[sp_Insert]    Script Date: 27.03.2022 15:01:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE sp_Insert
  @name                     NVARCHAR(50)  = NULL   , 
  @lastname                 NVARCHAR(50)  = NULL   ,
  @email                 NVARCHAR(50)  = NULL   ,
  @companyName              NVARCHAR(50)  = NULL   ,
  @companyType              NVARCHAR(50)  = NULL   
AS 
BEGIN 
SET IDENTITY_INSERT [User]  ON  
	
INSERT INTO Company 
(                    
companyName,
companyType
) 
VALUES 
( 
@companyName ,
@companyType
) 
INSERT INTO [User]
(    
id ,
name ,
lastname ,
 email 
) 
VALUES
( 
scope_identity(),
@name,
@lastname,
@email
) 
END 
