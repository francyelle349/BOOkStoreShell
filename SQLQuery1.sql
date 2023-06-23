/*CREATE DATABASE bookstore;
USE bookstore;

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
precoLivro FLOAT NOT NULL,
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
valorTotalPedido FLOAT NOT NULL,
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
-------------------------
--procedimentos dos livros
/*
create proc spmostrar_Livro
as
select * from livro
order by idLivro desc
go


create proc spbuscar_livro
@textobuscar varchar(100)
as select * from livro
where titulo like @textobuscar + '%'
go

create proc spadd_livro
@idLivro INT output,
@titulo VARCHAR(100),
@precoLivro FLOAT,
@estoqueLivro INT,
@idGenero INT
as 
insert into livro(titulo,precoLivro,estoqueLivro,idGenero) 
values (@titulo,@precoLivro,@estoqueLivro,@idGenero)
go

create proc speditar_livro
@idLivro INT,
@titulo VARCHAR(100),
@precoLivro FLOAT,
@estoqueLivro INT,
@idGenero INT
as 
update livro 
set 
titulo = @titulo,
precoLivro =@precoLivro,
estoqueLivro= @estoqueLivro,
idGenero = @idGenero 
where idLivro = @idLivro
go

create proc spexcluir_livro
@idLivro INT
as
delete from livro where idLivro = @idLivro
go


CREATE TABLE funcionario(
idFunci INT NOT NULL IDENTITY,
nomeFunci VARCHAR(100) NOT NULL,
emailFunci VARCHAR(100) NOT NULL,
cpfFunci  VARCHAR(11) NOT NULL,
senhaFunci VARCHAR(100) NOT NULL,
CONSTRAINT pk_funci PRIMARY KEY (idFunci),
)
*/
create proc spmostrar_Funci
as
select * from funcionario
order by idFunci desc
go

create proc spbuscar_Funci
@textobuscar varchar(100)
as select * from funcionario
where nomeFunci like @textobuscar + '%'
go

create proc spadd_Funci
@idFunci INT output,
@nomeFunci VARCHAR(100),
@emailFunci VARCHAR(100),
@cpfFunci  VARCHAR(11),
@senhaFunci VARCHAR(100)
as 
insert into funcionario(nomeFunci,emailFunci,cpfFunci,senhaFunci) 
values (@nomeFunci,@emailFunci,@cpfFunci,@senhaFunci)
go

create proc speditar_Funci
@idFunci INT output,
@nomeFunci VARCHAR(100),
@emailFunci VARCHAR(100),
@cpfFunci  VARCHAR(11),
@senhaFunci VARCHAR(100)
as 
update funcionario set
nomeFunci = @nomeFunci,
emailFunci = @emailFunci,
cpfFunci = @cpfFunci,
senhaFunci = @senhaFunci
where idFunci = @idFunci
go
create proc spexcluir_Funci
@idFunci INT
as
delete from funcionario where idFunci = @idFunci
go