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

CREATE TABLE Tipo_Recinto
(
  id_tipo_recinto INT IDENTITY(1,1) NOT NULL,
  nombre_tipo_recinto VARCHAR(50) NOT NULL,
  CONSTRAINT PK_Tipo_Recinto PRIMARY KEY (id_tipo_recinto)
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
  habilitado bit default 1,
  CONSTRAINT PK_Recinto PRIMARY KEY (nro_recinto),
  CONSTRAINT FK_Recinto_Tipo_Recinto FOREIGN KEY (id_tipo_recinto) REFERENCES Tipo_Recinto(id_tipo_recinto)
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
  CONSTRAINT PK_Pago PRIMARY KEY (id_pago),
  CONSTRAINT FK_Pago_Reserva FOREIGN KEY (id_reserva) REFERENCES Reserva(id_reserva)
);

insert into Tipo_Recinto(nombre_tipo_recinto) values ('cancha de futbol');
insert into Tipo_Recinto(nombre_tipo_recinto) values ('cancha de padel');
insert into Tipo_Recinto(nombre_tipo_recinto) values ('parrilla');
insert into Tipo_Recinto(nombre_tipo_recinto) values ('pileta de natacion');


insert into Tipo_Usuario (nombre_Tipo) values ('Administrador'), ('Recepcionista');
select * from Tipo_Usuario

insert into Usuario (DNI_Usuario,Nombre_Usuario,Apellido_Usuario,Fecha_Ingreso,Fecha_Nacimiento,pass,telefono,Id_Tipo,Sexo_Usuario) values
(1234,'Milton','admin','2021-06-15','2021-06-15','admin','3794149452',2,'hombre'),

(43822713,'Lucas','Scherf','2021-08-09','2001-12-19','admin','3794149452',1,'hombre');

insert into Usuario (DNI_Usuario,Nombre_Usuario,Apellido_Usuario,Fecha_Ingreso,Fecha_Nacimiento,pass,telefono,Id_Tipo,Sexo_Usuario) values
(42450489,'Fernando','Romero','2021-06-15','2021-06-15','recep','3794149452',2,'hombre');

select * from usuario;

--creacion de procedimientos almacenados
-- Agregar recinto
GO
CREATE OR ALTER PROCEDURE sp_AgregarRecinto
    @nro_recinto INT,
    @tarifa_hora FLOAT,
    @ubicacion_recinto VARCHAR(200),
    @id_tipo_recinto INT
AS
BEGIN
    INSERT INTO Recinto (nro_recinto, tarifa_hora, ubicacion_recinto, id_tipo_recinto)
    VALUES (@nro_recinto, @tarifa_hora, @ubicacion_recinto, @id_tipo_recinto);
END;
GO
-- Obtener todos los recintos
CREATE OR ALTER PROCEDURE sp_ObtenerTodosLosRecintos
AS
BEGIN
    SELECT r.nro_recinto, r.tarifa_hora, r.ubicacion_recinto, r.habilitado,
           t.id_tipo_recinto, t.nombre_tipo_recinto
    FROM Recinto r
    INNER JOIN Tipo_Recinto t ON r.id_tipo_recinto = t.id_tipo_recinto;
END;
GO
-- Obtener recinto por número
CREATE OR ALTER PROCEDURE sp_ObtenerRecintoPorNumero
    @nro_recinto INT
AS
BEGIN
    SELECT r.nro_recinto, r.tarifa_hora, r.ubicacion_recinto, r.habilitado,
           t.id_tipo_recinto, t.nombre_tipo_recinto
    FROM Recinto r
    INNER JOIN Tipo_Recinto t ON r.id_tipo_recinto = t.id_tipo_recinto
    WHERE r.nro_recinto = @nro_recinto;
END;
GO
-- Habilitar recinto
CREATE OR ALTER PROCEDURE sp_HabilitarRecinto
    @nro_recinto INT
AS
BEGIN
    UPDATE Recinto SET habilitado = 1 WHERE nro_recinto = @nro_recinto;
