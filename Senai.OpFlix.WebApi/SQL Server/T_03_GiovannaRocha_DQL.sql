USE T_OpFlix

SELECT * FROM Categorias ORDER BY IdCategoria ASC
SELECT * FROM Plataformas ORDER BY IdPlataforma ASC
SELECT * FROM Classificacoes ORDER BY IdClassificacao ASC
SELECT * FROM TipoUsuario ORDER BY IdTipoUsuario ASC
SELECT * FROM TipoLancamento ORDER BY IdTipoLancamento ASC
SELECT * FROM Usuarios ORDER BY IdUsuario ASC
SELECT * FROM Lancamentos ORDER BY IdLancamento ASC

SELECT L.Titulo,C.Nome
FROM Lancamentos L
JOIN Categorias C
ON L.IdClassificao = C.IdCategoria

SELECT C.Nome,L.Titulo
FROM Categorias C
LEFT JOIN Lancamentos L
ON C.IdCategoria = L.IdCategoria

SELECT L.Titulo,P.Nome
FROM Lancamentos L
RIGHT JOIN Plataformas P
ON L.IdPlataforma = P.IdPlataforma

SELECT L.Titulo,P.Nome,Ca.Nome,Cl.Idade,TL.Tipo
FROM Lancamentos L
JOIN Plataformas P
ON L.IdPlataforma = P.IdPlataforma
JOIN Categorias CA
ON L.IdCategoria = Ca.IdCategoria
JOIN Classificacoes Cl
ON L.IdClassificao = Cl.IdClassificacao
JOIN TipoLancamento TL
ON L.IdTipoLancamento = TL.IdTipoLancamento

SELECT U.Nome, L.Titulo
FROM Usuarios U
JOIN Favoritos F
ON U.IdUsuario = F.IdUsuario
JOIN Lancamentos L
ON L.IdLancamento = F.IdLancamento

CREATE PROCEDURE BuscarFilmePorCategoria @Categoria VARCHAR(255)
AS
SELECT IdLancamento, Titulo, IdCategoria
FROM Lancamentos WHERE IdCategoria = @Categoria;

CREATE PROCEDURE BuscarFilmePorCategoriaNome @Categoria VARCHAR(255)
AS
SELECT IdLancamento, Titulo, Categorias.Nome
FROM Lancamentos JOIN Categorias ON Categorias.IdCategoria = Lancamentos.IdCategoria WHERE Categorias.Nome= @Categoria;

EXEC BuscarFilmePorCategoria 6;
EXEC BuscarFilmePorCategoriaNome 'Ação';

CREATE PROCEDURE BuscarFilmePorId @IdTipoLancamento INT  
AS 
SELECT IdLancamento, Titulo, Sinopse, DataLancamento, IdPlataforma, IdCategoria, IdClassificao, DuracaoMin 
FROM Lancamentos WHERE IdTipoLancamento = @IdTipoLancamento;

EXEC BuscarFilmePorId 1

CREATE VIEW vwPlataformas AS
SELECT IdPlataforma, Titulo, IdCategoria FROM Lancamentos 

SELECT * FROM vwPlataformas WHERE IdPlataforma = 2