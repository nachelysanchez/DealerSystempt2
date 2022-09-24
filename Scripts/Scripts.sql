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