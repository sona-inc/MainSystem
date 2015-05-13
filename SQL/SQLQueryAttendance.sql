Create Table tbAttendance(
	ID int identity(1,1) primary key,
	Attendance varchar(10),
	StaffID smallint,
	[Date] date,
	Reason varchar(150),
	constraint FKStaffID foreign key(StaffID) 
	references tbStaff(StaffID) On delete cascade on update cascade
	)