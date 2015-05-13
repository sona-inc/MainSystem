Create Table tbWorkerAttendance(
	ID int identity(1,1) primary key,	
	WorkerID int,
	[Date] date,
	Present bit,
	constraint FKWorkerID foreign key(WorkerID) references tbWorker(WorkerID) On delete cascade on update cascade
	)