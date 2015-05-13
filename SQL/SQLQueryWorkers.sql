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