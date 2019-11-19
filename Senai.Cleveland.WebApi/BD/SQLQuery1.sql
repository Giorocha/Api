CREATE DATABASE T_Cleveland

USE T_Cleveland

CREATE TABLE Medicos(
IdMedico INT PRIMARY KEY IDENTITY NOT NULL
,Nome VARCHAR(255)
,Nascimento DATE
,CRM BIGINT
,Especialidade VARCHAR(255) 
,Ativo VARCHAR(255)
);



INSERT INTO Medicos (Nome, Nascimento, CRM, Especialidade, Ativo)
VALUES ('Dr Jean','2008-11-11','123456','Clinico Geral', 'SIM')

INSERT INTO Medicos (Nome, Nascimento, CRM, Especialidade, Ativo)
VALUES ('Dra Giovanna','2008-11-11','654321','Psquiatra', 'SIM')



SELECT * FROM Medicos;
