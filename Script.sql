
create table pacientes (
	
	idpaciente int identity,
	nome varchar(250) not null,
	CPF varchar(11) not null unique,
	idade varchar(3) not null,
	respons1 varchar(250) not null,
	respons2 varchar(250),
	telefone_paciente varchar(20) not null,
	telefone_respons1 varchar(20) not null,
	telefone_respons2 varchar(20),
	cirurgias text,
	alergias text

);
go



create table funcionarios (
	
	idfuncionario int identity,
	nomefunc varchar(250) not null,
	CPFfunc varchar(11) not null unique,
	idade varchar(3) not null,
	cargo varchar(250) not null,
	id_hospital int
	
);
go

create table hospitais (

	idhospital int identity,
	local_unidade text not null,

);
go

create table doutores (

	iddoutor int identity,
	nomedoutor varchar(250) not null,
	doutorado varchar(60) not null,
	salario money not null,
	telefone_doc varchar(20) not null,
	id_hospital int
	
); 
go

create table consultas (

	idconsulta int identity,
	id_hospital int,
	id_doutor int,
	id_paciente int,

	tipo_exame text,
	data_exame date,
	regra text,

);
go

--Primary keys

alter table pacientes add constraint pk_pacientes
primary key (idpaciente)
go

alter table funcionarios add constraint pk_funcionarios
primary key (idfuncionario)
go

alter table doutores add constraint pk_doutores
primary key (iddoutor)
go

alter table hospitais add constraint pk_hospital
primary key (idhospital)
go

alter table consultas add constraint pk_consultas
primary key (idconsulta)
go


--Foreign Keys

alter table doutores add constraint fk_doutor_unidade
foreign key (id_hospital) references hospitais(idhospital)
go

alter table funcionarios add constraint fk_funcionario_unidade
foreign key (id_hospital) references hospitais(idhospital)
go

alter table consultas add constraint fk_consulta_hospital
foreign key (id_hospital) references hospitais(idhospital)
go

alter table consultas add constraint fk_consulta_doutor
foreign key (id_doutor) references doutores(iddoutor)
go

alter table consultas add constraint fk_consulta_paciente
foreign key (id_paciente) references pacientes(idpaciente)