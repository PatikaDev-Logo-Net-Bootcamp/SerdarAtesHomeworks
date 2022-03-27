CREATE PROCEDURE dbo.sp_Insert
  @name                     NVARCHAR(50)  = NULL   , 
  @lastname                 NVARCHAR(50)  = NULL   ,
  @email                 NVARCHAR(50)  = NULL   ,
  @companyName              NVARCHAR(50)  = NULL   ,
  @companyType              NVARCHAR(50)  = NULL   
AS 
BEGIN 
	SET IDENTITY_INSERT testdb.dbo.[User]  ON  
	
	  INSERT INTO testdb.dbo.Company 
          (                    
       		companyName,
       		companyType
          ) 
     VALUES 
          ( 
			@companyName ,
			@companyType
          ) 
     INSERT INTO testdb.dbo.[User] 
          (    
            id ,
            name                     ,
            lastname  ,
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
