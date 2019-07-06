create database if not exists cokbook ;

create table chefs
(
chef varchar(50),
password varchar(50),
age varchar(5),
gender varchar(10),
email varchar(30)
);

create table recipe
(
name varchar(40),
topic varchar(100),
instructions varchar(1000),
place varchar(2)
);

create table toprecipes
(
num int auto_increment primary key,
topic varchar(100),
instructions varchar(1000),
datetill varchar(20)
);

alter table toprecipes
add column image blob after datetill;

create table vote
(
num int,
good int,
bad int,
alreadyvoted varchar(50)
);

alter table vote
ADD CONSTRAINT fk_comentar
FOREIGN KEY (num) REFERENCES toprecipes(num); 