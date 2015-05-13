Create Table tbSalary(
	ID int identity(1,1) primary key,
	StaffID smallint,
	BonusID tinyint,
	Amount money,
	TransactionDate date,
	Constraint FKStaffID1 foreign key(StaffID) 
	references tbStaff(StaffID) On delete cascade on update cascade,
	Constraint FKBonusID foreign key(BonusID) 
	references tbBonusStatus(ID) On delete cascade on update cascade
	)