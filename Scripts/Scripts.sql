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

CREATE PROCEDURE sp_ActualizarExistenciaAccesorio
@AccesorioId int,
@Existencia int
AS
	UPDATE Accesorios SET Existencia = @Existencia WHERE AccesorioId = @AccesorioId
GO

ALTER TABLE dbo.Vehiculos 
ADD Existencia int default 0
GO
ALTER TABLE dbo.Vehiculos  DROP COLUMN CantidadDisponible
GO
ALTER PROCEDURE sp_ActualizarExistenciaVehiculo
@VehiculoId int,
@Existencia int
AS
	UPDATE Vehiculos SET Existencia = @Existencia WHERE VehiculoId = @VehiculoId
GO

CREATE TABLE eComprasVehiculos
(
	CompraId INTEGER PRIMARY KEY IDENTITY(1,1),
	Fecha DATETIME,
	Tipo INT,
	SuplidorId INTEGER FOREIGN KEY REFERENCES Suplidores(SuplidorId),
	ITBIS decimal,
	SubTotal decimal,
	Descuento decimal,
	Total decimal,
	Balance decimal
)
CREATE TABLE dComprasVehiculos
(
	Id INTEGER PRIMARY KEY IDENTITY(1,1),
	CompraId INTEGER FOREIGN KEY REFERENCES dbo.eComprasVehiculos(CompraId),
	VahiculoId INTEGER FOREIGN KEY REFERENCES Vehiculos(VehiculoId),
	Descripcion varchar(100),
	Cantidad int,
	Precio decimal,
	Importe decimal
)
GO

CREATE PROCEDURE sp_BuscareComprasVehiculos
@CompraId INT
AS
	SELECT *
	FROM dbo.eComprasVehiculos 
	WHERE CompraId = @CompraId
GO
GO



CREATE PROCEDURE sp_BuscardCompraVehiculos
@CompraId INT
AS
	SELECT *
	FROM dbo.dComprasVehiculos
	WHERE CompraId = @CompraId
GO
GO



CREATE PROCEDURE sp_InsertareCompraVehiculo
@Fecha DATETIME, 
@Tipo int, 
@SuplidorId int, 
@ITBIS decimal, 
@SubTotal decimal,
@Descuento decimal,
@Total decimal,
@Balance decimal
AS
	INSERT INTO dbo.eComprasVehiculos
	VALUES (@Fecha,@Tipo,@SuplidorId,@ITBIS,@SubTotal,@Descuento,@Total,@Balance)
GO
GO

CREATE PROCEDURE sp_InsertardComprasVehiculo
@CompraId int, 
@VehiculoId int, 
@Descripcion varchar(100),
@Cantidad int, 
@Precio decimal, 
@Importe decimal
AS
	INSERT INTO dbo.dComprasVehiculos
	VALUES (@CompraId,@VehiculoId,@Descripcion,@Cantidad,@Precio,@Importe)

	EXEC sp_ActualizarExistenciaVehiculo @VehiculoId, @Cantidad 
GO
GO

ALTER PROCEDURE sp_EliminareComprasVehiculos
@Id int
AS
	DELETE FROM dbo.eComprasVehiculos WHERE CompraId = @Id
	EXEC sp_EliminardComprasVehiculos @Id
GO
GO

CREATE PROCEDURE sp_EliminardComprasVehiculos
@Id int
AS
	DELETE FROM dbo.dComprasVehiculos WHERE CompraId = @Id
GO
GO

CREATE TABLE eComprasVehiculos
(
	CompraId INTEGER PRIMARY KEY IDENTITY(1,1),
	Fecha DATETIME,
	Tipo INT,
	SuplidorId INTEGER FOREIGN KEY REFERENCES Suplidores(SuplidorId),
	ITBIS decimal,
	SubTotal decimal,
	Descuento decimal,
	Total decimal,
	Balance decimal
)
DROP TABLE dComprasAccesorios
SELECT * FROM dComprasVehiculos
CREATE TABLE dComprasVehiculos
(
	Id INTEGER PRIMARY KEY IDENTITY(1,1),
	CompraId INTEGER FOREIGN KEY REFERENCES dbo.eComprasVehiculos(CompraId),
	VahiculoId INTEGER FOREIGN KEY REFERENCES Vehiculos(VehiculoId),
	Descripcion varchar(100),
	Cantidad int,
	Precio decimal,
	Importe decimal
)

