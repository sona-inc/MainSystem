Create Table tbStaff(
	StaffID smallint identity(1,1) primary key,
	StaffName varchar(30),
	Gender varchar(6),
	BirthDate date,
	MaritalStatus varchar(10),
	Phone varchar(20),
	[Address] varchar(150),
	HiredDate date,
	Salary money,
	StopWork varchar(3),
	PositionID tinyint,
	Photo varbinary(MAX), 
	constraint FKPositionID foreign key(PositionID) references tbPosition(PositionID) On Delete Cascade on Update Cascade
	)