use T_OpFlix

insert into Categorias (Nome) values ('Musical'), ('Suspense'), ('Drama'), ('Anima��o');
select * from Categorias

insert into TipoUsuarios (Tipo) values ('ADMINISTRA��O'), ('CLIENTE');
select * from TipoUsuarios

insert into Identificacoes (Nome) values  ('Filme'), ('S�rie');
select * from Identificacoes

insert into Classificacoes (Tipo) values ('L'), ('10'), ('12'), ('14'), ('16'), ('+18');
select * from Classificacoes



insert into Usuarios (Nome, Email, Senha, IdTipoUsuario) values
('Erik', 'erik@email.com', '123456', 1)
,('Cassiana', 'cassiana@email.com', '123456', 1)
,('Helena', 'helena@email.com', '123456', 2)
,('Roberto', 'rob@email.com', '3110', 2);
select * from Usuarios

insert into Lancamentos (Titulo, DataLancamento, IdCategoria, IdIdentificacao, Sinopse, TempoDura��o, Veiculo, IdClassificacao) values 
('O Rei Le�o', '18-07-2019', 1 , 1 , 'O Rei Le�o, da Disney, dirigido por Jon Favreau, retrata uma jornada pela savana africana, onde nasce o futuro rei da Pedra do Reino, Simba. O pequeno le�o que idolatra seu pai, o rei Mufasa, � fiel ao seu destino de assumir o reinado. Mas nem todos no reino pensam da mesma maneira. Scar, irm�o de Mufasa e ex-herdeiro do trono, tem seus pr�prios planos. A batalha pela Pedra do Reino � repleta de trai��o, eventos tr�gicos e drama, o que acaba resultando no ex�lio de Simba. Com a ajuda de dois novos e inusitados amigos, Simba ter� que crescer e voltar para recuperar o que � seu por direito', '118', 'Cinema', 1);
select * from Lancamentos
insert into Lancamentos (Titulo, DataLancamento, IdCategoria, IdIdentificacao, Sinopse, TempoDura��o, Veiculo, IdClassificacao) values 
('La Casa De Papel 3 temp', '19-07-2019', 2 , 2, 'Oito habilidosos ladr�es se trancam na Casa da Moeda da Espanha com o ambicioso plano de realizar o maior roubo da hist�ria e levar com eles mais de 2 bilh�es de euros. Para isso, a gangue precisa lidar com as dezenas de pessoas que manteve como ref�m, al�m dos agentes da for�a de elite da pol�cia, que far�o de tudo para que a investida dos criminosos fracasse.', '650', 'Netflix', 5)
,('Deuses Americanos', '30-04-2017', 3, 2 , 'Shadow Moon � um ex-vigarista que serve como seguran�a e companheiro de viagem para o Sr. Wednesday, um homem fraudulento que �, na verdade, um dos velhos deuses, e est� na Terra em uma miss�o: reunir for�as para lutar contra as novas entidades.','620','Prime Video', 12)
,('Toy Story 4', '20-06-2019', 4, 1, 'Woody sempre teve certeza sobre o seu lugar no mundo e que sua prioridade � cuidar de sua crian�a, seja Andy ou Bonnie. Mas quando Bonnie adiciona um relutante novo brinquedo chamado Garfinho ao seu quarto, uma aventura na estrada ao lado de velhos e novos amigos mostrar� a Woody qu�o grande o mundo pode ser para um brinquedo.', '100',	'Cinema	Anima��o', 1);





