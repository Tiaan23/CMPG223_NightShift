Use NightShift
Go

delete from Product where Product_ID=9
Create Table Product
(
	Product_ID int Identity(1,1) Primary Key,
	Product_Name varchar(30),
	Product_Description varchar(30),
	Product_Price money,
	Event_ID int Foreign key references Event#(Event_ID)

);

Create table Artist
(
	Artist_ID int Identity(1,1)primary key,
	Artist_FName varchar(30),
	Artist_LName varchar(30),
	Artist_Email varchar(30)
);

Create Table Event#
(
	Event_ID int identity(1,1) Primary Key,
	Event_Name varchar(30),
	Event_Description varchar(30)
);

Create table Client
(
	Client_ID int Identity(1,1) Primary Key,
	Client_Fname varchar(30),
	Client_Lname varchar(30),
	Client_Access  varchar(30),
	Event_ID int Foreign key references Event#(Event_ID)
);

Create Table Event_Details
(
	Event_ID int Primary Key references Event#(Event_ID),
	Artist_ID int Foreign key references Artist(Artist_ID),
	Event_Date date not null,
	Total_Clients int
);
Create Table STD_Access
(
	STD_Entrance money,
	Client_ID int Primary Key references Client(Client_ID)
);

create table Vip_access
(
	VIP_Entrance money,
	Client_ID int Primary Key references Client(Client_ID)
);


