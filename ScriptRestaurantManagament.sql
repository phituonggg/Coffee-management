CREATE DATABASE QuanLyQuanCafe1

USE [QuanLyQuanCafe1]
GO
/****** Object:  User [giakiet]    Script Date: 29/05/2023 6:48:22 CH ******/
CREATE USER [giakiet] FOR LOGIN [giakiet] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [staff]    Script Date: 29/05/2023 6:48:22 CH ******/
CREATE USER [staff] FOR LOGIN [staff] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [staff1]    Script Date: 29/05/2023 6:48:22 CH ******/
CREATE USER [staff1] FOR LOGIN [staff1] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [staff2]    Script Date: 29/05/2023 6:48:22 CH ******/
CREATE USER [staff2] FOR LOGIN [staff2] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  UserDefinedFunction [dbo].[FN_GetListIncomeByDate]    Script Date: 29/05/2023 6:48:22 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[FN_GetListIncomeByDate]
(@datein date,@dateout date)
returns @DanhSachThuNhap table(namee nvarchar(100),dateinn date,dateoutt date,discountt int ,totalPricee float)
as
begin
	INSERT INTO @DanhSachThuNhap(namee,dateinn,dateoutt,discountt,totalPricee)
	select t.name,b.DateCheckIn,b.DateCheckOut,b.discount,b.totalPrice 
	from dbo.Bill as b ,dbo.TableFood as t 
	where  DateCheckIn>=@datein and DateCheckOut<=@dateout 
	and b.status=1  and t.id=b.idTable
	return

end

