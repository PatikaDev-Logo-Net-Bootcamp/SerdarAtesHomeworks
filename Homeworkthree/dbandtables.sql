CREATE TABLE testdb.dbo.Company (
	id int IDENTITY(0,1) NOT NULL,
	companyName nvarchar(100) COLLATE Turkish_CI_AS NOT NULL,
	companyType nvarchar(100) COLLATE Turkish_CI_AS NOT NULL,
	CONSTRAINT Company_PK PRIMARY KEY (id)
);



CREATE TABLE testdb.dbo.[User] (
	id int IDENTITY(0,1) NOT NULL,
	name nvarchar(100) COLLATE Turkish_CI_AS NOT NULL,
	lastname nvarchar(100) COLLATE Turkish_CI_AS NOT NULL,
	email nvarchar(100) COLLATE Turkish_CI_AS NOT NULL,
	CONSTRAINT User_PK PRIMARY KEY (id),
	CONSTRAINT User_FK FOREIGN KEY (id) REFERENCES testdb.dbo.Company(id)
);
