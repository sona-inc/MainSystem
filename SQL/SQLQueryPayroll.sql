Create Table tbPayroll(
	ID int identity primary key,
	WorkerID int,
	[Days] tinyint,
	PayrolledDate Date,
	PaymentType varchar(30),
	Amount money,
	TotalAmount money,
	Constraint FKPayrollWorkerID Foreign Key(WorkerID) 
	references tbWorker(WorkerID) On Delete Cascade on Update Cascade
)