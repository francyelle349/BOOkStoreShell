CREATE DATABASE bookstore;
USE bookstore;
/*
CREATE TABLE autor(
idAutor INT NOT NULL IDENTITY,
nomeAutor VARCHAR(30) NOT NULL,
CONSTRAINT pk_autor PRIMARY KEY (idAutor)
)

CREATE TABLE genero(
idGenero INT NOT NULL IDENTITY,
descricaoGenero VARCHAR(30) NOT NULL,
CONSTRAINT pk_genero PRIMARY KEY (idGenero)
)

CREATE TABLE livro(
idLivro INT NOT NULL IDENTITY,
titulo VARCHAR(100) NOT NULL,
precoLivro DECIMAL(10,2) NOT NULL,
estoqueLivro INT NOT NULL,
idGenero INT NOT NULL,
CONSTRAINT pk_livro PRIMARY KEY (idLivro),
CONSTRAINT chk_precoLivro CHECK (precoLivro >= 0),
CONSTRAINT chk_estoqueLivro CHECK (estoqueLivro >= 0),
CONSTRAINT fk_livro_genero FOREIGN KEY (idGenero) REFERENCES genero(idGenero)
)

CREATE TABLE autor_livro(
idAutor INT NOT NULL,
idLivro INT NOT NULL,
CONSTRAINT fk_autorlivro_autor FOREIGN KEY (idAutor) REFERENCES autor(idAutor),
CONSTRAINT fk_autorlivro_livro FOREIGN KEY (idLivro) REFERENCES livro(idLivro)
)

CREATE TABLE cliente(
idCliente INT NOT NULL IDENTITY,
nomeCliente VARCHAR(50) NOT NULL,
cpfCliente VARCHAR(15) NOT NULL,
emailCliente VARCHAR(50) NOT NULL,
senhaCliente VARCHAR(50) NOT NULL,
telCliente VARCHAR(20),
CONSTRAINT pk_cliente PRIMARY KEY (idCliente)
)

CREATE TABLE pedido(
idPedido INT NOT NULL IDENTITY,
dataPedido DATE,
valorTotalPedido DECIMAL(10,2) NOT NULL,
idCliente INT NOT NULL,
CONSTRAINT pk_pedido PRIMARY KEY (idPedido),
CONSTRAINT fk_pedido_cliente FOREIGN KEY (idCliente) REFERENCES cliente(idCliente)
)

CREATE TABLE item_pedido(
idItemPedido INT NOT NULL IDENTITY,
qtdItemPedido INT NOT NULL,
idLivro INT NOT NULL,
idPedido INT NOT NULL,
CONSTRAINT pk_idItemPedido PRIMARY KEY (idItemPedido),
CONSTRAINT fk_ItemPedido_livro FOREIGN KEY (idLivro) REFERENCES livro(idLivro),
CONSTRAINT fk_ItemPedido_pedido FOREIGN KEY (idPedido) REFERENCES pedido(idPedido)
)
*/

--criar os procedimentos para os livros
/*
create proc spmostrar_Livro
as
select * from livro
order by idLivro desc 
go

create proc spbuscar_livro
@textobuscar varchar(50)
as select * from livro where titulo like @textobuscar + '%'
go

create proc spadd_livro
@idLivro int output,
@titulo varchar(100),
@precoLivro DECIMAL(10,2),
@estoqueLivro int,
@idGenero int
as
insert into livro (titulo,precoLivro,estoqueLivro,idGenero) values(@titulo,@precoLivro,@estoqueLivro,@idGenero)
go

create proc speditar_livro
@idLivro int output,
@titulo varchar(100),
@precoLivro DECIMAL(10,2),
@estoqueLivro int,
@idGenero int
as
update livro set
titulo = @titulo,
precoLivro =@precoLivro,
estoqueLivro =@estoqueLivro,
where idLivro = @idLivro
go

create proc spexcluir_livro
@idLivro int
as 
delete from livro where idLivro = @idLivro
go



--criando acesso funcionario

CREATE TABLE funcionario(
idFunci INT NOT NULL IDENTITY,
nomeFunci VARCHAR(50) NOT NULL,
cpfFunci VARCHAR(11) NOT NULL,
emailFunci VARCHAR(50) NOT NULL,
senhaFunci VARCHAR(50) NOT NULL,
CONSTRAINT pk_Funci PRIMARY KEY (idFunci)
)
*/
--criar os procedimentos 

