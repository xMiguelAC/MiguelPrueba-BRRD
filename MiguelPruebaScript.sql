CREATE DATABASE MiguelPrueba

CREATE TABLE Persona (
	ID int primary key identity(1,1),
	Nombre varchar(40) not null,
	FechaDeNacimiento date not null
)