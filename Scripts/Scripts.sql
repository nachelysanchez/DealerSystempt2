ALTER PROCEDURE sp_InsertarUsuarios 
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
