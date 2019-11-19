USE T_OpFlix

INSERT INTO Categorias VALUES ('Suspense'),('Drama'),('Animação'),('Musical')
INSERT INTO Categorias VALUES ('Terror'),('Ação'),('Comédia'),('Documentário'),('Ficção Científica')

INSERT INTO Plataformas VALUES ('Netflix'),('Cinema'),('Prime Video'),('Crackle')
INSERT INTO Plataformas VALUES ('VHS')

INSERT INTO Classificacoes VALUES ('L'),('10'),('12'),('14'),('16'),('18')

INSERT INTO TipoUsuario VALUES ('Administrador'),('Cliente')

INSERT INTO TipoLancamento VALUES ('Filme'),('Série')

INSERT INTO Usuarios (Nome, Email, Senha, IdTipoUsuario)
VALUES ('Erick','erik@email.com','123456',1)
	   ,('Cassiana','cassiana@email.com','123456',1)
	   ,('Helena','helena@email.com','123456',2)
	   ,('Roberto','rob@email.com','3110',2)

INSERT INTO Usuarios (Imagem)
VALUES ('https://luizlomba.com.br/posteip/midia/Usuario.png')
	   ,('https://conteudo.imguol.com.br/blogs/174/files/2018/05/iStock-648229868-1024x909.jpg')
       ,('https://conteudo.imguol.com.br/blogs/174/files/2018/05/iStock-648229868-1024x909.jpg')
	   ,('https://luizlomba.com.br/posteip/midia/Usuario.png')

UPDATE Usuarios SET Imagem = 'https://luizlomba.com.br/posteip/midia/Usuario.png' WHERE IdUsuario = 4

