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
GO

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

CREATE TABLE eVentasAccesorios
(
VentaId int primary key identity(1,1),
ClienteId int FOREIGN KEY REFERENCES Clientes(ClienteId),
Tipo int,
Fecha varchar(100),
Subtotal money,
Itbis money, 
Descuento money,
Total money
)
GO

CREATE PROCEDURE sp_InsertareVentaAccesorio
@ClienteId int, 
@Tipo int, 
@Fecha varchar(100), 
@Subtotal money, 
@Itbis money, 
@Descuento money, 
@Total money
AS
	INSERT INTO dbo.eVentasAccesorios 
	VALUES (@ClienteId, @Tipo, @Fecha, @Subtotal, @Itbis, @Descuento, @Total)
GO

CREATE PROCEDURE sp_ModificareVentaAccesorio
@Id int, 
@ClienteId int, 
@Tipo int, 
@Fecha varchar(100), 
@Subtotal money, 
@Itbis money, 
@Descuento money, 
@Total money
AS
	UPDATE dbo.eVentasAccesorios
		SET ClienteId = @ClienteId, 
		Tipo = @Tipo, 
		Fecha = @Fecha, 
		Subtotal = @Subtotal, 
		Itbis = @Itbis,
		Descuento = @Descuento,
		Total = @Total
	WHERE VentaId = @Id
GO

CREATE PROCEDURE sp_EliminareVentaAccesorio
@Id int
AS
	DELETE FROM dbo.eVentasAccesorios WHERE VentaId = @Id
GO

CREATE PROCEDURE sp_BuscareVentaAccesorio
@Id int
AS
	SELECT * FROM dbo.eVentasAccesorios WHERE VentaId = @Id
GO

--Brian Jimenez 25/09/2022

CREATE TABLE eVentas
(
	VentaId INTEGER PRIMARY KEY IDENTITY(1,1),
	Fecha DATETIME,
	Tipo INT,
	ClienteId INTEGER FOREIGN KEY REFERENCES Clientes(ClienteId),
	ITBIS decimal,
	SubTotal decimal,
	Descuento decimal,
	Total decimal,
	Balance decimal
);

CREATE TABLE dVentas
(
	Id INTEGER PRIMARY KEY IDENTITY(1,1),
	VentaId INTEGER FOREIGN KEY REFERENCES eVentas(VentaId),
	VehiculoId INTEGER FOREIGN KEY REFERENCES Vehiculos(VehiculoId),
	Cantidad decimal,
	Precio decimal,
	ITBIS decimal,
	Importe decimal
);
GO

CREATE PROCEDURE sp_BuscarEVenta
@VentaId INT
AS
	SELECT eV.VentaId,eV.Fecha,eV.Tipo,eV.ClienteId,c.Nombres +' '+ c.Apellidos AS NombreCompleto,eV.ITBIS,eV.SubTotal,eV.Descuento,eV.Total,eV.Balance
	FROM dbo.eVentas eV
	INNER JOIN Clientes c ON eV.ClienteId = c.ClienteId
	WHERE eV.VentaId = @VentaId
GO
GO


ALTER PROCEDURE sp_BuscarDVenta
@VentaId INT
AS
	SELECT dV.VehiculoId,v.Modelo as Descripcion,dV.Cantidad,dV.Precio,dV.ITBIS,dV.Importe
	FROM dbo.dVentas dV
	INNER JOIN Vehiculos v ON dV.VehiculoId = v.VehiculoId
	WHERE dV.VentaId = @VentaId
GO
GO



CREATE PROCEDURE sp_InsertarEVenta
@Fecha DATETIME, 
@Tipo int, 
@ClienteId int, 
@ITBIS decimal, 
@SubTotal decimal,
@Descuento decimal,
@Total decimal,
@Balance decimal
AS
	INSERT INTO dbo.eVentas(Fecha,Tipo,ClienteId,ITBIS,SubTotal,Descuento,Total,Balance) 
	VALUES (@Fecha,@Tipo,@ClienteId,@ITBIS,@SubTotal,@Descuento,@Total,@Balance)
GO
GO

CREATE PROCEDURE sp_InsertarDVenta
@VentaId int, 
@VehiculoId int, 
@Cantidad decimal, 
@Precio decimal, 
@ITBIS decimal, 
@Importe decimal
AS
	INSERT INTO dbo.dVentas(VentaId,VehiculoId,Cantidad,Precio,ITBIS,Importe) 
	VALUES (@VentaId,@VehiculoId,@Cantidad,@Precio,@ITBIS,@Importe)
GO
GO


ALTER PROCEDURE sp_EliminarEVentas
@Id int
AS
	DELETE FROM dbo.eVentas WHERE VentaId = @Id
	EXEC sp_EliminarDVentas @Id
GO
GO

CREATE PROCEDURE sp_EliminarDVentas
@Id int
AS
	DELETE FROM dbo.dVentas WHERE VentaId = @Id
GO
GO

--Nach : 25/9/2022
CREATE PROCEDURE sp_InsertareVentaAccesorio
@ClienteId int, 
@Tipo int, 
@Fecha DATETIME, 
@Subtotal money, 
@Itbis money, 
@Descuento money, 
@Total money
AS
	INSERT INTO dbo.eVentasAccesorios 
	VALUES (@ClienteId, @Tipo, @Fecha, @Subtotal, @Itbis, @Descuento, @Total)
GO

CREATE PROCEDURE sp_ModificareVentaAccesorio
@Id int, 
@ClienteId int, 
@Tipo int, 
@Fecha Datetime, 
@Subtotal money, 
@Itbis money, 
@Descuento money, 
@Total money
AS
	UPDATE dbo.eVentasAccesorios
		SET ClienteId = @ClienteId, 
		Tipo = @Tipo, 
		Fecha = @Fecha, 
		Subtotal = @Subtotal, 
		Itbis = @Itbis,
		Descuento = @Descuento,
		Total = @Total
	WHERE VentaId = @Id
GO

CREATE PROCEDURE sp_EliminareVentaAccesorio
@Id int
AS
	DELETE FROM dbo.eVentasAccesorios WHERE VentaId = @Id
GO

CREATE PROCEDURE sp_BuscareVentaAccesorio
@Id int
AS
	SELECT * FROM dbo.eVentasAccesorios WHERE VentaId = @Id
GO

CREATE TABLE dVentasAccesorios
(
Id int primary key identity(1,1),
VentaId int FOREIGN KEY REFERENCES dbo.eVentasAccesorios(VentaId),
AccesorioId int FOREIGN KEY REFERENCES dbo.Accesorios(AccesorioId),
Descripcion varchar(100),
Cantidad int, 
Precio money,
Importe money
)
GO
CREATE PROCEDURE sp_InsertardVentaAccesorio
@VentaId int, 
@AccesorioId int, 
@Descripcion varchar(100), 
@Cantidad int, 
@Precio money, 
@Importe money
AS
	INSERT INTO dbo.dVentasAccesorios 
	VALUES (@VentaId, @AccesorioId, @Descripcion, @Cantidad, @Precio, @Importe)
GO

ALTER PROCEDURE sp_EliminardVentaAccesorio
@Id int
AS
	DELETE FROM dbo.dVentasAccesorios WHERE VentaId = @Id
GO

CREATE PROCEDURE sp_BuscardVentaAccesorio
@Id int
AS
	SELECT * FROM dbo.dVentasAccesorios WHERE VentaId = @Id
GO