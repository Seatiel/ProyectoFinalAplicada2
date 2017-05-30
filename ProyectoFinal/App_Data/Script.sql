create table Usuarios
(
 UsuarioId int identity(1,1) primary key,
 Nombres varchar(100),
 NombreUsuario varchar(30),
 Clave varchar(16),
 Pin varchar(5),
 TipoUsuarioId int,
 FechaNacimiento datetime,
 Telefono varchar(10)
)

create table Clientes
(
ClienteId int identity(1,1) primary key,
Nombres varchar(60),
Direccion varchar(100),
Telefono varchar(10),
Email varchar(30),
Cedula varchar(30),
FechaRegistro datetime,
)

create table Medicinas
(
MedicinaId int identity(1,1) primary key,
Nombre varchar(30),
CantidadExistencia int,
PrecioVenta money,
PrecioCompra money,
CategoriaId int,
Descripcion varchar(200),
LaboratorioId int

)

Create table TipoUsuarios
(
TipoUsuarioId int identity(1,1) primary key,
Nombre varchar(30)
)

Create table Laboratorios
(
LaboratorioId int identity(1,1) primary key,
Nombre varchar(30)
)

Create table CategoriaMedicinas
(
CategoriaMedicinas int identity(1,1) primary key,
Nombre varchar(30)
)

