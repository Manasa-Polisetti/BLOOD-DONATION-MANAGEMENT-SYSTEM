create database blooddonation__management;

create table newDonor1(
did int NOT NULL IDENTITY(1,1) primary key,
dname varchar(250) not null,
fname varchar(250) not null,
mname varchar(250) not null,
dob varchar(50) not null,
mobile bigint not null,
gender varchar(250) not null,
email varchar(250) not null,
bloodgroup varchar(250) not null,
city varchar(250) not null,
daddress varchar(250) not null,
)
INSERT INTO newDonor1 (1,'radha','rama','sita','10-8-1992',7889202121,'female','radha909@gmail.com','O-','banguluru','ram nagar')
                      

SELECT *FROM newDonor1