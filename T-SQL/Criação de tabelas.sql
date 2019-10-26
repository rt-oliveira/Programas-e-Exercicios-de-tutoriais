create table Customers(
	id int not null,
	nome varchar(20) not null,
	idade int not null,
	endereco char(25),
	salario decimal(18,2),
	primary key(id)
);