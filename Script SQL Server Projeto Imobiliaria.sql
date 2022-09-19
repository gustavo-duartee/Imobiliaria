create database IMOBILIARIA

use IMOBILIARIA

create table Cliente
(
   cd_Cliente int primary key identity,
   nm_cliente varchar(50) not null,
   email varchar(40) not null,
   telefone char(15) not null,
   CPF char(14) not null,
   data_nascimento char(10) not null
)

create table Corretor
(
   cd_Corretor int primary key identity,
   nm_corretor varchar(50) not null,
   email varchar(40) not null,
   telefone char(15) not null,
   CPF char(14) not null,
   data_nascimento char(10) not null
)

create table Imoveis
(
	cd_Imovel int primary key identity,
	Endereço varchar (50) not null,
	Cidade varchar (50) not null,
	Bairro varchar (50) not null,
	CEP char (9) not null,
	Quartos char (2) not null,
	Banheiros char (2) not null,
	Garagem char (9) not null,
	Andares char (2) not null,
	Tamanho varchar (7) not null,
	Tipo varchar (7) not null,
	Lavanderia varchar (3) not null,
)

create table Reserva
(
	cd_Reserva int primary key identity,
	cd_cliente char (3) not null,
	cd_corretor char (3) not null,
	cd_imovel char (3) not null,
	valor char (15) 
)

create table Agendar
(
	cd_Agendar int primary key identity,
	cd_cliente char (3) not null,
	cd_corretor char (3) not null,
	cd_imovel char (3) not null,
	data_agendada char(16) not null
)