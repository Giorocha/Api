CREATE DATABASE T_BookStore;

USE T_BookStore;

CREATE TABLE Generos
(
    IdGenero    INT PRIMARY KEY IDENTITY
    ,Descricao  VARCHAR(200) NOT NULL UNIQUE
);

CREATE TABLE Autores 
(
    IdAutor             INT PRIMARY KEY IDENTITY
    ,Nome               VARCHAR(200)
    ,Email              VARCHAR(255) UNIQUE
    ,Ativo              BIT DEFAULT(1) -- BIT/CHAR
    ,DataNascimento     DATE
);

CREATE TABLE Livros
(
    IdLivro             INT PRIMARY KEY IDENTITY
    ,Titulo             VARCHAR(255) NOT NULL UNIQUE
    ,IdAutor            INT FOREIGN KEY REFERENCES Autores (IdAutor)
    ,IdGenero           INT FOREIGN KEY REFERENCES Generos (IdGenero)
);

insert into Generos (Descricao) values ('Ficção')
select * from Generos

insert into Autores (Nome, Email, Ativo, DataNascimento) values ('J. K. Rowling', 'Jk_1965@hotmail.com', '1', '31/07/1965')
select * from Autores

insert into Livros (Titulo, IdAutor, IdGenero) values ('Harry Potter E as Relíquias da Morte','1','1')
select * from Livros