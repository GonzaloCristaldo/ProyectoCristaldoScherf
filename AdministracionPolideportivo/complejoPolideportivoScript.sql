create database complejoPolideportivoProd;

USE complejoPolideportivoProd;

CREATE TABLE Cliente
(
  id_cliente INT IDENTITY(1,1) NOT NULL,
  dni_cliente INT NOT NULL,
  nombre_cliente VARCHAR(30) NOT NULL,
  apellido_cliente VARCHAR(30) NOT NULL,
  telefono_cliente VARCHAR(20) NOT NULL,
  CONSTRAINT PK_Cliente PRIMARY KEY (id_cliente),
  CONSTRAINT UQ_Cliente UNIQUE (dni_cliente)
);

CREATE TABLE Medio_Pago
(
  id_medio INT IDENTITY(1,1) NOT NULL,
  nombre_medio VARCHAR(40) NOT NULL,
  CONSTRAINT PK_Medio_Pago PRIMARY KEY (id_medio)
);

CREATE TABLE Tipo_Recinto
(
  id_tipo_recinto INT IDENTITY(1,1) NOT NULL,
  nombre_tipo_recinto VARCHAR(50) NOT NULL,
  CONSTRAINT PK_Tipo_Recinto PRIMARY KEY (id_tipo_recinto)
);

CREATE TABLE Estado
(
  id_estado INT IDENTITY(1,1) NOT NULL,
  nombre_estado VARCHAR(50) NOT NULL,
  CONSTRAINT PK_Estado PRIMARY KEY (id_estado)
);

CREATE TABLE Servicio_Adicional
(
  id_servicio INT IDENTITY(1,1) NOT NULL,
  nombre_servicio VARCHAR(50) NOT NULL,
  descripcion_servicio VARCHAR(500) NOT NULL,
  precio decimal(18,2) NOT NULL,
  CONSTRAINT PK_Servicio_Adicional PRIMARY KEY (id_servicio)
);

CREATE TABLE Tipo_Usuario
(
  Id_Tipo INT IDENTITY(1,1) NOT NULL,
  nombre_Tipo VARCHAR(30) NOT NULL,
  CONSTRAINT PK_Tipo_Usuario PRIMARY KEY (Id_Tipo)
);

CREATE TABLE Recinto
(
  nro_recinto INT NOT NULL,
  tarifa_hora FLOAT NOT NULL,
  ubicacion_recinto VARCHAR(200) NOT NULL,
  id_tipo_recinto INT NOT NULL,
  id_estado INT NOT NULL,
  CONSTRAINT PK_Recinto PRIMARY KEY (nro_recinto),
  CONSTRAINT FK_Recinto_Tipo_Recinto FOREIGN KEY (id_tipo_recinto) REFERENCES Tipo_Recinto(id_tipo_recinto),
  CONSTRAINT FK_Recinto_Estado FOREIGN KEY (id_estado) REFERENCES Estado(id_estado)
);

CREATE TABLE Recinto_Servicio
(
  nro_recinto INT NOT NULL,
  id_servicio INT NOT NULL,
  CONSTRAINT PK_Recinto_Servicio PRIMARY KEY (nro_recinto, id_servicio),
  CONSTRAINT FK_Recinto_Servicio_Recinto FOREIGN KEY (nro_recinto) REFERENCES Recinto(nro_recinto),
  CONSTRAINT FK_Recinto_Servicio_Servicio FOREIGN KEY (id_servicio) REFERENCES Servicio_Adicional(id_servicio)
);

CREATE TABLE Usuario
(
  id_Usuario INT IDENTITY(1,1) NOT NULL,
  DNI_Usuario INT NOT NULL,
  foto_usuario VARBINARY(MAX),
  Nombre_Usuario VARCHAR(30) NOT NULL,
  Apellido_Usuario VARCHAR(30) NOT NULL,
  Fecha_Ingreso DATE NOT NULL,
  Fecha_Nacimiento DATE NOT NULL,
  pass VARCHAR(50) NOT NULL,
  telefono VARCHAR(30) NOT NULL,
  Id_Tipo INT NOT NULL,
  Sexo_Usuario VARCHAR(40) NOT NULL,
  CONSTRAINT PK_Usuario PRIMARY KEY (id_Usuario),
  CONSTRAINT FK_Usuario_Tipo_Usuario FOREIGN KEY (Id_Tipo) REFERENCES Tipo_Usuario(Id_Tipo),
  Constraint UQ_Usuario UNIQUE (DNI_Usuario)
);

CREATE TABLE Reserva
(
  id_reserva INT IDENTITY(1,1) NOT NULL,
  fecha_reserva DATE NOT NULL,
  id_cliente INT NOT NULL,
  nro_recinto INT NOT NULL,
  id_Usuario INT NOT NULL,
  hora_reserva INT NOT NULL,
  pagado bit DEFAULT 0,
  CONSTRAINT PK_Reserva PRIMARY KEY (id_reserva),
  CONSTRAINT FK_Reserva_Cliente FOREIGN KEY (id_cliente) REFERENCES Cliente(id_cliente),
  CONSTRAINT FK_Reserva_Recinto FOREIGN KEY (nro_recinto) REFERENCES Recinto(nro_recinto),
  CONSTRAINT FK_Reserva_Usuario FOREIGN KEY (id_Usuario) REFERENCES Usuario(id_Usuario),
  CONSTRAINT CK_Reserva_Hora CHECK(hora_reserva > 0 and hora_reserva<=24)
);

