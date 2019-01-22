drop table if exists Funcionario;
drop table if exists Setor;

create table Setor(
	IdSetor			integer			identity(1,1),
	Nome			nvarchar(50)	not null,
	constraint PK_Setor primary key(IdSetor)
)

create table Funcionario(
	IdFuncionario		integer			identity(1,1),
	Nome				nvarchar(50)	not null,
	Salario				decimal(18,2)	not null,
	DataAdmissao		date			not null,
	IdSetor				integer,
	constraint PK_Funcionario primary key(IdFuncionario),
	constraint FK_Funcionario_Setor foreign key(IdSetor) references Setor(IdSetor)
	on delete set null
)

insert into Setor values ('Vendas');
insert into Setor values ('Peças');
insert into Setor values ('Usados');

insert into Funcionario values ('Maria',2000,'2015-09-13', 1);
insert into Funcionario values ('Felipe',3000,'2016-08-10', 1);
insert into Funcionario values ('Talita',4000,'2017-02-07', 1);
insert into Funcionario values ('Joana',2500,'2010-10-13', 2);
insert into Funcionario values ('Carlos',3500,'2011-08-24', 2);
insert into Funcionario values ('Gabriel',4500,'2010-04-20', 3);

select * from Setor;

select * from Funcionario;