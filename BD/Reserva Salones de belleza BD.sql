--create database Reserva_Salones_de_belleza;
use Reserva_Salones_de_belleza;
create table Productos(
ID_Productos int primary key,
Nombre varchar (50) not null,
Sugerencia_Producto varchar(50) NOT NULL,
Estado varchar(50) NOT NUll,);

create table Profesional(
ID_Profesional int primary key,
Nombre  varchar(50) NOT NULL,
Apellido varchar(50) NOT NULL,
Telefono varchar (50) NOT NULL,
Horarios  varchar (50) not null,);

create table Clientes (
ID_Cliente int primary key,
Nombre varchar(50) NOT NULL,
Apellido varchar(50) NOT NULL,
Ciudad varchar(50) NOT NULL,
Direccion varchar(50) NOT NULL,
Telefono int NOT NULL,
Correo varchar(50) NOT NULL,
Fecha_de_nacimiento Date  NOT NULL,
Edad int NOT NULL,
Correo_Electronico varchar(50) NOT NULL,);

create table Sede (
ID_Sede int primary key,
Ciudad varchar (50) NOT NULL,
Direccion varchar (50) NOT NULL,
Horario_apertura time NOT NULL,
Horario_cierre time NOT NULL,);

create table Reservas (
ID_Reservas int primary key,
Tipo_Servicio varchar (50) NOT NULL,
Horareserva time  NOT NULL,
Fecha_Reserva date not null,
Tipo_cliente  varchar (50) NOT NULL,
Preferencia varchar (100) NOT NULL,
Seleccion_Producto varchar (100) NOT NULL,
ID_Cliente int,
ID_Sede int,
FOREIGN KEY (ID_Cliente) REFERENCES Clientes (ID_Cliente),
FOREIGN KEY (ID_Sede) REFERENCES Sede (ID_Sede),);

create table Reservas_Profesional(
ID_ReservasProfesional int primary key,
ID_Reservas int,
ID_Profesional int,
FOREIGN KEY (ID_Reservas) REFERENCES Reservas (ID_Reservas),
FOREIGN KEY (ID_Profesional) REFERENCES Profesional (ID_Profesional),);

create table Productos_Reservas (
ID_ProductosReservas int primary key,
ID_Reservas int,
ID_Productos int,
FOREIGN KEY (ID_Reservas) REFERENCES Reservas (ID_Reservas),
FOREIGN KEY (ID_Productos) REFERENCES Productos (ID_Productos),);


create table Opinion (
ID_Opinion int primary key,
Opinion_General varchar not null,
ID_Reservas int,
FOREIGN KEY (ID_Reservas) REFERENCES Reservas (ID_Reservas),);

