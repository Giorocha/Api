use T_Roman

insert into Usuarios (Nome, Email, Senha) values 
('Helena', 'Helena@.com', '123456'), ('Eric','Eric@.com','654321')

insert into Tema (Nome) values 
('Gestão'), ('HQs'), ('Desenvolvimento')

insert into Projetos (Nome, IdTema) values 
('Controle de Estoque','1'), ('Listagem de Personagem', '2')

select * from Usuarios
select * from Tema
select * from Projetos