create database myfinance;
go

use myfinance;

create table planoconta(
	id int identity(1,1) not null,
	descricao varchar(50) not null,
	tipo char(1) not null,
	primary key (id)
);

create table transacao(
	id int identity(1,1) not null,
	historico text null,
	data date not null,
	valor decimal(9,2),
	planocontaid int not null,
	primary key (id),
	foreign key (planocontaid) references planoconta(id)
);

insert into planoconta(descricao, tipo) values('Combustível', 'D');
insert into planoconta(descricao, tipo) values('Alimentação', 'D');
insert into planoconta(descricao, tipo) values('Impostos', 'D');
insert into planoconta(descricao, tipo) values('Salário', 'R');

select * from planoconta;

insert into transacao(historico, data, valor, planocontaid) values('Gasolina para viagem', GETDATE(), 300, 1);
insert into transacao(historico, data, valor, planocontaid) values('Compras do mês', GETDATE()+2, 650, 2);
insert into transacao(historico, data, valor, planocontaid) values('Salário do mês', '2024-01-07', 1000, 4);

select * from transacao;
