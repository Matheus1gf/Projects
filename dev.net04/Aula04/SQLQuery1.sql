create table Setor(
	IdSetor			integer			identity(1,1),
	Nome			nvarchar(50)	not null,
	primary key(IdSetor)
)
go

create table Funcionario(
	IdFuncionario		integer			identity(1,1),
	Nome				nvarchar(50)	not null,
	Salario				decimal(18,2)	not null,
	DataAdmissao		date			not null,
	IdSetor				integer			not null,
	primary key(IdFuncionario),
	foreign key(IdSetor) references Setor(IdSetor)
)
go