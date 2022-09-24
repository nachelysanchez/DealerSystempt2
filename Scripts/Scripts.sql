CREATE PROCEDURE sp_InsertarUsuarios 
@Id int, @Nombre varchar(100), @Usuario varchar(100), @Pass varchar(max), @tipo int, @activo bit
AS
	INSERT INTO dbo.Usuarios VALUES (@Nombre, @Usuario, @Pass, @tipo, @activo)
GO

CREATE PROCEDURE sp_ModificarUsuarios 
@Id int, @Nombre varchar(100), @Usuario varchar(100), @Pass varchar(max), @tipo int, @activo bit
AS
	UPDATE dbo.Usuarios SET Nombre = @Nombre, Usuario = @Usuario, Pass = @Pass, Tipo = @tipo, Estado = @activo WHERE ID = @Id
GO

CREATE PROCEDURE sp_EliminarUsuarios 
@Id int
AS
	DELETE FROM dbo.Usuarios WHERE ID = @Id
GO

CREATE PROCEDURE sp_BuscarUsuarios
@Id int
AS
	SELECT * FROM dbo.Usuarios WHERE ID = @Id
GO


--Brian Jimenez 24/09/2022
CREATE PROCEDURE sp_BuscarCliente 
@ClienteId INT
AS
	SELECT ClienteId,Nombres,Apellidos,Cedula,Telefono,Celular,Ocupacion
	FROM dbo.Clientes WHERE ClienteId = @ClienteId
GO
GO

CREATE PROCEDURE sp_InsertarCliente 
@Id int, 
@Nombres varchar(100), 
@Apellidos varchar(100), 
@Cedula varchar(15), 
@Telefono varchar(15), 
@Celular varchar(15),
@Ocupacion varchar(30)
AS
	INSERT INTO dbo.Clientes(ClienteId,Nombres,Apellidos,Cedula,Telefono,Celular,Ocupacion) 
	VALUES (@Id, @Nombres, @Apellidos, @Cedula, @Telefono,@Celular,@Ocupacion)
GO
GO

CREATE PROCEDURE sp_ModificarCliente 
@Id int, 
@Nombres varchar(100), 
@Apellidos varchar(100), 
@Cedula varchar(15), 
@Telefono varchar(15), 
@Celular varchar(15),
@Ocupacion varchar(30)
AS
	UPDATE dbo.Clientes 
	SET Nombres = @Nombres,Apellidos = @Apellidos,Cedula = @Cedula,Telefono = @Telefono,Celular = @Celular,Ocupacion = @Ocupacion
	WHERE ClienteId = @Id
GO
GO

CREATE PROCEDURE sp_EliminarCliente 
@Id int
AS
	DELETE FROM dbo.Clientes WHERE ClienteId = @Id
GO
GO

CREATE TABLE eVentas
(
	VentaId INTEGER PRIMARY KEY IDENTITY(1,1),
	Fecha DATETIME,
	Tipo INT,
	ClienteId INTEGER FOREIGN KEY REFERENCES Clientes(ClienteId),
	ITBIS decimal,
	SubTotal decimal,
	Total decimal,
	Balance decimal
);
GO
CREATE TABLE dVentas
(
	Id INTEGER PRIMARY KEY IDENTITY(1,1),
	VentaId INTEGER FOREIGN KEY REFERENCES eVentas(VentaId),
	VehiculoId INTEGER FOREIGN KEY REFERENCES Vehiculos(VehiculoId),
	Precio decimal,
	ITBIS decimal,
	Importe decimal
);

--Nachely Sanchez : 24/9/2022
CREATE TABLE Suplidores
(
	SuplidorId int primary key identity(1,1),
	Nombre varchar(200),
	Empresa varchar(200),
	Telefono varchar(17),
	Correo varchar(max),
	Observaciones varchar(max)
)


CREATE PROCEDURE sp_InsertarSuplidor
@Nombre varchar(200), 
@Empresa varchar(200), 
@Telefono varchar(max), 
@Correo varchar(max), 
@Observaciones varchar(max)
AS
	INSERT INTO dbo.Suplidores VALUES (@Nombre, @Empresa, @Telefono, @Correo, @Observaciones)
GO

CREATE PROCEDURE sp_ModificarSuplidor
@Id int, 
@Nombre varchar(200), 
@Empresa varchar(200), 
@Telefono varchar(max), 
@Correo varchar(max), 
@Observaciones varchar(max)
AS
	UPDATE dbo.Suplidores 
		SET Nombre = @Nombre, 
		Empresa = @Empresa, 
		Telefono = @Telefono, 
		Correo = @Correo, 
		Observaciones = @Observaciones 
	WHERE SuplidorId = @Id
GO

CREATE PROCEDURE sp_EliminarSuplidor
@Id int
AS
	DELETE FROM dbo.Suplidores WHERE SuplidorId = @Id
GO

CREATE PROCEDURE sp_BuscarSuplidor
@Id int
AS
	SELECT * FROM dbo.Suplidores WHERE SuplidorId = @Id
GO