ALTER TABLE dbo.Vehiculos 
ADD Existencia int default 0

ALTER TABLE dbo.Vehiculos  DROP COLUMN CantidadDisponible


go
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

CREATE PROCEDURE sp_ActualizarExistenciaVehiculoInsertVenta
@VehiculoId int,
@Existencia int
AS
	DECLARE @Cantidad int 
	SELECT @Cantidad = Existencia FROM Vehiculos WHERE VehiculoId = @VehiculoId
	UPDATE Vehiculos SET Existencia = (@Cantidad + @Existencia) WHERE VehiculoId = @VehiculoId
GO

ALTER PROCEDURE sp_ActualizarExistenciaAccesoriosInsertVenta
@AccesorioId int,
@Existencia int
AS
	DECLARE @Cantidad int 
	SELECT @Cantidad = Existencia FROM Accesorios WHERE AccesorioId = @AccesorioId
	UPDATE Accesorios SET Existencia = (@Cantidad - @Existencia) WHERE AccesorioId = @AccesorioId
GO

ALTER PROCEDURE sp_InsertardVentaAccesorio
@VentaId int, 
@AccesorioId int, 
@Descripcion varchar(100), 
@Cantidad int, 
@Precio money, 
@Importe money
AS
	INSERT INTO dbo.dVentasAccesorios 
	VALUES (@VentaId, @AccesorioId, @Descripcion, @Cantidad, @Precio, @Importe)

	EXEC sp_ActualizarExistenciaAccesoriosInsertVenta @AccesorioId, @Cantidad
GO

ALTER PROCEDURE sp_EliminardVentaAccesorio
@Id int
AS
	DECLARE @Cantidad int 
	SELECT @Cantidad = COUNT(VentaId) FROM dVentasAccesorios WHERE VentaId = @Id

	WHILE (@Cantidad != 0)
	BEGIN
		DECLARE @Accesorio int, @Existencia int
		SELECT @Accesorio = AccesorioId  FROM dVentasAccesorios WHERE VentaId = @Id
		SELECT @Existencia = Cantidad FROM dVentasAccesorios WHERE VentaId = @Id
		EXEC sp_ActualizarExistenciaAccesoriosDeleteVenta @Accesorio, @Existencia
		SET @Cantidad = @Cantidad - 1
	END

	DELETE FROM dbo.dVentasAccesorios WHERE VentaId = @Id
	
GO

ALTER PROCEDURE sp_ActualizarExistenciaAccesoriosDeleteVenta
@AccesorioId int,
@Existencia int
AS
	DECLARE @Cantidad int 
	SELECT @Cantidad = Existencia FROM Accesorios WHERE AccesorioId = @AccesorioId
	UPDATE Accesorios SET Existencia = (@Cantidad + @Existencia) WHERE AccesorioId = @AccesorioId
GO

ALTER PROCEDURE [dbo].[sp_EliminareVentaAccesorio]
@Id int
AS
	EXEC sp_EliminardVentaAccesorio @Id
	DELETE FROM dbo.eVentasAccesorios WHERE VentaId = @Id
GO

create PROCEDURE sp_ActualizarExistenciaVehiculoDeleteVenta
@VehiculoId int,
@Existencia int
AS
	DECLARE @Cantidad int 
	SELECT @Cantidad = Existencia FROM Vehiculos WHERE VehiculoId = @VehiculoId
	UPDATE Vehiculos SET Existencia = (@Cantidad + @Existencia) WHERE VehiculoId = @VehiculoId
GO

