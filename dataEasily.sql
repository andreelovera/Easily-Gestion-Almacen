CREATE DATABASE GESTION_ALMACEN
GO
use GESTION_ALMACEN
GO

CREATE TABLE Proveedor
(
	Id int not null primary key identity(1,1),
	Codigo varchar(15) not null unique,
	Nombre varchar(250) not null ,
	Descripcion varchar(250) not null ,
	Correo varchar(80) not null,
	Celular int   not null,
	Estado bit not null default 1 
)
GO

CREATE TABLE Marca
(
	Id int not null primary key identity(1,1),
	IdProveedor int not null,
	Codigo varchar(15) not null unique,
	Nombre varchar(250) not null,
	Estado bit not null default 1 
)
GO
ALTER TABLE Marca
ADD CONSTRAINT FK_Proveedor_Marca FOREIGN KEY (IdProveedor)
      REFERENCES Proveedor(Id)
GO


CREATE TABLE Categoria 
(
	Id int not null primary key identity(1,1),
	Codigo varchar(15)not null unique ,
	Nombre varchar(250) not null ,
	Estado bit not null default 1 
)

CREATE TABLE Producto
(
	Id int not null primary key identity(1,1),
	IdMarca int not null,
	IdCategoria int not null ,
	Codigo varchar(15)not null unique,
	Nombre varchar(250) not null , 
	Precio decimal(12,4)not null ,
	Stock  decimal(12,2)  not null,
	FechaCreacion datetime default getdate() not null ,
	FechaStock datetime default getdate() not null ,
	Estado bit not null default 1 
)
GO
ALTER TABLE Producto
ADD CONSTRAINT FK_Marca_Producto FOREIGN KEY (IdMarca)
      REFERENCES Marca(Id)
GO
ALTER TABLE Producto
ADD CONSTRAINT FK_Categoria_Producto FOREIGN KEY (IdCategoria)
      REFERENCES Categoria(Id)
GO

/*-----------------DATA-------------------------*/

/*
PROVEEDOR
*/

insert into Proveedor(Codigo, Nombre ,Descripcion , Correo , Celular , Estado )values ('PR001' ,'Lux' , 'Proveedor de productos tecnologicos' , 'Lux@gmail.com' , 993444768 , 1)
select * from Proveedor

/*
MARCA
*/

insert into Marca(IdProveedor , Codigo , Nombre , Estado) values(1 , 'MA001' , 'APPLE' , 1)
insert into Marca(IdProveedor , Codigo , Nombre , Estado) values(1 , 'MA002' , 'XIAOMI' , 1)
insert into Marca(IdProveedor , Codigo , Nombre , Estado) values(1 , 'MA003' , 'AOC' , 1)
insert into Marca(IdProveedor , Codigo , Nombre , Estado) values(1 , 'MA004' , 'SAMSUNG' , 1)
select * from Marca

/*
CATEGORIA
*/

insert into Categoria(Codigo , Nombre , Estado) values('CA001' ,'EQUIPOS' , 1 )
insert into Categoria(Codigo , Nombre , Estado) values('CA002' ,'MONITORES' , 1 )
insert into Categoria(Codigo , Nombre , Estado) values('CA003' ,'TABLET' , 1 )
select * from  Categoria

/*
PRODUCTO
*/

insert into Producto(IdMarca , IdCategoria , Codigo , Nombre , Precio ,Stock) values(1 ,1 ,'PRO001', 'IPHONE 10' , 5250.12 ,10.0)

insert into Producto(IdMarca , IdCategoria , Codigo , Nombre , Precio ,Stock) values(3 ,2 ,'PRO002', 'MONITOR 4K CURVO 120MHZ' , 3024 ,5.0)

insert into Producto(IdMarca , IdCategoria , Codigo , Nombre , Precio ,Stock) values(2 ,1 ,'PRO003', 'REPETIDOR WIFI DUAL BAND' , 69.80 ,100)

insert into Producto(IdMarca , IdCategoria , Codigo , Nombre , Precio ,Stock) values(4 ,3 ,'PRO004', 'GALAXYTAB 8GB RAM 128GB STORAGE' , 99.80 ,100)

select * from Marca
select * from  Categoria
select * from Producto