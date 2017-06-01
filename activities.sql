#Database creation script

drop table evaluator;

create table evaluator (
	id int not null auto_increment,
	name varchar(255),
	primary key(id)
);