ALTER PROCEDURE [dbo].[sp_EliminarDVentas]
@Id int
AS
	DECLARE @Cantidad int 
	SELECT @Cantidad = COUNT(VentaId) FROM dVentas WHERE VentaId = @Id

	WHILE (@Cantidad != 0)
	BEGIN
		DECLARE @Accesorio int, @Existencia int
		SELECT @Accesorio = VehiculoId FROM dVentas WHERE VentaId = @Id
		SELECT @Existencia = Cantidad FROM dVentas WHERE VentaId = @Id
		EXEC sp_ActualizarExistenciaVehiculoDeleteVenta @Accesorio, @Existencia
		SET @Cantidad = @Cantidad - 1
	END

	DELETE FROM dbo.dVentas WHERE VentaId = @Id
GO

ALTER PROCEDURE sp_ActualizarExistenciaVehiculoInsertVenta
@VehiculoId int,
@Existencia int
AS
	DECLARE @Cantidad int 
	SELECT @Cantidad = Existencia FROM Vehiculos WHERE VehiculoId = @VehiculoId
	UPDATE Vehiculos SET Existencia = (@Cantidad - @Existencia) WHERE VehiculoId = @VehiculoId
GO


ALTER PROCEDURE [dbo].[sp_InsertarDVenta]
@VentaId int, 
@VehiculoId int, 
@Cantidad decimal, 
@Precio decimal, 
@ITBIS decimal, 
@Importe decimal
AS
	INSERT INTO dbo.dVentas(VentaId,VehiculoId,Cantidad,Precio,ITBIS,Importe) 
	VALUES (@VentaId,@VehiculoId,@Cantidad,@Precio,@ITBIS,@Importe)

	EXEC sp_ActualizarExistenciaVehiculoInsertVenta @VehiculoId, @Cantidad
GO

ALTER PROCEDURE sp_ConsultarClientes
@Filtro int, @Criterio varchar(max)
AS
	if(@Filtro = '1')
		SELECT * FROM Clientes WHERe ClienteId = @Criterio 
	else if (@Filtro = '2')
		SELECT * FROM Clientes WHERE Nombres like '%'+@Criterio+'%'
	else if (@Filtro = '0')
		SELECT * FROM Clientes
GO

CREATE PROCEDURE sp_ConsultarAccesorios
@Filtro int, @Criterio varchar(max)
AS
	if(@Filtro = '1')
		SELECT * FROM Accesorios WHERe AccesorioId = @Criterio 
	else if (@Filtro = '2')
		SELECT * FROM Accesorios WHERE Nombre like '%'+@Criterio+'%'
	else if (@Filtro = '0')
		SELECT * FROM Accesorios
GO

CREATE PROCEDURE sp_ConsultarComprasVehiculos
@Filtro int, @Criterio varchar(max)
AS
	if(@Filtro = '1')
		SELECT * FROM dbo.eComprasVehiculos WHERe CompraId = @Criterio 
	else if (@Filtro = '2')
		SELECT * FROM dbo.eComprasVehiculos WHERE SuplidorId = @Criterio
	else if (@Filtro = '0')
		SELECT * FROM dbo.eComprasVehiculos
GO

CREATE PROCEDURE sp_ConsultarSuplidores
@Filtro int, @Criterio varchar(max)
AS
	if(@Filtro = '1')
		SELECT * FROM dbo.Suplidores WHERe SuplidorId = @Criterio 
	else if (@Filtro = '2')
		SELECT * FROM dbo.Suplidores WHERE Nombre like  '%'+@Criterio+'%'
	else if (@Filtro = '0')
		SELECT * FROM dbo.Suplidores
GO

CREATE PROCEDURE sp_ConsultarVehiculos
@Filtro int, @Criterio varchar(max)
AS
	if(@Filtro = '1')
		SELECT * FROM dbo.Vehiculos WHERe VehiculoId = @Criterio 
	else if (@Filtro = '2')
		SELECT * FROM dbo.Vehiculos WHERE Modelo like  '%'+@Criterio+'%'
	else if (@Filtro = '0')
		SELECT * FROM dbo.Vehiculos
GO