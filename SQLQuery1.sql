create database School3
Use School3

Create Table Students(
Id int primary key,
StudentsName nvarchar(50),
StudentClass int,
StudentsObtainMarks int 
);
insert into Students values (1,'Arun Gautam',11,46),(2,'Nancy ',14,39);
Select * from Students