CREATE TABLE Pago
(
  id_pago INT IDENTITY(1,1) NOT NULL,
  id_reserva INT NOT NULL,
  id_usuario INT NOT NULL,
  monto INT NOT NULL,
  id_medio INT NOT NULL,
  CONSTRAINT PK_Pago PRIMARY KEY (id_pago),
  CONSTRAINT FK_Pago_Reserva FOREIGN KEY (id_reserva) REFERENCES Reserva(id_reserva)
);

CREATE TABLE Servicio_Reserva
(
  id_servicio INT NOT NULL,
  id_reserva INT NOT NULL,
  CONSTRAINT PK_Servicio_Reserva PRIMARY KEY (id_servicio, id_reserva),
  CONSTRAINT FK_Servicio_Reserva_Servicio FOREIGN KEY (id_servicio) REFERENCES Servicio_Adicional(id_servicio),
  CONSTRAINT FK_Servicio_Reserva_Reserva FOREIGN KEY (id_reserva) REFERENCES Reserva(id_reserva)
);

insert into Tipo_Usuario (nombre_Tipo) values ('Administrador'), ('SuperAdministrador'), ('Recepcionista');

select * from Tipo_Usuario;

insert into Usuario (DNI_Usuario,Nombre_Usuario,Apellido_Usuario,Fecha_Ingreso,Fecha_Nacimiento,pass,telefono,Id_Tipo,Sexo_Usuario) values
(1234,'Milton','admin','2021-06-15','2021-06-15','admin','3794149452',1,'hombre'),
(12345,'Maria','superadmin','2021-06-15','2021-06-15','superadmin','3794149452',2,'mujer'),
(43822713,'Lucas','Scherf','2021-08-09','2001-12-19','superadmin','3794149452',2,'hombre'),
(43123456,'Martin','Lopez','2018-10-24','1992-06-15','admin','3794149452',2,'hombre'),
(12346,'recep','recep','2021-06-15','2021-06-15','recep','3794149452',3,'hombre');

select * from Usuario;

insert into Tipo_Recinto(nombre_tipo_recinto) values ('cancha de futbol');
insert into Tipo_Recinto(nombre_tipo_recinto) values ('cancha de padel');
insert into Tipo_Recinto(nombre_tipo_recinto) values ('parrilla');
insert into Tipo_Recinto(nombre_tipo_recinto) values ('pileta de natacion');


insert into Estado(nombre_estado) VALUES ('funcionando'), ('deshabilitado');

insert into Medio_Pago(nombre_medio) VALUES ('efectivo'), ('transferencia'),('debito/credito');

insert into Cliente(dni_cliente,nombre_cliente,apellido_cliente,telefono_cliente)
VALUES (38765123,'Jose','Martinez','379414942'),
(35245123,'Maria','Echeverría','379564215'),
(32365123,'Milton','Rodriguez','379149432'),
(35248723,'paula','Santillan','379564315'),
(48765123,'Raul','Caceres','379414432'),
(25245123,'Javier','Sandoval','37956325'),
(48765863,'Marcos','Costas','379414932'),
(35869373,'Lucia','Jensen','379564215');


select * from Tipo_Recinto;
insert into Recinto(nro_recinto,tarifa_hora,ubicacion_recinto,id_tipo_recinto,id_estado)
VALUES (1,20000,'Primer cancha a la izquierda',1,1),
(2,30000,'Primer cancha a la derecha',1,1),
(3,24000,'segunda cancha a la izquierda',1,1),
(4,21000,'segunda cancha a la derecha',2,1),
(5,27000,'Primer parrilla al fondo',3,1),
(6,25000,'segunda parrilla al fondo',3,1),
(7,22500,'pileta atras de las parrillas',4,2),
(8,22000,'Primer cancha del frente',1,1),
(9,20000,'Cancha del medio',1,1),
(10,20000,'Cancha zona estacionamiento',1,1),
(11,20000,'Cancha de padel techada zona estacionamiento',2,1),
(12,13000,'parrilla zona central',3,2),
(13,13000,'parrilla sector estacionamiento',3,1),
(14,12000,'pileta de salon climatizada',4,1);

INSERT INTO Servicio_Adicional(nombre_servicio,descripcion_servicio,precio)
VALUES ('Arbitraje de futbol','Servicio de arbitro de partidos de futbol',7000),
('Arbitraje de padel','Servicio de arbitro de padel',5000),
('Grabacion','Servicio de grabación del recinto',2500),
('Iluminación','Iluminación con luces de tecnologia led',4500),
('Pecheras','Alquiler de pecheras de colores para dividir equipos',3500);

INSERT INTO Recinto_Servicio(nro_recinto,id_servicio)
VALUES (1,1),
(1,3),
(1,4),
(1,5),
(2,1),
(2,3),
(2,4),
(2,5),
(3,1),
(3,3),
(3,4),
(3,5),
(4,2),
(4,3),
(4,4),
(5,4),
(6,4);

INSERT INTO reserva(fecha_reserva,id_cliente,nro_recinto,id_Usuario,hora_reserva)
VALUES ('2024-12-15',1,1,1,18),
('2024-11-15',2,2,1,19),
('2024-10-15',3,3,1,20),
('2024-9-15',1,4,1,21),
('2024-8-15',1,5,1,18),
('2024-7-15',3,6,1,19),
('2024-6-15',2,7,1,20),
('2024-5-15',2,8,1,21),
('2024-4-15',1,9,1,18),
('2024-3-15',2,1,1,19),
('2024-2-15',3,1,1,20),
('2024-1-15',3,1,1,21);

INSERT INTO Servicio_Reserva(id_servicio,id_reserva) 
VALUES(1,1),
(3,1),
(4,1),
(5,1);
