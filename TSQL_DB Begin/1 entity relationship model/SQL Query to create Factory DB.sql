create database FactoryDatabase;

use FactoryDatabase;

create table Customer(
	CustomerID int IDENTITY (1,1),--first field must be the id
	Balance float not null, --varchar is a string of characters
	CreditLimit int not null,
	StNum int not null,
	Street varchar(50) not null, 
	City varchar(50) not null

	PRIMARY KEY (CustomerID)
	);
	create table OrderInfo(
	OrderNum int IDENTITY (1,1),--first field must be the id
	FullAddress varchar(100) not null, --carchar is a string of characters
	OrderDate varchar (15) not null,
	Quantity int not null,
	ItemNum int foreign key references Item(ItemNum), 
	CustomerID int foreign key references Customer(CustomerID)

	PRIMARY KEY (OrderNum)
	

	);
	create table Item(
	ItemNum int IDENTITY (1,1),--first field must be the id
	NameOfItem varchar(25) not null,
	ItemDesc varchar (100) not null,
	FactoryNum int foreign key references Factory(FactoryNum)

	PRIMARY KEY (ItemNum)

	);
	create table Factory(
	FactoryNum int IDENTITY (1,1),--first field must be the id
	ContactNum int not null,
	Supplies varchar(50) not null

	PRIMARY KEY (FactoryNum)
	);

	select * from Factory 

	drop table Customer;
	drop table OrderInfo;
	drop table Item;
	drop table Factory;

	Select * from sys.tables;

