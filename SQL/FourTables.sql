Use[dbcms]

GO
Create table tbSupplier(
	SupID smallint identity(1,1) primary key not null,
	Name varchar(30),
	Phone varchar(20),
	[Address] varchar(150)
)

GO
Create Table tbPosition(
	PositionID tinyint identity(1,1) primary key,
	Position varchar(30),
	[Description] varchar(150)
	)
GO
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
	GO
Create table tbImport(
	ImportNo smallint identity(1,1) primary key not null, 
	ImportDate date, 
	StaffID smallint, 
	SupID smallint, 
	TotalAmount money
	constraint FKStaID foreign key(StaffID) references tbStaff(StaffID),
	constraint FKSubID foreign key(SupID) references tbSupplier(SupID)
)
GO
Create table tbEquipment (
	EquipID smallint identity(1,1) primary key not null,
	EquipName varchar(30), 
	EquipType varchar(30), 
	Qty smallint, 
	UnitPrice money, 
	Amount money,
	[Expiredate] date
)
GO
Create table tbImportDetail(
	ImportNo smallint, 
	EquipID smallint, 
	ImportQty int, 
	UnitPrice money,
	Amount money
	Constraint PKImNoEID primary key(ImportNo,EquipID)
)
GO
Create Table tbWorkerGroup(ID smallint identity(1,1) primary key,
GroupName varchar(50),
StaffID smallint,
Description varchar(150),
Amount money,
Create_Date date,
constraint PKStaffID Foreign Key(StaffID) references tbStaff(StaffID) On Delete Cascade On Update Cascade)
GO
Create Table tbWorker(
	WorkerID int identity(1,1) primary key,
	WorkerName varchar(30),
	Gender char(1),
	Age tinyint,
	Phone varchar(20),
	[Address] varchar(150),
	WorkerGroupID smallint,
	constraint FKWorkerGroup foreign key(WorkerGroupID) references tbWorkerGroup(ID) on delete cascade on update cascade
	)
GO
Create Table tbUserRight(
	id smallint primary key,
	Name varchar(20) not null,
	Descr varchar(100) not null
)
GO

Create Table tbAdminSchema(
	id smallint identity(1,1) Primary key,
	staff_id smallint not null,
	ur_id smallint not null,
	username varchar(30) not null unique,
	email varchar(100) not null unique,
	pass_word varchar(Max) not null ,
	reg_code varchar(30) not null unique,
    date_reg Date not null,
	Constraint Fkstaff_id foreign key(staff_id) references tbStaff(StaffID) On Delete Cascade on Update Cascade,
	Constraint FkUserRight_id foreign key(ur_id) references tbUserRight(id) On Delete Cascade on Update Cascade

)
