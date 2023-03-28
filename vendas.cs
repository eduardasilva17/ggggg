create database vendas;

GO
use vendas;
GO

create table tblclientes ( 
cpf_cnpj varchar(20) primary key, 
nome varchar(30), 
endereco varchar(50),
rg_ie varchar(15),
tipo char,
valor float,
valor_imposto float,
total float
);

GO
-- Pessoa Física
insert into tblclientes values ('164.436.789-00',' Odilon neto','Rua comendador cortez 1234','4.567.890','f',2500.00,250.00,2750.00);
insert into tblclientes values ('234.567.621-11',' maria eduarda','Rua Bento345','5.6787.901','f',3000.00,300.00,3300.00);
insert into tblclientes values ('345.920.901-22','Bernardo','Rua Paraná 654','6.789.012','f',1500.00,150.00,1650.00);

GO

-- Pessoa Jurídica

insert into tblclientes values ('56.789.123/0005-00','Agespisa S/A','Av. pinheiro machado 3956','567.890.123','j',35000.00,7000.00,42000.00);
insert into tblclientes values ('67.290.234/0001-11','mateus Ltda.','Rua Pará 765','678.901.204','j',15000.00,3000.00,18000.00);
insert into tblclientes values ('89.052.345/0001-22','Evandro S/A','Av. pedro II 876','850.193.456','j',50000.00,10000.00,60000.00);

select * from tblcliente
