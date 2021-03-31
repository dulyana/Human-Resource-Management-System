CREATE PROC [dbo].[EmployeeViewAll]
AS
SELECT EPFno,EmployeeName,EmpAddress,PostalCode,ContactNumber,NIC,Branch,TaxCode,BasicSalary,Gender,Age,EmpState,DOB FROM EmpDetails
CREATE TABLE [dbo].[Employee]
(
	[Employee_no] NVARCHAR(MAX) NOT NULL PRIMARY KEY,
	[Employee_name] NVARCHAR(MAX) NULL,
	[Other_names] NVARCHAR(MAX) NULL,
	[Address] NVARCHAR(MAX) NULL,
	[Contact_no] NVARCHAR(MAX) NULL,
	[Email] NVARCHAR(MAX) NULL,
	[Designation] NVARCHAR(MAX) NULL,
	[Department] NVARCHAR(MAX) NULL,
	[Salary] NVARCHAR(MAX) NULL,
	[Department_location] NVARCHAR(MAX) NULL

)
