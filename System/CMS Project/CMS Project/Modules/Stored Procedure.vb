Imports Cms.SqlCms
Module Stored_Procedure
    Public Cms As New Systemdb

    Public Sub RunCreateStoredProcedure()
        'Cms.Sqldumper()
        'Logs
        Cms.CreateStoreProcedure("insert into tbLogs(Ascm_id,per_date,actions) values(@perId,@per_date,@actions)", "@perId smallint,@per_date date ,@actions varchar(300)", "InsertLogs")
        'LoginForm and register
        'Cms.CreateStoreProcedure("select id from tbAdmin where reg_code=@reg_code", "reg_code varchar(30)")
        Cms.CreateStoreProcedure("update tbAdminSchema set reg_code=@reg_code where username=@username or email=@email", "@reg_code varchar(30) ,@username varchar(30),@email varchar(100)", "InsertRgc")
        'Cms.CreateStoreProcedure("BEGIN SET NOCOUNT ON; IF EXISTS(select id from tbAdminSchema where reg_code=@reg_code) BEGIN  Select -1 END ELSE   update tbAdminSchema set reg_code=@reg_code,pass_word=@pass_word where username=@username or email=@email END ",
        ' "@reg_code varchar(30) ,@pass_word varchar(Max),@username varchar(30),@email varchar(100)", "InsertRgcPass")
        Cms.CreateStoreProcedure("IF EXISTS(select reg_code from tbAdminSchema where reg_code=@reg_code) BEGIN  Select -1 END", "@reg_code varchar(30)", "CheckRegCode")
        Cms.CreateStoreProcedure(" update tbAdminSchema set reg_code=@reg_code,pass_word=@pass_word where username=@username or email=@email", "@reg_code varchar(30) ,@pass_word varchar(Max),@username varchar(30),@email varchar(100)", "InsertRgcPass")
        Cms.CreateStoreProcedure("select reg_code ,email from tbAdminSchema where username=@username or email=@email", "@username varchar(30),@email varchar(100)", "SelectRgc")
        Cms.CreateStoreProcedure("select id ,username, email,pass_word from tbAdminSchema where username=@username and pass_word=@pass_word  or email=@email and pass_word=@pass_word", "@username varchar(30), @email varchar(100), @pass_word varchar(max)", "SelectForLogin")
        Cms.CreateStoreProcedure("Select * from tbAdminSchema l, tbStaff s, tbUserRight u where l.staff_id=s.StaffID and l.ur_id=u.id and l.id=@id", "@id smallint", "SelectAllAdminShema")
        Cms.CreateStoreProcedure("Select id , username,email from tbAdminSchema", Nothing, "SelectAllAdminSchema")
        'Cms.CreateStoreProcedure("Insert into ")
        Cms.CreateStoreProcedure("Select s.Photo from tbStaff s ,tbAdminSchema l where s.StaffID =l.staff_id and l.username like @username or  s.StaffID =l.staff_id and l.email like @email ", "@username varchar(30),@email varchar(100)", "ShearchAdminSchema")
        Cms.CreateStoreProcedure("select id , Name  from tbUserRight order by Name", Nothing, "SelectIDNAMEUserRight")
        'Cms.CreateStoreProcedure("insert into tbAdminSchema(staff_id,ur_id,username,email,pass_word,reg_code,date_reg) values(@staff_id,@ur_id,@username,@email,@pass_word,@reg_code,@date_reg)", "@staff_id smallint,@ur_id smallint ,@username varchar(30),@email varchar(100),@pass_word varchar(max),@reg_code varchar(30),@date_reg date", "InsertInAdminSchema")
        'Supplier
        Cms.CreateStoreProcedure("Insert into tbSupplier(name,phone,address) values(@name,@phone,@address)", "@name varchar(30),@phone varchar(20),@address varchar(150)", "InsertSupplier")
        Cms.CreateStoreProcedure("Update tbSupplier set name=@name,phone=@phone,address=@address where SupID=@id", "@name varchar(30),@phone varchar(20),@address varchar(150),@id smallint", "UpdateSupplier")
        Cms.CreateStoreProcedure("Select SupID,Name,Phone,Address from tbSupplier where SupID=@id", "@id smallint", "SelectSupplierbyID")
        Cms.CreateStoreProcedure("Select SupID,Name from tbSupplier order by Name", Nothing, "SelectAllSupplier")
        Cms.CreateStoreProcedure("Select SupID,Name from tbSupplier where Name LIKE @name order by Name", "@name varchar(30)", "SearchSupplier")

        'Position
        Cms.CreateStoreProcedure("insert into tbPosition (Position,Description)values(@name,@de)", "@name varchar(20), @de varchar(30)", "InsertPosition")
        Cms.CreateStoreProcedure("Update tbPosition set Position=@name,Description=@de where PositionID=@id", "@name varchar(20), @de varchar(30), @id smallint", "UpdatePosition")
        Cms.CreateStoreProcedure("select PositionID, Position from tbPosition order by Position", Nothing, "SelectAllPosition")
        Cms.CreateStoreProcedure("select PositionID,Position,Description from tbPosition where PositionID=@id", "@id smallint", "SelectPositionbyID")
        Cms.CreateStoreProcedure("Select PositionID,Position from tbPosition where Position LIKE @name order by Position", "@name varchar(30)", "SearchPosition")

        'Staff
        Cms.CreateStoreProcedure("insert into tbStaff (StaffName,Gender,BirthDate,MaritalStatus,Phone,Address,HiredDate,Salary,StopWork,PositionID,Photo)values(@name,@gen,@Birt,@mar,@phone,@adr,@hire,@sal,@sto,@posi,@photo)", "@name varchar(30),@gen varchar(6),@birt date,@mar varchar(10),@phone varchar(20),@adr varchar(50),@hire date,@sal money,@sto varchar(3),@posi tinyint,@photo varbinary(MAX)", "InsertStaff")
        Cms.CreateStoreProcedure("update tbStaff set StaffName=@name,Gender=@gen, BirthDate=@birt,MaritalStatus=@mar,Phone=@phone,Address=@adr,HiredDate=@hire,Salary=@sal,StopWork=@sto,PositionID=@posi,Photo=@photo where StaffID=@id", "@name varchar(30),@gen varchar(6),@birt date,@mar varchar(10),@phone varchar(20),@adr varchar(50),@hire date,@sal money,@sto varchar(3),@posi tinyint,@photo varbinary(MAX),@id smallint", "UpdateStaff")
        Cms.CreateStoreProcedure("select StaffID, StaffName from tbStaff order by StaffName", Nothing, "SelectAllStaff")
        Cms.CreateStoreProcedure("select staffID, staffName from tbStaff WHERE staffName LIKE @name order by staffName", "@name varchar(30)", "SearchStaff")
        Cms.CreateStoreProcedure("select staffID,StaffName,Gender,BirthDate,MaritalStatus,Phone,Address,HiredDate,Salary,StopWork,PositionID,Photo from tbStaff WHERE staffID=@id", "@id smallint", "SelectStaffbyID")

        'Worker
        Cms.CreateStoreProcedure("insert into tbWorker (workername,gender,age,phone,address,workergroupid)values(@name,@gender,@age,@phone,@address,@workergroupid)", "@name varchar(30), @gender varchar(1),@age tinyint,@phone varchar(20),@address varchar(150),@workergroupid smallint", "InsertWorker")
        Cms.CreateStoreProcedure("Update tbWorker set workername=@name,gender=@gender,age=@age,phone=@phone,address=@address,workergroupid=@workergroupid where workerid=@id", "@name varchar(30), @gender varchar(1),@age tinyint,@phone varchar(20),@address varchar(150),@workergroupid smallint, @id int", "UpdateWorker")
        Cms.CreateStoreProcedure("select workerid,workername,gender,age,phone,address,workergroupid from tbWorker where workerid=@id", "@id int", "SelectWorkerbyID")
        Cms.CreateStoreProcedure("select workerid,workername from tbWorker order by workername", Nothing, "SelectAllWorker")
        Cms.CreateStoreProcedure("select workerid, workername from tbWorker WHERE workername LIKE @name order by workername", "@name varchar(30)", "SearchWorker")

        'WorkerGroup
        Cms.CreateStoreProcedure("insert into tbWorkerGroup (groupname,staffid,description,amount,Create_Date)values(@name,@staffid,@descr,@amount,@date)", "@name varchar(50), @staffid smallint,@descr varchar(150),@amount money,@date date", "InsertWorkerGroup")
        Cms.CreateStoreProcedure("Update tbWorkerGroup set groupname=@name,staffid=@staffid,description=@descr,amount=@amount,create_date=@date where id=@id", "@name varchar(50),@staffid smallint,@descr varchar(150),@amount money, @date date,@id smallint", "UpdateWorkerGroup")
        Cms.CreateStoreProcedure("select id,groupname,staffid,description,amount,create_date from tbWorkerGroup where id=@id", "@id smallint", "SelectWorkerGroupbyID")
        Cms.CreateStoreProcedure("select id,groupname from tbWorkerGroup order by groupname", Nothing, "SelectAllWorkerGroup")
        Cms.CreateStoreProcedure("select id, groupname from tbWorkerGroup WHERE groupname LIKE @name order by groupname", "@name varchar(30)", "SearchWorkerGroup")

        'Equipment
        Cms.CreateStoreProcedure("Insert into tbEquipment (EquipName,EquipType,Qty,UnitPrice,Amount,Expiredate)values(@name,@type,@qty,@price,@amount,@exdate)", "@name varchar(30),@type varchar(30),@qty smallint,@price money,@amount money,@exdate date", "InsertEquipment")
        Cms.CreateStoreProcedure("Update tbEquipment set EquipName=@name,EquipType=@type,Qty=@qty,UnitPrice=@price,Amount=@amount,Expiredate=@exdate where EquipID=@id", "@name varchar(30),@type varchar(30),@qty smallint,@price money,@amount money,@exdate date,@id smallint", "UpdateEquipment")
        Cms.CreateStoreProcedure("Select EquipID,EquipName,EquipType,Qty,UnitPrice,Amount,Expiredate from tbEquipment where EquipID=@id order by EquipName", "@id smallint", "SelectEquipmentbyID")
        Cms.CreateStoreProcedure("Select EquipID,EquipName from tbEquipment order by EquipName", Nothing, "SelectAllEquipment")
        Cms.CreateStoreProcedure("Select EquipID,EquipName from tbEquipment where EquipName LIKE @name order by EquipName", "@name varchar(30)", "SearchEquipment")
        Cms.CreateStoreProcedure("Select Distinct EquipType from tbEquipment order by EquipType", Nothing, "SelectAllType")
        'Cms.CreateStoreProcedure("Delete from tbEquipment where EquipID=@id", "@id smallint", "DeleteEquipment")

        '///////////////////////////////////////////////

        'Cms.CreateStoreProcedure("Insert into tbImportDetail(ImportNo,EquipID,ImportQty,UnitPrice,Amount)values('@impid',@eqid,@qty,@unitprice,@amount)", "@imid smallint,@eqid smallint,@qty int,@unitprice money,@amount money", "InsertToImportDetail")
        'Cms.CreateStoreProcedure("Insert into tbImport(ImportDate,staffID,SupID,TotalAmount)values(@date,@staffid,@supid,@total)", "@date date,@staffid smallint,@supid smallint,@total money", "InsertToImport")


    End Sub
End Module