END;
GO
-- Deshabilitar recinto
CREATE OR ALTER PROCEDURE sp_DeshabilitarRecinto
    @nro_recinto INT
AS
BEGIN
    UPDATE Recinto SET habilitado = 0 WHERE nro_recinto = @nro_recinto;
END;
GO
-- Actualizar recinto
CREATE OR ALTER PROCEDURE sp_ActualizarRecinto
    @nro_recinto INT,
    @tarifa_hora FLOAT,
    @ubicacion_recinto VARCHAR(200),
    @id_tipo_recinto INT
AS
BEGIN
    UPDATE Recinto
    SET tarifa_hora = @tarifa_hora,
        ubicacion_recinto = @ubicacion_recinto,
        id_tipo_recinto = @id_tipo_recinto
    WHERE nro_recinto = @nro_recinto;
END;
GO
--Listado de tipos de recinto
CREATE OR ALTER PROCEDURE sp_ListarTiposDeRecinto
AS
BEGIN
    SELECT id_tipo_recinto, nombre_tipo_recinto
    FROM Tipo_Recinto;
END;
GO
--Validacion del inicio de sesion del usuario
CREATE OR ALTER PROCEDURE sp_VerificarUsuarioLogin
    @dni INT,
    @pass NVARCHAR(100)
AS
BEGIN
    SELECT *
    FROM Usuario
    WHERE DNI_Usuario = @dni AND pass = @pass;
END;
go
-- Insertar cliente
CREATE OR ALTER PROCEDURE sp_InsertarCliente
    @dni_cliente INT,
    @nombre_cliente VARCHAR(30),
    @apellido_cliente VARCHAR(30),
    @telefono_cliente VARCHAR(20)
AS
BEGIN
    INSERT INTO Cliente (dni_cliente, nombre_cliente, apellido_cliente, telefono_cliente)
    VALUES (@dni_cliente, @nombre_cliente, @apellido_cliente, @telefono_cliente);
END;
GO

-- Listar todos los clientes
CREATE OR ALTER PROCEDURE sp_ListarClientes
AS
BEGIN
    SELECT * FROM Cliente;
END;
GO

-- Buscar cliente por DNI
CREATE OR ALTER PROCEDURE sp_ObtenerClientePorDNI
    @dni_cliente INT
AS
BEGIN
    SELECT * FROM Cliente WHERE dni_cliente = @dni_cliente;
END;
GO
--agregar nueva reserva
CREATE OR ALTER PROCEDURE sp_InsertarReserva
    @fecha_reserva DATE,
    @id_cliente INT,
    @nro_recinto INT,
    @id_usuario INT,
    @hora_reserva INT
AS
BEGIN
    INSERT INTO Reserva (fecha_reserva, id_cliente, nro_recinto, id_usuario, hora_reserva)
    VALUES (@fecha_reserva, @id_cliente, @nro_recinto, @id_usuario, @hora_reserva);
END;
GO

-- Listar reservas con respectivos clientes y usuarios
CREATE OR ALTER PROCEDURE sp_ListarReservas
AS
BEGIN
    SELECT 
        r.id_reserva,
        r.fecha_reserva,
        r.hora_reserva,
        r.pagado,
        r.nro_recinto,
        r.id_cliente,
        r.id_usuario,
        c.nombre_cliente,
        c.apellido_cliente,
        u.Nombre_Usuario AS nombre_usuario,
        u.Apellido_Usuario AS apellido_usuario
    FROM Reserva r
    INNER JOIN Cliente c ON r.id_cliente = c.id_cliente
    INNER JOIN Usuario u ON r.id_Usuario = u.id_Usuario;
END;
GO

--lista de horas ya reservadas para la fecha y recinto seleccionados
CREATE OR ALTER PROCEDURE sp_HorasReservadas
    @nro_recinto INT,
    @fecha_reserva DATE
AS
BEGIN
    SELECT hora_reserva
    FROM Reserva
    WHERE nro_recinto = @nro_recinto AND fecha_reserva = @fecha_reserva;
END;
GO
