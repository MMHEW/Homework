--step 1

drop database Warehouse

create database Warehouse;

use Warehouse;
--step 2
create table Warehouses(
warehouseID int IDENTITY (1,1),
place varchar(100) not null,
capacity int not null

primary key (warehouseID)
);

create table boxes(
refNumber char(5) not null,
content varchar(100) not null,
price int not null,
warehouseID int foreign key references Warehouses(warehouseID)

primary key (refNumber)
);

--step 3
ALTER TABLE Warehouses  add city VARCHAR (80) not null ;

--step 4
drop table boxes

--step 5
create table boxes(
refNumber char(5),
content varchar(100) not null,
price int not null,
warehouseID int foreign key references Warehouses(warehouseID)

primary key (refNumber)
);

--step 6

insert into Warehouses(place, capacity, city) values ('Arizona', 200, 'Sierra Vista')
insert into Warehouses(place, capacity, city) values ('Georgia', 150, 'Savannah')
insert into Warehouses(place, capacity, city) values ('Georgia', 600, 'Atlanta')
insert into Warehouses(place, capacity, city) values ('Illinois', 540, 'Springfield')
insert into Warehouses(place, capacity, city) values ('Illinois', 870, 'Carterville')
insert into Warehouses(place, capacity, city) values ('Kentucky', 50, 'Paducha')

--step 7
insert into boxes(refNumber, content, price, warehouseID) values ('AZFWQ', 'All the things', 6041, 1)
insert into boxes(refNumber, content, price, warehouseID) values ('AZFQW', 'Private Stuff', 9999999, 2)
insert into boxes(refNumber, content, price, warehouseID) values ('AASEW', 'You Dont Wanna Know', 541247, 5)
insert into boxes(refNumber, content, price, warehouseID) values ('FSAHG', 'Gold', 20, 4)
insert into boxes(refNumber, content, price, warehouseID) values ('ASDFD', 'Me Millionth Dollar', 1, 6)
insert into boxes(refNumber, content, price, warehouseID) values ('ALHKS', 'Krabby Patty Secret Formula', 21470000, 2)
insert into boxes(refNumber, content, price, warehouseID) values ('TYUIO', 'Cure For Cancer', 2, 1)
insert into boxes(refNumber, content, price, warehouseID) values ('LKJHG', 'Insulin', 254107, 3)
insert into boxes(refNumber, content, price, warehouseID) values ('QWTER', 'Elders Scrolls 6', 214700000, 4)
insert into boxes(refNumber, content, price, warehouseID) values ('MGAFS', 'GTA 6', 214700000, 1)

-- step 8 rename warehouse
use Warehouse
GO
EXEC sp_rename 'Warehouses', 'Warehouse';

--step 9
select * from Warehouse

--step 10
select refNumber, content, price from boxes 

--step 11
update boxes
set price = (price + 200)


--step 12
select * from boxes

--step 13
insert into Warehouse(place, capacity, city) values ('Barcelona', 5 , 'Barcelona')

--step 14
insert into boxes(refNumber, content, price, warehouseID) values ('BCHS1', 'Paper', 3500, 3)

select content from boxes

