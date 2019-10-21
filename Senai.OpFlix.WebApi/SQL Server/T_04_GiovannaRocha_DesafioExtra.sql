use T_OpFlix

alter table Usuarios add Foto image 
select * from Usuarios
insert into Usuarios (Nome, Email, Senha, IdTipoUsuario, Foto) values ('Erik', 'erik@email.com', '123456', 1, 'foto_1.jpeg')
														,('Cassiana', 'cassiana@email.com', '123456', 1, 'Foto_2.jpeg')
														,('Helena', 'helena@email.com', '123456', 2, 'foto_3.jpeg')
														,('Roberto', 'rob@email.com', '3110', 2, 'foto_4.jpeg'); 

delete Usuarios where IdUsuario = 5

update Usuarios 
set IdTipoUsuario = 1
where IdUsuario = 8

select * from Lancamentos

update Lancamentos 
set Titulo = 'La Casa De Papel - 3º Temporada'
where Titulo = 'La Casa De Papel 3 temp'

select * from Lancamentos 

update Lancamentos
set DataLancamento = '08/07/1994'
where Titulo = 'O Rei Leão'

update Lancamentos
set Veiculo = 'VHS'
where Titulo = 'O Rei Leão'



