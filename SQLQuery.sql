/*
 **** Data Types ****
 char()
 varchar()
 varchar(max)
 text
 nvarchar()
 image

 bit 
 tinyint
 smallint
 int
 bigint
 mone
 float
 real (decimal)

 date
 datetime
 datetime2
 time
 
 *** SQL Commands ***
 create database databaseName
 drop database databaseName 

 Create table Person (
   PersonId int,
   FirstName varchar(50),
   LastName varchar(30),
   Address varchar(255),
   City varchar(50)
 )

 drop table Person

 Alter table Person
 add Email varchar(255)
 
 Alter table Person
 drop column Email 
 
 Constraints (kısıtlamalar)
    ** not null
	** unique
	** primary key
	** foreign key
	** check
	** default

	 Create table Person (
       PersonId int not null,
       FirstName varchar(50) not null,
       LastName varchar(30) not null,
       Address varchar(255) not null,
       City varchar(50) not null
     )
     alter table Person
     alter column City varchar(40) null

	 Create table Person (
       PersonId int not null unique,
       FirstName varchar(50) not null,
       LastName varchar(30) not null,
       Address varchar(255) not null,
       City varchar(50) not null,
	   Unique(FirstName),
	   constraint UniquePerson Unique (LastName, Address)
     )
     alter table Person
     add unique(PersonId)
     
     alter table Person
     drop constraint UniquePerson

	 Create table Person (
       PersonId int not null,
       FirstName varchar(50) not null,
       LastName varchar(30) not null,
       Address varchar(255) not null,
       City varchar(50) not null,
       Primary Key(PersonId)
     )
     
     alter table Person
     add Primary Key(PersonId)
     
	 create table Orders (
      Id int not null,
      OrnerNumber int not null,
      PersonId int,
      Primary Key (Id),
      Foreign Key(PersonId) references Person(PersonId)
     )
     
     alter table Person
     add age tinyint 

Create table Person (
   PersonId int not null IDENTITY(1,1) PRIMARY KEY,
   FirstName varchar(50) not null,
   LastName varchar(30) not null,
   Address varchar(255) not null,
   City varchar(50) not null,
    --Age tinyint Check(Age > 18),
    Age tinyint,
    --Check (Age > 18)
    Job nvarchar(20) default 'İstanbul',
   --Primary Key(PersonId),
   constraint CHK_PersonAge CHECK (Age >= 18)
)


ALTER TABLE Person
DROP CONSTRAINT CHK_PersonAge;

alter table Person
drop column City

alter table Person
add City nvarchar(25)

ALTER TABLE Person
add constraint dfCity
default 'İstanbul' for city

 */

