create database ClinicaEnfance
go

use ClinicaEnfance
go

create table Usuarios(
	id_usuario int identity not null primary key,
	nome varchar(50),
	senha varchar(20),
);

create table Clientes(
	id_cliente int identity not null primary key,
	nome_cliente varchar(50),
	telefone_cliente varchar(20),
	cpf varchar(15),
	endereco varchar(60)
);

create table Especialidades(
	id_especialidade int identity not null primary key,
	nome varchar (50) not null 
);

create table Medicos(
	id_medico int identity not null primary key,
	nome_medico varchar(100),
	telefone_medico varchar(20),
	crm varchar(20),
	uf varchar(3),
	dia_disponivel varchar(20),
	id_especialidade int,
	foreign key (id_especialidade) references Especialidades(id_especialidade)
);

create table Consultas(
	id_consulta int identity not null primary key,
	tipo varchar(20),
	valor float,
	id_medico int not null,
	foreign key (id_medico) references Medicos (id_medico)
);

create table Agendamentos(
	id_agendamento int identity not null primary key,
	nome_cliente varchar(100),
	cpf_cliente varchar(15),
	endereco varchar(100),
	telefone_cliente varchar(16),
	data_agendamento varchar(50),
	hora_agendamento varchar(10),
	tipo_agendamento varchar(20),
	valor float,
	medico varchar(100)
);

select * from U;

drop table Usuarios;
