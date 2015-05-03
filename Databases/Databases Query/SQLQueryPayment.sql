Create Table tbPayment(ID int identity(1,1) primary key,CusID int,ProjectID int,StaffID smallint,PaymentDate date,
Constraint FKPayCusID foreign key(CusID) references tbCustomer(CusID) On delete cascade on update cascade,
Constraint FKPayStaffID foreign key(StaffID) references tbStaff(StaffID) On delete cascade on update cascade,
Constraint FKPayProjectID foreign key(ProjectID) references tbProject(ProjectID)
)