INSERT INTO Lancamentos (Titulo, Sinopse, DuracaoMin, DataLancamento, IdPlataforma, IdCategoria, IdClassificao, IdTipoLancamento)
VALUES ('O Rei Leão','O Rei Leão, da Disney, dirigido por Jon Favreau, retrata uma jornada pela savana africana,
onde nasce o futuro rei da Pedra do Reino, Simba. O pequeno leão que idolatra seu pai, o rei Mufasa, é fiel ao seu destino de assumir o reinado. 
Mas nem todos no reino pensam da mesma maneira. Scar, irmão de Mufasa e ex-herdeiro do trono, tem seus próprios planos.','118','2019-07-18T00:00:00',2,4,1,1)

,('La Casa de Papel 3° temporada','Oito habilidosos ladrões se trancam na Casa da Moeda da Espanha com o ambicioso plano de realizar o maior roubo da 
história e levar com eles mais de 2 bilhões de euros. Para isso, a gangue precisa lidar com as dezenas de pessoas que manteve como refém, 
além dos agentes da força de elite da polícia, que farão de tudo para que a investida dos criminosos fracasse.','650','2019-07-19T00:00:00',1,1,5,2)

,('Deuses Americanos','Shadow Moon é um ex-vigarista que serve como segurança e companheiro de viagem para o Sr. Wednesday, um homem fraudulento que é,
na verdade, um dos velhos deuses, e está na Terra em uma missão: reunir forças para lutar contra as novas entidades.','620','2017-04-30T00:00:00',3,2,6,2)

,('Toy Story 4','Woody sempre teve certeza sobre o seu lugar no mundo e que sua prioridade é cuidar de sua criança, seja Andy ou Bonnie. 
Mas quando Bonnie adiciona um relutante novo brinquedo chamado Garfinho ao seu quarto, uma aventura na estrada ao lado de velhos e novos amigos mostrará a 
Woody quão grande o mundo pode ser para um brinquedo.','100','2019-06-20T00:00:00',2,3,1,1)

DELETE FROM Lancamentos 
WHERE IdLancamento > 26

UPDATE Lancamentos SET Titulo = 'La Casa de Papel 3° Temporada' WHERE IdLancamento = 7

Update Lancamentos SET DataLancamento = '1994-07-08' WHERE IdLancamento = 6
Update Lancamentos SET IdPlataforma = 5 WHERE IdLancamento = 6
UPDATE Lancamentos SET Imagem = 'https://upload.wikimedia.org/wikipedia/pt/thumb/d/de/White_chicks.jpeg/200px-White_chicks.jpeg' WHERE IdLancamento = 29

INSERT INTO Lancamentos (Titulo, Sinopse, DuracaoMin, DataLancamento, IdPlataforma, IdCategoria, IdClassificao, IdTipoLancamento)
VALUES ('Vingadores Ultimato','Após Thanos eliminar metade das criaturas vivas, os Vingadores precisam lidar com a dor da perda de amigos e seus entes queridos. 
Com Tony Stark (Robert Downey Jr.) vagando perdido no espaço sem água nem comida, Steve Rogers (Chris Evans) e Natasha Romanov (Scarlett Johansson) 
precisam liderar a resistência contra o titã louco.','180','2019-04-11T00:00:00',2,6,3,1)

,('+ Velozes e + Furiosos','O ex-policial Brian OConner se muda de Los Angeles para Miami para recomeçar sua vida. Ele acaba se envolvendo em rachas na sua nova cidade com seu amigo Tej e Suki. 
Suas aventuras terminam quando ele é preso e faz um acordo com agentes do FBI. Brian tem a missão muito perigosa de prender um poderoso chefe do cartel das drogas.','105','2003-06-13T00:00:00',2,6,4,1)

,('Era uma vez em... Hollywood','Los Angeles, 1969. Rick Dalton (Leonardo DiCaprio) é um ator de TV que, juntamente com seu dublê, está decidido a fazer o seu nome em Hollywood. 
Para tanto, ele conhece muitas pessoas influentes na indústria cinematográfica, o que os acaba levando aos assassinatos realizados por Charles Manson na época, 
entre eles o da atriz Sharon Tate (Margot Robbie), que na época estava grávida do diretor Roman Polanski (Rafal Zawierucha).','161','2003-08-15T00:00:00',2,2,5,1)

INSERT INTO Lancamentos (Titulo, Sinopse, DuracaoMin, DataLancamento, IdPlataforma, IdCategoria, IdClassificao, IdTipoLancamento)
VALUES ('Guardiões da Galáxia', 'O aventureiro do espaço Peter Quill torna-se presa de caçadores de recompensas depois que rouba a esfera de um vilão traiçoeiro, Ronan. 
Para escapar do perigo, ele faz uma aliança com um grupo de quatro extraterrestres. Quando Quill descobre que a esfera roubada possui um poder capaz de mudar os rumos do universo, 
ele e seu grupo deverão proteger o objeto para salvar o futuro da galáxia.', '125', '2014-07-31T00:00:00',2,6,3,1)

,('Guardiões da Galaxia', 'O aventureiro do espaço Peter Quill torna-se presa de caçadores de recompensas depois que rouba a esfera de um vilão traiçoeiro, Ronan. 
Para escapar do perigo, ele faz uma aliança com um grupo de quatro extraterrestres. Quando Quill descobre que a esfera roubada possui um poder capaz de mudar os rumos do universo, 
ele e seu grupo deverão proteger o objeto para salvar o futuro da galáxia.', '125', '2014-07-31T00:00:00',1,6,3,1)

INSERT INTO Favoritos (IdUsuario, IdLancamento) 
VALUES	(1,6),(1,4),(2,3),(3,1),(4,5)

SELECT * FROM Categorias ORDER BY IdCategoria ASC
SELECT * FROM Plataformas ORDER BY IdPlataforma ASC
SELECT * FROM Classificacoes ORDER BY IdClassificacao ASC
SELECT * FROM TipoUsuario ORDER BY IdTipoUsuario ASC
SELECT * FROM TipoLancamento ORDER BY IdTipoLancamento ASC
SELECT * FROM Usuarios ORDER BY IdUsuario ASC
SELECT * FROM Lancamentos ORDER BY IdLancamento ASC
select * from Favoritos

insert into Usuarios (nome, email, senha, IdTipoUsuario, Imagem) values 
('Giovanna Rocha','gigca@email.com','281619',2 , 'https://scontent.fcgh14-1.fna.fbcdn.net/v/t1.0-9/1461865_517367608359706_767383850_n.jpg?_nc_cat=102&_nc_oc=AQmGYtVEjXGAsea-ZqXNZSoDETmZ-ZYs6bFXRrJhJjQaIcdcMWj460OTHVMiA1S1gFY&_nc_ht=scontent.fcgh14-1.fna&oh=fde4e9d921dc778ba8836b5fdf607d88&oe=5E5DF185'),
('Rayssa Tavares', 'ray@email.com', '123789', 2, 'https://scontent.fcgh14-1.fna.fbcdn.net/v/t1.0-9/1424421_449140225194817_391076580_n.jpg?_nc_cat=100&_nc_oc=AQkSH7ZEsD0aB09XO8V96NX7yMExCt2E7OYbgK645RE2XjUebEPkpgXmivxMHnTAWkw&_nc_ht=scontent.fcgh14-1.fna&oh=991f4c7cb5b10e1fbb9a96890a93e7ca&oe=5E4E0872')