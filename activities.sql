#Database creation script

drop table activity;
drop table rule;
drop table course;
drop table evaluator;
drop table category;

create table course (
	id int not null auto_increment,
	name varchar(255),
	minDuration int,
	maxDuration int,
	primary key(id)
);

create table rule (
	id int not null auto_increment,
	reqHours int,
	courseID int,
	primary key(id),
	foreign key(courseID) references course(id)
);

create table activity (
	id int not null auto_increment,
	description varchar(255),
	minHours int,
	maxHours int,
	hourStep int,
	ruleID int,
	primary key(id),
	foreign key(ruleID) references rule(id)
);

create table evaluator (
	id int not null auto_increment,
	name varchar(255),
	primary key(id)
);

create table category (
	id int not null auto_increment,
	name varchar(255),
	primary key(id)
);