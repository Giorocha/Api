CREATE DATABASE T_OpFlix

USE T_OpFlix

CREATE TABLE Categorias
(
	IdCategoria			INT PRIMARY KEY IDENTITY 
	,Nome				VARCHAR(255) NOT NULL UNIQUE
);

CREATE TABLE Plataformas
(
	IdPlataforma		INT PRIMARY KEY IDENTITY
	,Nome				VARCHAR(255) NOT NULL UNIQUE
);

CREATE TABLE Classificacoes
(
	IdClassificacao		INT PRIMARY KEY IDENTITY
	,Idade				VARCHAR(10) 
);

CREATE TABLE TipoUsuario
(
	IdTipoUsuario		INT PRIMARY KEY IDENTITY
	,Tipo				VARCHAR(255) NOT NULL UNIQUE
);

CREATE TABLE TipoLancamento
(
	IdTipoLancamento	INT PRIMARY KEY IDENTITY
	,Tipo				VARCHAR(255) NOT NULL UNIQUE
);	

CREATE TABLE Usuarios 
(
	IdUsuario			INT PRIMARY KEY IDENTITY 
	,Nome				VARCHAR(255) NOT NULL
	,Email				VARCHAR(255) NOT NULL
	,Senha				VARCHAR(255) NOT NULL
	,IdTipoUsuario		INT FOREIGN KEY REFERENCES TipoUsuario (IdTipoUsuario)
);

ALTER TABLE Usuarios
DROP COLUMN Imagem

ALTER TABLE Usuarios
ADD Imagem VARCHAR(500)

CREATE TABLE Lancamentos
(	
	IdLancamento		INT PRIMARY KEY IDENTITY 
	,Titulo				VARCHAR(255) NOT NULL UNIQUE
	,Sinopse			VARCHAR(255) NOT NULL
	,Duracao			INT NOT NULL
	,DataLancamento		DATETIME NOT NULL
	,IdPlataforma		INT FOREIGN KEY REFERENCES Plataformas (IdPlataforma)
	,IdCategoria		INT FOREIGN KEY REFERENCES Categorias (IdCategoria)
	,IdClassificao		INT FOREIGN KEY REFERENCES Classificacoes (IdClassificacao)
	,IdTipoLancamento	INT FOREIGN KEY REFERENCES TipoLancamento (IdTipoLancamento)
);

ALTER TABLE Lancamentos
ADD DuracaoMin INT NOT NULL

ALTER TABLE Lancamentos
ALTER COLUMN Sinopse VARCHAR(600)

CREATE TABLE Favoritos
(
	ID					INT PRIMARY KEY IDENTITY 
	,IdUsuario			INT FOREIGN KEY REFERENCES Usuarios (IdUsuario)
	,IdLancamento		INT FOREIGN KEY REFERENCES Lancamentos (IdLancamento)
);
