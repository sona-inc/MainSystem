Use[dbcms]

GO
Create table tbSupplier(
	SupID smallint identity(1,1) primary key not null,
	Name varchar(30),
	Phone varchar(20),
	[Address] varchar(150)
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