use T_OpFlix

insert into Categorias (Nome) values ('Musical'), ('Suspense'), ('Drama'), ('Animação');
select * from Categorias

insert into TipoUsuarios (Tipo) values ('ADMINISTRAÇÃO'), ('CLIENTE');
select * from TipoUsuarios

insert into Identificacoes (Nome) values  ('Filme'), ('Série');
select * from Identificacoes

insert into Classificacoes (Tipo) values ('L'), ('10'), ('12'), ('14'), ('16'), ('+18');
select * from Classificacoes



insert into Usuarios (Nome, Email, Senha, IdTipoUsuario) values
('Erik', 'erik@email.com', '123456', 1)
,('Cassiana', 'cassiana@email.com', '123456', 1)
,('Helena', 'helena@email.com', '123456', 2)
,('Roberto', 'rob@email.com', '3110', 2);
select * from Usuarios

insert into Lancamentos (Titulo, DataLancamento, IdCategoria, IdIdentificacao, Sinopse, TempoDuração, Veiculo, IdClassificacao) values 
('O Rei Leão', '18-07-2019', 1 , 1 , 'O Rei Leão, da Disney, dirigido por Jon Favreau, retrata uma jornada pela savana africana, onde nasce o futuro rei da Pedra do Reino, Simba. O pequeno leão que idolatra seu pai, o rei Mufasa, é fiel ao seu destino de assumir o reinado. Mas nem todos no reino pensam da mesma maneira. Scar, irmão de Mufasa e ex-herdeiro do trono, tem seus próprios planos. A batalha pela Pedra do Reino é repleta de traição, eventos trágicos e drama, o que acaba resultando no exílio de Simba. Com a ajuda de dois novos e inusitados amigos, Simba terá que crescer e voltar para recuperar o que é seu por direito', '118', 'Cinema', 1);
select * from Lancamentos
insert into Lancamentos (Titulo, DataLancamento, IdCategoria, IdIdentificacao, Sinopse, TempoDuração, Veiculo, IdClassificacao) values 
('La Casa De Papel 3 temp', '19-07-2019', 2 , 2, 'Oito habilidosos ladrões se trancam na Casa da Moeda da Espanha com o ambicioso plano de realizar o maior roubo da história e levar com eles mais de 2 bilhões de euros. Para isso, a gangue precisa lidar com as dezenas de pessoas que manteve como refém, além dos agentes da força de elite da polícia, que farão de tudo para que a investida dos criminosos fracasse.', '650', 'Netflix', 5)
,('Deuses Americanos', '30-04-2017', 3, 2 , 'Shadow Moon é um ex-vigarista que serve como segurança e companheiro de viagem para o Sr. Wednesday, um homem fraudulento que é, na verdade, um dos velhos deuses, e está na Terra em uma missão: reunir forças para lutar contra as novas entidades.','620','Prime Video', 12)
,('Toy Story 4', '20-06-2019', 4, 1, 'Woody sempre teve certeza sobre o seu lugar no mundo e que sua prioridade é cuidar de sua criança, seja Andy ou Bonnie. Mas quando Bonnie adiciona um relutante novo brinquedo chamado Garfinho ao seu quarto, uma aventura na estrada ao lado de velhos e novos amigos mostrará a Woody quão grande o mundo pode ser para um brinquedo.', '100',	'Cinema	Animação', 1);