GO
/****** Object:  UserDefinedFunction [dbo].[FN_GetMenu]    Script Date: 29/05/2023 6:48:22 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[FN_GetMenu] (@id1 int)
returns @Menu table(namefood nvarchar(100),countt int ,price float,totalPricee float)
as 
begin
	INSERT INTO @Menu(namefood,countt,price,totalPricee)
	Select c.name as foodname ,b.count,c.price,c.price*b.count as totalPrice from dbo.Bill as a,dbo.BillInfo as b,dbo.Food as c WHERE b.idBill = a.id and b.idFood = c.id and a.idTable =  @id1 and a.status=0
	return
end
GO
/****** Object:  UserDefinedFunction [dbo].[FN_ListAccount]    Script Date: 29/05/2023 6:48:22 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   function [dbo].[FN_ListAccount] (@type int)
returns @DanhSachAccountTheoType table(username nvarchar(100),displayname nvarchar(100),password nvarchar(100),type int)
as
begin
	insert into @DanhSachAccountTheoType(username,displayname,password,type)
	select Username,DisplayName,Password,Type
	from dbo.Account
	where Type=@type
	return

end
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 29/05/2023 6:48:22 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee](
	[idEmployee] [int] IDENTITY(1,1) NOT NULL,
	[nameEmpployee] [nvarchar](100) NOT NULL,
	[birthEmployye] [datetime] NULL,
	[workingEmployye] [float] NOT NULL,
	[statusEmployye] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idEmployee] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[View_EmployeeActiv]    Script Date: 29/05/2023 6:48:22 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[View_EmployeeActiv] as
select *
from dbo.Employee
where statusEmployye=N'Working'
GO
/****** Object:  Table [dbo].[Account]    Script Date: 29/05/2023 6:48:22 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[UserName] [nvarchar](100) NOT NULL,
	[DisplayName] [nvarchar](100) NOT NULL,
	[Password] [nvarchar](1000) NOT NULL,
	[Type] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[UserName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[ListAccount]    Script Date: 29/05/2023 6:48:22 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[ListAccount] as
select * from dbo.Account
GO
/****** Object:  Table [dbo].[Bill]    Script Date: 29/05/2023 6:48:22 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bill](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[DateCheckIn] [date] NOT NULL,
	[DateCheckOut] [date] NULL,
	[idTable] [int] NOT NULL,
	[status] [int] NOT NULL,
	[Discount] [int] NULL,
	[totalPrice] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BillInfo]    Script Date: 29/05/2023 6:48:22 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BillInfo](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idBill] [int] NOT NULL,
	[idFood] [int] NOT NULL,
	[count] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Food]    Script Date: 29/05/2023 6:48:22 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Food](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](100) NOT NULL,
	[idCategory] [int] NOT NULL,
	[price] [float] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FoodCategory]    Script Date: 29/05/2023 6:48:22 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FoodCategory](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TableFood]    Script Date: 29/05/2023 6:48:22 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TableFood](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](100) NOT NULL,
	[status] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Account] ADD  DEFAULT (N'Coffe') FOR [DisplayName]
GO
ALTER TABLE [dbo].[Account] ADD  DEFAULT ((0)) FOR [Password]
GO
ALTER TABLE [dbo].[Bill] ADD  DEFAULT (getdate()) FOR [DateCheckIn]
GO
ALTER TABLE [dbo].[Bill] ADD  DEFAULT ((0)) FOR [Discount]
GO
ALTER TABLE [dbo].[Bill] ADD  DEFAULT (NULL) FOR [totalPrice]
GO
ALTER TABLE [dbo].[BillInfo] ADD  DEFAULT ((0)) FOR [count]
GO
ALTER TABLE [dbo].[Employee] ADD  DEFAULT (N'NO NAME IS SET') FOR [nameEmpployee]
GO
ALTER TABLE [dbo].[Employee] ADD  DEFAULT ((0)) FOR [workingEmployye]
GO
ALTER TABLE [dbo].[Employee] ADD  DEFAULT (N'Off') FOR [statusEmployye]
GO
ALTER TABLE [dbo].[Food] ADD  DEFAULT (N'Chưa đặt tên') FOR [name]
GO
ALTER TABLE [dbo].[FoodCategory] ADD  DEFAULT (N'Chưa đặt tên') FOR [name]
GO
ALTER TABLE [dbo].[TableFood] ADD  DEFAULT (N'NO NAME IS SET') FOR [name]
GO
ALTER TABLE [dbo].[TableFood] ADD  DEFAULT (N'Free') FOR [status]
GO
ALTER TABLE [dbo].[Bill]  WITH CHECK ADD FOREIGN KEY([idTable])
REFERENCES [dbo].[TableFood] ([id])
GO
ALTER TABLE [dbo].[BillInfo]  WITH CHECK ADD FOREIGN KEY([idBill])
REFERENCES [dbo].[Bill] ([id])
GO
ALTER TABLE [dbo].[BillInfo]  WITH CHECK ADD FOREIGN KEY([idFood])
REFERENCES [dbo].[Food] ([id])
GO
ALTER TABLE [dbo].[Food]  WITH CHECK ADD FOREIGN KEY([idCategory])
REFERENCES [dbo].[FoodCategory] ([id])
GO
ALTER TABLE [dbo].[Employee]  WITH CHECK ADD  CONSTRAINT [CHECK_TUOI] CHECK  (((datepart(year,getdate())-datepart(year,[birthEmployye]))>=(18)))
GO
ALTER TABLE [dbo].[Employee] CHECK CONSTRAINT [CHECK_TUOI]
GO
/****** Object:  StoredProcedure [dbo].[AddTable]    Script Date: 29/05/2023 6:48:22 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Update dbo.Food set name = Sting , idCategory=4 , price=16000 where id=9


--exec UpdateAccount 'giakiet' , 'Kiet' , '1' , 'giakiet'
--select * from dbo.Account

--select *from dbo.TableFood
--Go

CREATE   Proc [dbo].[AddTable]
as
begin
	DECLARE @count INT =0
	SELECT @count= MAX (id) from DBO.TableFood
	INSERT dbo.TableFood (name) 
	values(N'Table ' + cast(@count as nvarchar(100)))
End
GO
/****** Object:  StoredProcedure [dbo].[DeleteEmploy]    Script Date: 29/05/2023 6:48:22 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   Proc [dbo].[DeleteEmploy]
@id int
as 
begin
	
	delete from dbo.Employee where  idEmployee=@id
	declare @resetid int =@id -1
	DBCC CHECKIDENT ('dbo.Employee', RESEED, @resetid)
end
GO
/****** Object:  StoredProcedure [dbo].[DeleteTable]    Script Date: 29/05/2023 6:48:22 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Proc [dbo].[DeleteTable]
as 
begin
	declare @maxid int =0
	select @maxid =MAX (id) from dbo.TableFood 
	delete from dbo.TableFood where  id=@maxid
	declare @resetid int =@maxid -1
	DBCC CHECKIDENT ('dbo.TableFood', RESEED, @resetid)
end
GO
/****** Object:  StoredProcedure [dbo].[GanQuyenNhanVien]    Script Date: 29/05/2023 6:48:22 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create or alter   procedure [dbo].[GanQuyenNhanVien](@type int,@Loginname nvarchar(100) )
AS
BEGIN

		DECLARE @quyen varchar(15), @tenUser nvarchar(15),@nhom varchar(20),@Num int
		set @Num=@type 
		
 

		SELECT @tenUser=Username FROM Account WHERE type=@type and UserName=@Loginname

		-- Add người dùng vào role tương ứng (Staff hoặc Manager(sysadmin))
		if (@type= 0)
			Begin
				DECLARE @sqlString NVARCHAR(MAX);
				SET @sqlString = N'ALTER SERVER ROLE sysadmin ADD MEMBER ' + QUOTENAME(@tenUser);
				EXEC sp_executesql @sqlString;
			end 
		else
			BEGIN
				--SET @sqlString = 'ALTER ROLE Librarian ADD MEMBER ' + @tenUser;
				--exec (@sqlString)
				DECLARE @sql NVARCHAR(MAX);
				;
				SET @sql = 'GRANT SELECT, INSERT, UPDATE, DELETE ON Bill TO ' + QUOTENAME(@tenUser)+ 
				';GRANT SELECT, INSERT, UPDATE, DELETE ON BillInfo TO ' + QUOTENAME(@tenUser) +
				';GRANT SELECT, INSERT, UPDATE, DELETE ON TableFood TO ' + QUOTENAME(@tenUser)
				+ ';GRANT SELECT TO ' + QUOTENAME(@tenUser)
				+';GRANT EXECUTE  ON USP_GetLogin TO'+QUOTENAME(@tenUser)
				+';GRANT EXECUTE  ON USP_InsertBill TO'+QUOTENAME(@tenUser)
				+';GRANT EXECUTE  ON USP_InsertBillInfo TO'+QUOTENAME(@tenUser)
				+';GRANT EXECUTE  ON USP_GetUncheckTable TO'+QUOTENAME(@tenUser)
				+';GRANT EXECUTE  ON USP_GetTableList TO'+QUOTENAME(@tenUser)
				+';GRANT EXECUTE  ON USP_GetAccountByUserName TO'+QUOTENAME(@tenUser)
				+';GRANT EXECUTE  ON USP_GetAccountByUserName TO'+QUOTENAME(@tenUser)
				+';DENY SELECT ON  ListAccount TO'+QUOTENAME(@tenUser)
				
				EXECUTE sp_executesql @sql;
			END
END			
GO

/****** Object:  StoredProcedure [dbo].[GetListByDate]    Script Date: 29/05/2023 6:48:22 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


--SELECT MAX (id) FROM dbo.Bill
--Select c.name as foodname ,b.count,c.price,c.price*b.count as totalPrice from dbo.Bill as a,dbo.BillInfo as b,dbo.Food as c WHERE b.idBill = a.id and b.idFood = c.id and a.idTable = 1 and a.status=0
--SELECT * FROM dbo.Bill Where idTable = 4 AND status =0


--go


CREATE   PROC [dbo].[GetListByDate]
@datein date,@dateout date
as begin
select t.name,b.DateCheckIn,b.DateCheckOut,b.discount,b.totalPrice from dbo.Bill as b ,dbo.TableFood as t where  DateCheckIn>=@datein and DateCheckOut<=@dateout and b.status=1  and t.id=b.idTable
end

--exec GetListByDate '20230501' ,'20230531'

GO
/****** Object:  StoredProcedure [dbo].[ThemDangNhap]    Script Date: 29/05/2023 6:48:22 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   PROCEDURE [dbo].[ThemDangNhap] (@LoginName NVARCHAR(100), @password NVARCHAR(1000) ,@type int)
AS
BEGIN
	SET XACT_ABORT ON
	BEGIN TRAN
	BEGIN TRY

	INSERT INTO Account(UserName, Password,Type) VALUES 
	(@LoginName,@password,@type);
	EXEC GanQuyenNhanVien @type,@LoginName

	COMMIT TRAN
	END TRY
	BEGIN CATCH
	ROLLBACK
	DECLARE @err varchar(MAX)
	SELECT @err = 'Lỗi: ' + ERROR_MESSAGE()
	RAISERROR(@err, 16,1)
	END CATCH
END
GO
exec ThemDangNhap 'buoi','buoi' , '0'
/****** Object:  StoredProcedure [dbo].[UpdateAccount]    Script Date: 29/05/2023 6:48:22 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   PROC [dbo].[UpdateAccount]
@username nvarchar(100),@displayname nvarchar(100),@password nvarchar(100),@newPasword nvarchar(100)
as
begin
	declare @isAvailable int =0
	SELECT @isAvailable=COUNT(*) from dbo.Account where Username=@username and Password=@password
	if(@isAvailable>0)
	BEGIN
		if(@newPasword=NULL or @newPasword='')
		BEGIN
			Update dbo.Account set DisplayName=@displayname where Username=@username 
		END
		ELSE	
			Update dbo.Account set Password=@newPasword, DisplayName=@displayname where Username=@username 
	END
	select * from dbo.Account  where Username=@username and Password=@newPasword
end
GO
/****** Object:  StoredProcedure [dbo].[USP_CaculateWorkingTime]    Script Date: 29/05/2023 6:48:22 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   PROC [dbo].[USP_CaculateWorkingTime]
@totaltime float
as
begin
	Begin Tran
	declare @count int=0
	Select  @count= COUNT(*) from dbo.TableFood where status=N'In Using'
	Update dbo.Employee set workingEmployye+=@totaltime where statusEmployye=N'Working'
	Update dbo.Employee set statusEmployye=N'Off' where statusEmployye=N'Working'
		if(@totaltime<4)
		begin
			rollback 
			DECLARE @err varchar(MAX)
			SELECT @err = 'Each shift must last more than 4 hour '
			RAISERROR(@err, 16,1)
		end
		else if(@count>0)
		begin
			rollback 
			
			SELECT @err = 'All table need to be pay ,before allowing all employees to end shift '
			RAISERROR(@err, 16,1)
		end
		else
			Commit Tran

	
end
GO
/****** Object:  StoredProcedure [dbo].[USP_EmployeeWorking]    Script Date: 29/05/2023 6:48:22 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   PROC [dbo].[USP_EmployeeWorking]
@id int 
as
begin
	declare @idemploy int
	SELECT @idemploy = MAX(idEmployee) from dbo.Employee
	if(@id>@idemploy)
		begin
			DECLARE @err varchar(MAX)
			SELECT @err = 'ID of employee is unavailable '
			RAISERROR(@err, 16,1)
		end
	else
	begin
		UPDATE dbo.Employee set statusEmployye=N'Working' where idEmployee=@id
	end
end


GO
/****** Object:  StoredProcedure [dbo].[USP_GetAccountByUserName]    Script Date: 29/05/2023 6:48:22 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_GetAccountByUserName]
@username nvarchar(100)
AS 
BEGIN
	SELECT *FROM dbo.Account WHERE UserName=@username
End
GO
/****** Object:  StoredProcedure [dbo].[USP_GetBill]    Script Date: 29/05/2023 6:48:22 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_GetBill]
@idbill int
AS 
	SElect*FROM dbo.TableFood
GO
/****** Object:  StoredProcedure [dbo].[USP_GetLogin]    Script Date: 29/05/2023 6:48:22 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_GetLogin]
@username nvarchar(100),@password nvarchar(100)
AS 
BEGIN
	SELECT *FROM dbo.Account WHERE UserName=@username AND Password=@password
End
GO
/****** Object:  StoredProcedure [dbo].[USP_GetMenu]    Script Date: 29/05/2023 6:48:22 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[USP_GetMenu]
@id1 int
as 
begin
	Select c.name as foodname ,b.count,c.price,c.price*b.count as totalPrice from dbo.Bill as a,dbo.BillInfo as b,dbo.Food as c WHERE b.idBill = a.id and b.idFood = c.id and a.idTable =  @id1 and a.status=0
end
GO
/****** Object:  StoredProcedure [dbo].[USP_GetTableList]    Script Date: 29/05/2023 6:48:22 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_GetTableList]
AS 
	SElect*FROM dbo.TableFood
GO
/****** Object:  StoredProcedure [dbo].[USP_GetUnCheckTable]    Script Date: 29/05/2023 6:48:22 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_GetUnCheckTable]
@idtable int
as
begin
	SELECT * FROM dbo.Bill Where idTable = @idtable AND status =0
end
GO
/****** Object:  StoredProcedure [dbo].[USP_InsertBill]    Script Date: 29/05/2023 6:48:22 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC [dbo].[USP_InsertBill]
@idTable int
AS
BEGIN
	INSERT dbo.Bill
			(DateCheckIn,
			DateCheckOut,
			idTable,
			status,
			Discount
			)
	VALUES (GETDATE(),
			NULL,
			@idTable,
			0,
			0
			)
END
GO
/****** Object:  StoredProcedure [dbo].[USP_InsertBillInfo]    Script Date: 29/05/2023 6:48:22 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO






CREATE   PROC [dbo].[USP_InsertBillInfo]
@idBill int,@idFood int,@count int
AS
BEGIN
	DECLARE @isExistsBillInfo INT
	DECLARE @foodCount INT =1
	SELECT @isExistsBillInfo=id ,@foodCount= a.count from dbo.BillInfo as a Where idBill=@idBill and idFood=@idFood
	if(@isExistsBillInfo>0)
		Begin
			DECLARE @newCount Int=@foodCount+@count
			if(@newCount >0)
				Update dbo.BillInfo SET count=@foodCount+@count where idFood=@idFood and idBill=@idBill
			Else
				DELETE from dbo.BillInfo   Where idBill=@idBill and  idFood=@idFood
		End
	ELSE
		Begin
			INSERT dbo.BillInfo(idBill,idFood,count)
			VALUES(@idBill,@idFood,@count)
		End
END
GO
/****** Object:  StoredProcedure [dbo].[USP_ThanhToanLuong]    Script Date: 29/05/2023 6:48:22 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[USP_ThanhToanLuong] (@idEmployee int)
as
begin
	declare @thoigianlamviec float=0
	SELECT @thoigianlamviec=workingEmployye from dbo.Employee  where idEmployee=@idEmployee
	if(@thoigianlamviec<1)
	begin
		DECLARE @err varchar(MAX)
		SELECT @err =  'Working time must greater than 1 hour'
		RAISERROR(@err, 16,1)
	end
	else 
		Update dbo.Employee set workingEmployye=0 where idEmployee=@idEmployee		
end

GO
/****** Object:  StoredProcedure [dbo].[USP_ThemNhanVien1]    Script Date: 29/05/2023 6:48:22 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--Procedure Them Nhan Vien
CREATE   PROCEDURE [dbo].[USP_ThemNhanVien1] (@HoTen nvarchar(50), @NgaySinh DateTime)
AS
BEGIN

	
	SET XACT_ABORT ON
	BEGIN TRAN
	BEGIN TRY
	INSERT INTO dbo.Employee(nameEmpployee, birthEmployye) VALUES 
	(@HoTen,@NgaySinh);
	--EXEC GanQuyenNhanVien @maNV		

	COMMIT TRAN
	END TRY
	BEGIN CATCH
	ROLLBACK
	DECLARE @err varchar(MAX)
	SELECT @err = 'Lỗi: ' + ERROR_MESSAGE()
	RAISERROR(@err, 16,1)
	END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[USP_XoaDangNhap]    Script Date: 29/05/2023 6:48:22 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   PROCEDURE [dbo].[USP_XoaDangNhap] (@LoginName NVARCHAR(100), @password NVARCHAR(1000) ,@type int)
AS
BEGIN
	
	
	DECLARE @err varchar(MAX)
	declare @count int =0
	BEGIN TRAN
	if(@type=0)
		begin	
			select @count = COUNT(*) from dbo.Account where Type=0
			
		end
	delete dbo.Account where Username=@LoginName 
	if(@count=1)
		begin
			RollBack 
			SELECT @err='Admin account must be available at least 1'
			RAISERROR(@err, 16,1)
		end
	else
		Commit Tran
END
GO
--
CREATE OR ALTER TRIGGER CreateSQLAccount ON Account
after INSERT
AS
	DECLARE @userName nvarchar(30), @passWord nvarchar(10), @type int
	SELECT @userName=nl.UserName, @passWord=nl.Password, @type = nl.Type
	FROM inserted nl
	BEGIN

		DECLARE @sqlString nvarchar(2000)
		-- Tạo tài khoản login cho nhân viên, tên người dùng và mật khẩu là tài khoản  được tạo trên bảng Đăng nhập
		SET @sqlString= 'CREATE LOGIN [' + @userName +'] WITH PASSWORD='''+ @passWord 
		+''', DEFAULT_DATABASE=[QuanLyQuanCafe1], CHECK_EXPIRATION=OFF, 
		CHECK_POLICY=OFF'
		EXEC (@sqlString)
		-- Tạo tài khoản người dùng đối với nhân viên đó trên database (tên người dùng trùng với tên login)
		SET @sqlString= 'CREATE USER ' + @userName +' From LOGIN '+ @userName
		EXEC (@sqlString)

	END
go
CREATE OR ALTER TRIGGER DeleteSqlAccount ON Account
after delete
AS
	DECLARE @userName nvarchar(30), @passWord nvarchar(10), @type int,@count int
	SELECT @userName=nl.UserName, @passWord=nl.Password, @type = nl.Type
	FROM deleted nl
	BEGIN
		
		
		DECLARE @sqlString nvarchar(2000)
		-- Tạo tài khoản login cho nhân viên, tên người dùng và mật khẩu là tài khoản  được tạo trên bảng Đăng nhập
		SET @sqlString= 'Drop LOGIN ' + @userName 
		EXEC (@sqlString)
		-- Tạo tài khoản người dùng đối với nhân viên đó trên database (tên người dùng trùng với tên login)
		SET @sqlString= 'Drop USER ' + @userName 
		EXEC (@sqlString)
	END
go

CREATE OR ALTER TRIGGER CreateSQLAccount ON Account
after INSERT
AS
	DECLARE @userName nvarchar(30), @passWord nvarchar(10), @type int
	SELECT @userName=nl.UserName, @passWord=nl.Password, @type = nl.Type
	FROM inserted nl
	BEGIN

		DECLARE @sqlString nvarchar(2000)
		-- Tạo tài khoản login cho nhân viên, tên người dùng và mật khẩu là tài khoản  được tạo trên bảng Đăng nhập
		SET @sqlString= 'CREATE LOGIN [' + @userName +'] WITH PASSWORD='''+ @passWord 
		+''', DEFAULT_DATABASE=[QuanLyQuanCafe1], CHECK_EXPIRATION=OFF, 
		CHECK_POLICY=OFF'
		EXEC (@sqlString)
		-- Tạo tài khoản người dùng đối với nhân viên đó trên database (tên người dùng trùng với tên login)
		SET @sqlString= 'CREATE USER ' + @userName +' From LOGIN '+ @userName
		EXEC (@sqlString)

	END
go

CREATE OR ALTER TRIGGER DeleteSqlAccount ON Account
after delete
AS
	DECLARE @userName nvarchar(30), @passWord nvarchar(10), @type int,@count int
	SELECT @userName=nl.UserName, @passWord=nl.Password, @type = nl.Type
	FROM deleted nl
	BEGIN
		
		
		DECLARE @sqlString nvarchar(2000)
		-- Tạo tài khoản login cho nhân viên, tên người dùng và mật khẩu là tài khoản  được tạo trên bảng Đăng nhập
		SET @sqlString= 'Drop LOGIN ' + @userName 
		EXEC (@sqlString)
		-- Tạo tài khoản người dùng đối với nhân viên đó trên database (tên người dùng trùng với tên login)
		SET @sqlString= 'Drop USER ' + @userName 
		EXEC (@sqlString)
	END
go


select * from dbo.Account