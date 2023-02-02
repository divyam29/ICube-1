-- create database icubep;
use icubep;

create table Users(id int IDENTITY(1,1) primary key, UserName varchar(255) not null unique, Orgname varchar(255) not null, OrgAddress text not null, desig varchar(255) not null, Phone varchar(15) not null,Password varchar(255) not null,is_expert int default 0,is_industry int default 0,file_name varchar(255),otp int,sid varchar(255));

create table Issues(id int IDENTITY(1,1) primary key,userid int,Heading varchar(255),Body text not null,SubmitDate datetime,UpdateDate datetime,file_name varchar(255),is_approved int default 0,show_name int default 0);

alter table Issues add foreign key(userid) references Users(id);

alter table Users
add is_admin int default 0;

create table Response(id int IDENTITY(1,1) primary key,userid int,issue_id int,Heading varchar(255),Body text not null,rating int,SubmitDate datetime,UpdateDate datetime,prop_tech text,deli text,amt float(50),amt_bifur text,trl int, is_approved int,dhead int,dbody int , dpt int,ddeli int, damt int, dtrl int, damtb int,dcontinfo int);

create table otp(userid varchar(255), otp int, intime datetime);
