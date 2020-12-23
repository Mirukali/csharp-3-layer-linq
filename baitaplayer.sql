create database BaiTapLayer
go

use BaiTapLayer
go

create table users (
	ID nvarchar(10) primary key,
	Name nvarchar(30),
	DateOfBirth DateTime,
	Info nvarchar(50),
	Sex bit
)

create table TieuSu (
	TID nvarchar(10) primary key,
	Info nvarchar(50),
	ID nvarchar(10) foreign key (ID) references users(ID)
)

insert into users values ('U1', 'Nguyen Van A', '12/5/1989', 'FA', 0)
insert into users values ('U2', 'Nguyen Van B', '12/8/1989', 'FA', 0)
insert into users values ('U3', 'Nguyen Van C', '5/13/1999', 'FA', 1)
insert into users values ('U4', 'Nguyen Van D', '3/12/1990', 'FA', 0)
insert into users values ('U5', 'Nguyen Van E', '03/10/1995', 'FA', 1)
insert into users values ('U6', 'Nguyen Van F', '1/1/1992', 'FA', 1)