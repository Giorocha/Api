create database T_Peoples;

use T_Peoples;

create table Funcionarios 
(
	IdFuncionario int primary key identity
	,Nome varchar(200) not null
	,Sobrenome  varchar(200) not null
)

insert into Funcionarios values ('Catarina', 'Strada'), ('Tadeu', 'Vitelli')

select * from Funcionarios