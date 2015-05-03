Create Table tbProject(ProjectID int identity(1,1) Primary key,CusID int,ServiceID smallint,StartDate date,EndDate date,Amount money,StaffID smallint,
Constraint FKProCusID foreign key(CusID) references tbCustomer(CusID) On Delete Cascade on Update Cascade,
Constraint FKProServiceID foreign key(ServiceID) references tbService(ServiceID) On Delete Cascade on Update Cascade,
Constraint FKProStaffID foreign key(StaffID) references tbStaff(StaffID) On Delete Cascade on Update Cascade
)