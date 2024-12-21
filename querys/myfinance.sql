--create database myfinance;
use myfinance

create table PLANOCONTA(
	id int not null identity(1,1),
	nome varchar (50) not null,
	tipo char (1) not null,
	primary key (id)
);

create table TRANSACAO(
	id int not null identity(1,1),
	data datetime not null,
	valor decimal(9,2),
	historico varchar(100),
	tipo char(1) not null,
	planocontaid int not null,
	primary key(id),
	foreign key (planocontaid) references PLANOCONTA(id)
);

select * from PLANOCONTA;
select * from TRANSACAO;

delete from PLANOCONTA where id = '22';
