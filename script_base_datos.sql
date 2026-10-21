/* =====================================================================
   Segundo Parcial - Programación Computacional I
   Ejecutar en SQL Server Management Studio con un usuario administrador
   (autenticación de Windows o sa).
   ===================================================================== */

-- 1) Base de datos
IF DB_ID('bd_parcial2') IS NULL
    CREATE DATABASE bd_parcial2;
GO

-- 2) Login de SQL Server: usuario "red" / clave "redugb"
IF NOT EXISTS (SELECT 1 FROM sys.server_principals WHERE name = 'red')
    CREATE LOGIN red WITH PASSWORD = 'redugb', CHECK_POLICY = OFF;
GO

USE bd_parcial2;
GO

IF USER_ID('red') IS NULL
    CREATE USER red FOR LOGIN red;
GO
ALTER ROLE db_owner ADD MEMBER red;
GO

-- 3) Tabla de usuarios
IF OBJECT_ID('dbo.usuarios_usss008426', 'U') IS NULL
BEGIN
    CREATE TABLE dbo.usuarios_usss008426
    (
        idUsuario  INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
        usuario    VARCHAR(35) NOT NULL,
        clave      VARCHAR(35) NOT NULL,
        nombre     VARCHAR(65) NOT NULL,
        direccion  VARCHAR(85) NULL,
        telefono   VARCHAR(9)  NULL
    );
END
GO

-- 4) Tres registros de ejemplo
IF NOT EXISTS (SELECT 1 FROM dbo.usuarios_usss008426)
BEGIN
    INSERT INTO dbo.usuarios_usss008426 (usuario, clave, nombre, direccion, telefono) VALUES
    ('administrador', 'admin2026', 'Administrador del Sistema', 'Usulutan, El Salvador', '2662-0001'),
    ('jperez2026',    'clave1234', 'Juan Perez',                'San Miguel',             '7000-1111'),
    ('mlopez2026',    'clave5678', 'Maria Lopez',               'Santiago de Maria',      '7000-2222');
END
GO

SELECT * FROM dbo.usuarios_usss008426;
GO
