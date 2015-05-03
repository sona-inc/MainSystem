Create Table tbBonusDetail(BonusID tinyint,StaffID smallint,Constraint FKBDBonusID foreign key(BonusID) references tbBonusStatus(ID) On delete cascade on update cascade,
Constraint FKBDStaffID foreign key(StaffID) references tbStaff(StaffID) On delete cascade on update cascade, Constraint PKBIDSID Primary key(BonusID,StaffID)
)