-- Geração de Modelo físico
-- Sql ANSI 2003 - brModelo.
create database CashHome
go 
use CashHome;
--select * from Cliente

CREATE TABLE Cliente (
idCliente int identity not null,
nomeCliente varchar(100) not null,
emailCliente varchar(100) PRIMARY KEY,
senha varchar(30) not null,
cpf varchar(20) not null,
dataNascimento Date not null,
)

CREATE TABLE Conta (
idConta int identity PRIMARY KEY,
salarioConta float,
emailCliente varchar(100),
FOREIGN KEY(emailCliente) REFERENCES Cliente (emailCliente)
)

CREATE TABLE Finança (
dataInicio Date,
dataFim Date,
idFinanca int identity PRIMARY KEY,
nome varchar(100),
idConta int,
idCategoria int,
FOREIGN KEY(idConta) REFERENCES Conta (idConta)
)

CREATE TABLE Categoria (
idCategoria int identity  PRIMARY KEY,
tipoCategoria varchar(50),
descrição varchar(50)
)

CREATE TABLE Recebimento (
idRecebimento int identity  PRIMARY KEY,
dataRecebimento Date,
valorRecebimento Date,
tipo varchar(50),
status smallint,
constraint  CHECkEXIST check (status in ( 0, 1)),
idFinanca int,
FOREIGN KEY(idFinanca) REFERENCES Finança (idFinanca)
)

CREATE TABLE Despesas (
idDespesa int identity PRIMARY KEY,
dataValidade Date,
dataEmissao Date,
status smallint,
constraint  CHECEXIST check (status in ( 0, 1)),
valorDespesa float,
idFinanca int,
FOREIGN KEY(idFinanca) REFERENCES Finança (idFinanca)
)

ALTER TABLE Finança ADD FOREIGN KEY(idCategoria) REFERENCES Categoria (idCategoria)
