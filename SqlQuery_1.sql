CREATE DATABASE ConfeccionesElCondor;

USE ConfeccionesElCondor;
CREATE TABLE TiposDocumento (
    IdTipoDocumento INT PRIMARY KEY IDENTITY,
    NombreTipo VARCHAR(60) NOT NULL UNIQUE
);

CREATE TABLE Areas (
    IdArea INT PRIMARY KEY IDENTITY	,
    NombreArea VARCHAR(50) NOT NULL UNIQUE
);

CREATE TABLE Empleados (
    IdEmpleado INT PRIMARY KEY IDENTITY,
    IdTipoDocumento INT NOT NULL,
    NumeroDocumento VARCHAR(50) UNIQUE NOT NULL,
    PrimerNombre VARCHAR(100) NOT NULL,
	SegundoNombre VARCHAR(100),
	PrimerApellido VARCHAR(100) NOT NULL,
    SegundoApellido VARCHAR(100),
    FechaNacimiento DATE NOT NULL,
    IdArea INT NOT NULL,
    FOREIGN KEY (IdTipoDocumento) REFERENCES TiposDocumento(IdTipoDocumento),
    FOREIGN KEY (IdArea) REFERENCES Areas(IdArea)
);
DROP TABLE empleados;
INSERT INTO TiposDocumento (NombreTipo) 
VALUES 
('Cédula Ciudadanía'),
('Cédula Extranjería'),
('Pasaporte')

INSERT INTO Areas (NombreArea) 
VALUES 
('Producción'),
('Ventas'),
('Logística'),
('Recursos Humanos'),
('Finanzas'),
('Tecnología');


SELECT * from TiposDocumento;
SELECT * from Areas order by IdArea asc;

--PROCEDIMIENTO DE MOSTRAR INFORMACIÓN

CREATE PROCEDURE MostrarTipoDocumento
AS
SELECT * FROM TiposDocumento;

CREATE PROCEDURE MostrarAreas
AS
SELECT * from Areas order by IdArea asc;

CREATE PROCEDURE cargarEmpleados
AS
SELECT e.IdEmpleado, t.NombreTipo AS 'Tipo Documento', e.NumeroDocumento, e.PrimerNombre, e.SegundoNombre, 
e.PrimerApellido, e.segundoApellido, e.FechaNacimiento, a.NombreArea
FROM empleados e 
INNER JOIN TiposDocumento t ON t.IdTipoDocumento = e.IdTipoDocumento 
INNER JOIN Areas a ON a.IdArea = e.IdArea ;

--------------INSERTAR DATOS EMPLEADO

CREATE PROCEDURE AgregarEmpleados
	@IdTipoDocumento INT,
    @NumeroDocumento VARCHAR(50),
    @PrimerNombre VARCHAR(100),
    @SegundoNombre VARCHAR(100) = NULL,
    @PrimerApellido VARCHAR(100),
    @SegundoApellido VARCHAR(100) = NULL, 
    @FechaNacimiento DATE,
    @IdArea INT
AS
INSERT INTO Empleados (IdTipoDocumento,NumeroDocumento,PrimerNombre,SegundoNombre,
						PrimerApellido,SegundoApellido,FechaNacimiento,IdArea)

        VALUES (@IdTipoDocumento,@NumeroDocumento,@PrimerNombre,@SegundoNombre,
              @PrimerApellido,@SegundoApellido,@FechaNacimiento,@IdArea);

--------------ELIMINAR DATOS EMPLEADO
CREATE PROCEDURE EliminarEmpleado
@Id INT
AS 
DELETE FROM Empleados WHERE IdEmpleado=@Id

--------------EDITAR DATOS EMPLEADO

CREATE PROCEDURE EditarEmpleados
	@IdTipoDocumento INT,
    @NumeroDocumento VARCHAR(50),
    @PrimerNombre VARCHAR(100),
    @SegundoNombre VARCHAR(100) = NULL,
    @PrimerApellido VARCHAR(100),
    @SegundoApellido VARCHAR(100) = NULL, 
    @FechaNacimiento DATE,
    @IdArea INT,
	@IdEmpleado INT
AS
UPDATE empleados set IdTipoDocumento=@IdTipoDocumento, NumeroDocumento=@NumeroDocumento,PrimerNombre=@PrimerNombre, 
		SegundoNombre=@SegundoNombre,PrimerApellido=@PrimerApellido,SegundoApellido=@SegundoApellido, FechaNacimiento=@FechaNacimiento,
		IdArea=@IdArea WHERE IdEmpleado=@IdEmpleado



TRUNCATE TABLE TiposDocumento

