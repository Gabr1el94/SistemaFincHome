-- Geração de Modelo físico
-- Sql ANSI 2003 - brModelo.



--CREATE TABLE Cliente (
--DtNascimet_client date not null,
--Senha_client varchar(30)not null,
--Cpf_client varchar(20)not null,
--Email_client varchar(100)not null,
--Cod_client int PRIMARY KEY,
--Nome_client varchar(100) not null
--)

--CREATE TABLE Recebimento (
--Cod_receb int PRIMARY KEY,
--Valor_receb float not null,
--Descricao_receb varchar(50),
--Cod_fin int
--)

--CREATE TABLE Finança (
--Ativo smallint,
--Nome_fin varchar(100),
--DtEmissao_finc date,
--Cod_fin int PRIMARY KEY,
--Cod_conta int,
--Cod_categoria int,
--constraint  CHECKEXIST check (Ativo in ( 0, 1))

--)

--CREATE TABLE Conta (
--Cod_conta int PRIMARY KEY,
--Salario_conta float not null,
--data_salario date not null,
--Cod_client int,
--FOREIGN KEY(Cod_client) REFERENCES Cliente (Cod_client)
--)

--CREATE TABLE Categoria (
--Tipo_categoria varchar(30) not null,
--Descricao_categoria varchar(50),
--Cod_categoria int PRIMARY KEY
--)

--CREATE TABLE Despesas (
--Cod_des int PRIMARY KEY,
--vencimento_des date,
--juros_des float,
--valor_des float not null,
--descricao_des varchar(50),
--Cod_fin int,
--FOREIGN KEY(Cod_fin) REFERENCES Finança (Cod_fin)
--)

--CREATE TABLE Auto_1 (
--Cod_des int,
--possui_Cod_des int
--)

--ALTER TABLE Recebimento ADD FOREIGN KEY(Cod_fin) REFERENCES Finança (Cod_fin)
--ALTER TABLE Finança ADD FOREIGN KEY(Cod_conta) REFERENCES Conta (Cod_conta)
--ALTER TABLE Finança ADD FOREIGN KEY(Cod_categoria) REFERENCES Categoria (Cod_categoria)
