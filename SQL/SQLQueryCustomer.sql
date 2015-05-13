use[dbcms]
Create Table tbCustomer(
	CusID int identity(1,1) primary key,
	FirstName varchar(20),
	LastName varchar(20),
	Photo varbinary(MAX),
	Email varchar(50),
	BussinessPhone varchar(20),
	Mobile varchar(20),
	[Address] varchar(150),
	City varchar(20),
	Province varchar(20),
	ZipCode varchar(10),
	Country varchar(30),
	Notes varchar(100)
	)