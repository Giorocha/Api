create database T_Roman

use T_Roman

create table Usuarios (
	IdUsuario int primary key identity
	,Nome varchar(200) not null 
	,Email varchar (200) not null unique 
	,Senha varchar (200) not null
)

 create table Tema (
	IdTema int primary key identity
	,Nome varchar(200) not null
 )

create table Projetos (
	IdProjeto int primary key identity
	,Nome varchar(200)
	,IdTema int foreign key references Tema (IdTema)
 )
