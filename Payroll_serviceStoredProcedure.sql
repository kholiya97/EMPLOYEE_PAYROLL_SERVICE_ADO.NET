create procedure dbo.SqlProcedureName
	@Id int ,
	@Name varchar(100),
	@salary float,
	@startDate DATE,
	@Gender CHAR(1),
	@Phone_Number varchar(20),
	@Emp_Address varchar(20),
	@Emp_DEPT varchar(10),
	@Basic_Pay varchar(10),
	@Deduction FLOAT(20),
	@Taxable_Pay FLOAT(20),
	@Income_Tax Float(20),
	@Net_Pay float(20)
	as begin
	Insert into PAYROLL_SERVICE values ( @Id ,@Name,@salary,@startDate,@Gender,@Phone_Number,@Emp_Address,@Emp_DEPT,@Basic_Pay,@Deduction,@Taxable_Pay,@Income_Tax,@Net_Pay)
	End

	drop procedure SqlProcedureName

