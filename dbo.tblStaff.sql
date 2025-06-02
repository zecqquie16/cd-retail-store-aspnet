CREATE TABLE [dbo].tblStaff
(
	[StaffID] INT NOT NULL PRIMARY KEY,
	[Name] Varchar(50) NOT NULL,
	[Email] Varchar(50) NOT NULL,
	[Password] Varchar(50) NOT NULL,
	[PhoneNumber] Varchar(50), 
	[BillingAddress] Varchar(50) NOT NULL, 
	[Status] Varchar(50)

)
