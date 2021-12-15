create database EsportsDatabase;

use EsportsDatabase;

create table Team(
TeamID int IDENTITY (1,1) not null,--first field must be the id
TeamName varchar(50) not null,
Brand varchar(50),
NumberOfPlayers int not null

PRIMARY KEY (TeamID)
);

create table Player(
PlayerID int IDENTITY (1,1) not null,--first field must be the id
UserName varchar(25) not null,
Age int not null,
RealName varchar(50) not null,
PrefChar varchar(50) not null,
TeamID int foreign key references Team(TeamID)

PRIMARY KEY (PlayerID)
);

create table MatchHistory(
MatchID int IDENTITY (1,1) not null,--first field must be the id
TeamID int foreign key references Team(TeamID),
Outcome int not null

PRIMARY KEY (MatchID)
);


Select * from sys.tables;


drop table MatchHistory
drop table Team
drop table Player


