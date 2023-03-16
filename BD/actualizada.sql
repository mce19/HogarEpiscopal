CREATE DATABASE Hogar_Episcopal;
GO

use Hogar_Episcopal;

CREATE TABLE padres (
tipo_documento VARCHAR(10) NOT NULL,
numero_documento INT PRIMARY KEY,
nombre_completo VARCHAR(50) NOT NULL,
direccion VARCHAR(100) NOT NULL,
telefono VARCHAR(20) NOT NULL
);

CREATE TABLE hijos (
numero_documento INT PRIMARY KEY,
nombre_completo VARCHAR(50) NOT NULL,
fecha_nacimiento DATE NOT NULL,
edad VARCHAR(3) NOT NULL,
genero VARCHAR(10) NOT NULL,
segun_inec VARCHAR(20) NULL,
subsidio VARCHAR(10) NOT NULL,
padre_id INT NOT NULL,
fecha_registro DATE NOT NULL,
FOREIGN KEY (padre_id) REFERENCES padres(numero_documento)
);

CREATE TABLE grupos (
id INT PRIMARY KEY,
nombre VARCHAR(50) NOT NULL
);

CREATE TABLE docentes (
    numero_documento INT PRIMARY KEY,
    nombre_completo VARCHAR(50) NOT NULL,
    direccion VARCHAR(100) NOT NULL,
    telefono VARCHAR(20) NOT NULL,
	grupo_id INT NOT NULL,
	FOREIGN KEY (grupo_id) REFERENCES grupos(id)
);


CREATE TABLE asistentes (
    id INT IDENTITY(1,1) PRIMARY KEY,
    numero_documento INT NOT NULL,
    nombre_completo VARCHAR(50) NOT NULL,
    docente_id INT NOT NULL,
    FOREIGN KEY (docente_id) REFERENCES docentes(numero_documento)
);

DROP TABLE ASISTENTES


drop table asistentes

CREATE TABLE matricula (
id INT PRIMARY KEY,
hijo_id INT NOT NULL,
padre_id INT NOT NULL,
docente_id INT NOT NULL,
grupo_id INT NOT NULL,
FOREIGN KEY (hijo_id) REFERENCES hijos(numero_documento),
FOREIGN KEY (padre_id) REFERENCES padres(numero_documento),
FOREIGN KEY (docente_id) REFERENCES docentes(numero_documento),
FOREIGN KEY (grupo_id) REFERENCES grupos(id)
);


CREATE TABLE pagos (
    id INT PRIMARY KEY,
    padre_id INT NOT NULL,
    monto_mensual DECIMAL(10,2) NOT NULL,
    monto_abonado DECIMAL(10,2) NOT NULL,
    saldo_actual DECIMAL(10,2) NOT NULL,
    fecha DATE NOT NULL, 
    concepto VARCHAR (255) NULL,
    FOREIGN KEY (padre_id) REFERENCES padres(numero_documento)
);

CREATE TABLE historial_pagos (
    id INT IDENTITY(1,1) PRIMARY KEY,
    padre_id INT NOT NULL,
    monto_cancelado DECIMAL(10,2) NOT NULL,
    fecha_cancelacion DATE NOT NULL,
    FOREIGN KEY (padre_id) REFERENCES padres(numero_documento)
);

CREATE PROCEDURE Historial
AS
BEGIN
    SELECT 
        hp.id, 
		p.numero_documento AS Documento, 
        p.nombre_completo AS Nombre, 
        hp.monto_cancelado, 
        hp.fecha_cancelacion 
    FROM 
        historial_pagos hp 
        INNER JOIN padres p ON hp.padre_id = p.numero_documento 
END

CREATE PROCEDURE BuscarNombreHistorial
    @nombre VARCHAR(50)
AS
BEGIN
    SELECT 
        hp.id, 
		p.numero_documento AS Documento, 
        p.nombre_completo AS Nombre, 
        hp.monto_cancelado, 
        hp.fecha_cancelacion 
    FROM 
        historial_pagos hp 
        INNER JOIN padres p ON hp.padre_id = p.numero_documento 
    WHERE 
        p.nombre_completo LIKE '%' + @nombre + '%'
END

CREATE PROCEDURE Adsistente
    @numero_documento INT,
    @nombre_completo VARCHAR(50),
    @docente_id INT
AS
BEGIN
    IF NOT EXISTS (SELECT * FROM asistentes WHERE numero_documento = @numero_documento)
    BEGIN
        INSERT INTO asistentes (numero_documento, nombre_completo, docente_id)
        VALUES (@numero_documento, @nombre_completo, @docente_id)
        PRINT 'Registro insertado correctamente.'
    END
    ELSE
    BEGIN
        PRINT 'El número de documento ya existe en la tabla.'
    END
END


CREATE PROCEDURE Updateasistente
    @id INT,
    @numero_documento INT,
    @nombre_completo VARCHAR(50),
    @docente_id INT
AS
BEGIN
    UPDATE asistentes
    SET numero_documento = @numero_documento,
        nombre_completo = @nombre_completo,
        docente_id = @docente_id
    WHERE id = @id
END



EXEC Historial
DROP PROCEDURE BuscarNombreHistorial

CREATE PROCEDURE InsertarGrupo
    @id INT,
    @nombre VARCHAR(50)
AS
BEGIN
    INSERT INTO grupos (id, nombre)
    VALUES (@id, @nombre)
END

CREATE PROCEDURE ActualizarGrupo
    @id INT,
    @nombre VARCHAR(50)
AS
BEGIN
    UPDATE grupos
    SET nombre = @nombre
    WHERE id = @id
END

CREATE PROCEDURE ObtenerGrupoDetalle
    @nombre_grupo VARCHAR(50)
AS
BEGIN
    SELECT d.nombre_completo AS 'Docente', a.nombre_completo AS 'Asistente'
    FROM docentes d
    JOIN grupos g ON d.grupo_id = g.id
    LEFT JOIN asistentes a ON d.numero_documento = a.docente_id
    WHERE g.nombre = @nombre_grupo;
END


EXEC ObtenerGrupoDetalle 'Escolares IV'
drop procedure ObtenerGrupoDetalle

CREATE PROCEDURE InsertarDocente
    @numero_documento INT,
    @nombre_completo VARCHAR(50),
    @direccion VARCHAR(100),
    @telefono VARCHAR(20),
    @grupo_id INT
AS
BEGIN
    INSERT INTO docentes (numero_documento, nombre_completo, direccion, telefono, grupo_id)
    VALUES (@numero_documento, @nombre_completo, @direccion, @telefono, @grupo_id)
END

CREATE PROCEDURE ActualizarDocente
    @numero_documento INT,
    @nombre_completo VARCHAR(50),
    @direccion VARCHAR(100),
    @telefono VARCHAR(20),
    @grupo_id INT
AS
BEGIN
    UPDATE docentes
    SET nombre_completo = @nombre_completo,
        direccion = @direccion,
        telefono = @telefono,
        grupo_id = @grupo_id
    WHERE numero_documento = @numero_documento;
END


CREATE PROCEDURE ActualizarMatricula
    @id INT,
    @hijo_id INT,
    @padre_id INT,
    @docente_id INT,
    @grupo_id INT
AS
BEGIN
    UPDATE matricula
    SET hijo_id = @hijo_id, padre_id = @padre_id, docente_id = @docente_id, grupo_id = @grupo_id
    WHERE id = @id;
END

DROP PROCEDURE ActualizarMatricula

DELETE FROM hijos;
DELETE FROM pagos;
DELETE FROM matricula WHERE id = 2;
DROP TABLE matricula;
DROP TABLE hijos;
DROP TABLE historial_pagos;

DROP TABLE pagos;
drop table grupos;
drop table historial_pagos;
DROP TABLE asistentes;


CREATE PROCEDURE ObtenerPagosConNombresPadres
AS
BEGIN
    SELECT p.id, p.padre_id, pa.nombre_completo, p.monto_mensual, p.monto_abonado, p.saldo_actual, p.fecha, p.concepto
    FROM pagos p
    JOIN padres pa ON p.padre_id = pa.numero_documento
END


CREATE PROCEDURE ObtenerNombresPagos
    @nombre VARCHAR(50)
AS
BEGIN
    SELECT p.id, p.padre_id, pa.nombre_completo, p.monto_mensual, p.monto_abonado, p.saldo_actual, p.fecha, p.concepto
    FROM pagos p
    JOIN padres pa ON p.padre_id = pa.numero_documento
    WHERE pa.nombre_completo LIKE '%' + @nombre + '%'
END



EXEC ObtenerPagosConNombresPadres
DROP PROCEDURE ObtenerPagosConNombresPadres;

--proceso para insertar en la tabla pagos ya esta ejecutada
CREATE PROCEDURE sp_InsertarPago
    @id INT,
    @padre_id INT,
    @monto_mensual DECIMAL(10,2),
    @monto_abonado DECIMAL(10,2),
    @saldo_actual DECIMAL(10,2),
    @fecha DATE,
    @concepto VARCHAR(255)
AS
BEGIN
    INSERT INTO pagos (id, padre_id, monto_mensual, monto_abonado, saldo_actual, fecha, concepto)
    VALUES (@id, @padre_id, @monto_mensual, @monto_abonado, @saldo_actual, @fecha, @concepto);
END

DROP PROCEDURE InsertarPago;
EXEC sp_InsertarPago


CREATE PROCEDURE usp_ActualizarPago
    @id INT,
    @monto_abonado DECIMAL(10,2),
    @saldo_actual DECIMAL(10,2),
    @fecha DATE,
    @concepto VARCHAR(255)
AS
BEGIN
    UPDATE pagos
    SET monto_abonado = @monto_abonado,
        saldo_actual = @saldo_actual,
        fecha = @fecha,
        concepto = @concepto
    WHERE id = @id;
END




INSERT INTO padres (tipo_documento, numero_documento, nombre_completo, direccion, telefono)
VALUES ('CC', 12345678, 'Juan Perez', 'Calle 123', '555-555'),
       ('CC', 98765432, 'Maria Rodriguez', 'Calle 456', '555-555'),
	   ('CC', 98765433, 'jose andres', 'Calle 56', '555-556'),
	   ('CC', 98765434, 'karla Rodriguez', 'Calle 46', '555-557');
       
INSERT INTO hijos (numero_documento, nombre_completo, fecha_nacimiento, edad, genero, segun_inec, subsidio, padre_id, fecha_registro)
VALUES (11111111, 'Pedro Perez', '2010-01-01', '11', ' M', 'estudiante', 'si', 12345678,  GETDATE()),
       (22222222, 'Ana Rodriguez', '2011-01-01', '10', 'F', 'estudiante', 'no', 98765432,  GETDATE()),
       (22222223, 'Martin Rodriguez', '2011-01-01', '10', 'F', 'estudiante', 'no', 98765433,  GETDATE()),
       (22222224, 'Darling Rodriguez', '2011-01-01', '10', 'F', 'estudiante', 'no', 98765434, GETDATE());

       
	   INSERT INTO grupos (id, nombre)
VALUES (1, 'Materno I'),
       (2, 'Materno II'),
	   (3, 'Interactivo I'),
	   (4, 'Interactivo II'),
	   (5, 'Transición II'),
	   (6, 'Escolares I'),
	   (7, 'Escolares II'),
	   (8, 'Escolares III'),
	   (9, 'Escolares IV');


INSERT INTO docentes ( numero_documento, nombre_completo, direccion, telefono, grupo_id)
VALUES ( 111111111, 'Juan Perez', 'Calle 1', '3123456789', 1),
       ( 222222222, 'Maria Gomez', 'Calle 2', '3123456789', 2),
	   ( 333333333, 'Marlon Cerez', 'Calle 3', '0123456789', 9);


	   INSERT INTO asistentes ( numero_documento, nombre_completo, docente_id)
VALUES (12345678, 'Juan Perez', 12345678),
( 87654321, 'Maria Garcia', 222222222);
       


INSERT INTO matricula (id, hijo_id, padre_id, docente_id, grupo_id)
VALUES (1, 11111111, 12345678, 222222222, 1),
       (2, 22222222, 98765432, 111111111, 2);
    

INSERT INTO pagos(id, padre_id, monto_mensual, monto_abonado, saldo_actual, fecha, concepto) VALUES
(1, 12345678, 250.00, 0.00, 250.00, '2023-01-18', 'Pago mensual de enero'),
(2, 98765432, 350.00, 0.00, 350.00, '2023-01-18', 'Pago mensual de enero'),
(3, 98765433, 400.00, 0.00, 400.00, '2023-01-18', 'Pago mensual de enero');

INSERT INTO historial_pagos( padre_id, monto_cancelado, fecha_cancelacion ) VALUES
(12345678, 250.00, '2023-01-18'),
(98765432, 350.00, '2023-01-18'),
(98765433, 400.00, '2023-01-18');




SELECT * FROM pagos
SELECT * FROM padres
SELECT * FROM hijos
SELECT * FROM docentes
SELECT * FROM asistentes
SELECT * FROM matricula
SELECT * FROM grupos
SELECT * FROM historial_pagos

---PROCESO DE LISTAR RECIEN MATRICULADOS 



CREATE PROCEDURE ConsultaRegistro
AS
BEGIN
    SELECT TOP 10 p.numero_documento AS 'Ced. Padre', p.nombre_completo AS 'Nombre Padre', h.nombre_completo AS 'Nombre Hijo', h.numero_documento AS 'Ced. Hijo', h.fecha_registro
    FROM padres p
    INNER JOIN hijos h ON p.numero_documento = h.padre_id
    WHERE NOT EXISTS (
        SELECT 1 
        FROM matricula m 
        WHERE m.hijo_id = h.numero_documento AND m.padre_id = p.numero_documento
    )
    ORDER BY h.fecha_registro DESC;
END;


	DROP FUNCTION ConsultaRegistro;
--consulta procedure
EXEC ConsultaRegistro;
---para eliminar procedure 
DROP PROCEDURE ConsultaRegistro;

--procedimiento para gaurdar el historial de pago
CREATE PROCEDURE InsertarPagoEnHistorial
    @padre_id INT,
    @monto_cancelado DECIMAL(10,2),
    @fecha_cancelacion DATE    
AS
BEGIN
    INSERT INTO historial_pagos (padre_id, monto_cancelado, fecha_cancelacion)
    VALUES (@padre_id, @monto_cancelado, @fecha_cancelacion)
END




---CONSULTADMOS LOS DOCECENTES CON SU GRUPO
CREATE PROCEDURE ConsultarDocentesConGrupo
AS
BEGIN
  SELECT d.numero_documento AS 'Numero de Documento', d.nombre_completo AS 'Nombre Completo', g.nombre AS 'Nombre del Grupo', g.id AS 'ID del Grupo'
  FROM docentes d
  INNER JOIN grupos g ON d.grupo_id = g.id
END;

EXEC ConsultarDocentesConGrupo;


---PROCEDURE POR GRUPO  EXITOSO
CREATE PROCEDURE GetInfoByGroup (@groupName VARCHAR(50))
AS
BEGIN
    SELECT hijos.numero_documento, hijos.nombre_completo, hijos.fecha_nacimiento, hijos.edad, hijos.genero, hijos.subsidio
    FROM hijos
    INNER JOIN padres ON hijos.padre_id = padres.numero_documento
    INNER JOIN matricula ON hijos.numero_documento = matricula.hijo_id
    INNER JOIN grupos ON matricula.grupo_id = grupos.id
    WHERE grupos.nombre = @groupName
END


EXEC GetInfoByGroup 'Materno II'
SELECT * FROM hijos
SELECT * FROM padres

---EXEC MostrarInformacionDeMatricula @grupo_seleccionado = 1;


SELECT hijos.*
FROM hijos
JOIN matricula ON matricula.hijo_id = hijos.numero_documento
JOIN grupos ON matricula.grupo_id = grupos.id
WHERE grupos.nombre = 'Materno II';

SELECT padres.nombre_completo, hijos.nombre_completo, hijos.segun_inec, pagos.fecha, pagos.monto, pagos.saldo_actual, pagos.concepto, abonos.fecha, abonos.monto, historial_pagos.canelado 
FROM matricula 
JOIN padres ON matricula.padre_id = padres.numero_documento 
JOIN hijos ON matricula.hijo_id = hijos.numero_documento 
JOIN pagos ON matricula.padre_id = pagos.padre_id
LEFT JOIN abonos ON pagos.id = abonos.pago_id
LEFT JOIN historial_pagos ON pagos.id = historial_pagos.pago_id



SELECT padres.nombre_completo AS nombre_padre, hijos.nombre_completo AS nombre_hijo, hijos.segun_inec, pagos.fecha AS fecha_pago, pagos.monto AS monto_pago, pagos.saldo_actual AS saldo_actual_pagado, abonos.fecha AS fecha_abono, abonos.monto AS monto_abono, (CASE WHEN abonos.monto is null THEN pagos.saldo_actual ELSE pagos.saldo_actual-abonos.monto END) AS saldo_actual_mes, historial_pagos.canelado
FROM matricula 
JOIN padres ON matricula.padre_id = padres.numero_documento 
JOIN hijos ON matricula.hijo_id = hijos.numero_documento 
JOIN pagos ON matricula.padre_id = pagos.padre_id
LEFT JOIN abonos ON pagos.id = abonos.pago_id
LEFT JOIN historial_pagos ON pagos.id = historial_pagos.pago_id


SELECT padres.nombre_completo AS nombre_padre, hijos.nombre_completo AS nombre_hijo, hijos.segun_inec, pagos.fecha AS fecha_pago, pagos.monto AS monto_pago, pagos.saldo_actual AS saldo_actual_pagado, abonos.fecha AS fecha_abono, abonos.monto AS monto_abono, (CASE WHEN abonos.monto is null THEN pagos.saldo_actual ELSE pagos.saldo_actual-abonos.monto END) AS saldo_actual_mes, historial_pagos.canelado
FROM matricula 
JOIN padres ON matricula.padre_id = padres.numero_documento 
JOIN hijos ON matricula.hijo_id = hijos.numero_documento 
JOIN pagos ON matricula.padre_id = pagos.padre_id
LEFT JOIN abonos ON pagos.id = abonos.pago_id
LEFT JOIN historial_pagos ON pagos.id = historial_pagos.pago_id;


---me muestra la lista de los niños segun el grupo
SELECT hijos.*
FROM hijos
JOIN matricula ON matricula.hijo_id = hijos.numero_documento
JOIN grupos ON matricula.grupo_id = grupos.id
WHERE grupos.nombre = 'Grupo A';


SELECT hijos.*, docentes.nombre as profesor, asistentes.nombre as asistente
FROM hijos
JOIN matricula ON matricula.hijo_id = hijos.numero_documento
JOIN grupos ON matricula.grupo_id = grupos.id
JOIN docentes ON matricula.docente_id = docentes.id
JOIN asistentes ON matricula.docente_id = asistentes.docente_id
WHERE grupos.nombre = 'Grupo A';



---me muestra el total de niñosy niñas y de supsidios 
SELECT 
  COUNT(CASE WHEN genero = ' M' THEN 1 END) AS "Total de niños varones",
  COUNT(CASE WHEN genero = 'F' THEN 1 END) AS "Total de niñas",
  COUNT(CASE WHEN subsidio = 'si' THEN 1 END) AS "Total con subsidio",
  COUNT(CASE WHEN subsidio = 'no' THEN 1 END) AS "Total sin subsidio"
FROM hijos
JOIN matricula ON matricula.hijo_id = hijos.numero_documento
JOIN grupos ON matricula.grupo_id = grupos.id
WHERE grupos.nombre = 'Grupo A';


-- aqui me hace bien la consulta solo ocupo cambiar en la tabla padre e hijos que ingresen el nombre completo en una sola variable
SELECT padres.nombre_completo AS 'Nombre del Padre', hijos.nombre_completo AS 'Nombre del Hijo', hijos.fecha_nacimiento, hijos.edad, hijos.genero, hijos.subsidio
FROM padres
JOIN hijos ON padres.numero_documento = hijos.padre_id
JOIN pagos ON padres.numero_documento = pagos.padre_id
LEFT JOIN abonos ON pagos.id = abonos.pago_id


---no se 
SELECT 
    padres.nombre_completo AS NombrePadre,
    hijos.nombre_completo AS NombreHijo,
    pagos.monto AS Pago,
    abonos.monto AS Abono,
    pagos.saldo_actual AS Saldo
    
FROM 
    padres
JOIN 
    hijos ON padres.numero_documento = hijos.padre_id
JOIN 
    matricula ON hijos.numero_documento = matricula.hijo_id
JOIN 
    pagos ON matricula.id = pagos.id
LEFT JOIN
    abonos ON pagos.id = abonos.pago_id


	SELECT docentes.nombre as 'Nombre del docente', asistentes.nombre as 'Nombre del asistente'
FROM grupos
JOIN matricula ON matricula.grupo_id = grupos.id
JOIN docentes ON matricula.docente_id = docentes.id
LEFT JOIN asistentes ON matricula.docente_id = asistentes.docente_id
WHERE grupos.nombre = 'Grupo A';


drop table docentes

CREATE PROCEDURE ListarDatosTabla
    @tabla VARCHAR(50)
AS
BEGIN
    IF @tabla = 'padres'
    BEGIN
        SELECT * FROM padres;
    END
    IF @tabla = 'hijos'
    BEGIN
        SELECT * FROM hijos;
    END
    IF @tabla = 'docentes'
    BEGIN
        SELECT * FROM Docentes;
    END
END

DROP PROCEDURE ActualizarPadre;



EXEC ListarDatosTabla  'hijos'


--- *******************************
CREATE PROCEDURE ActualizarPadre
    @tipo_documento VARCHAR(10),
    @numero_documento INT,
    @nombre_completo VARCHAR(50),
    @direccion VARCHAR(100),
    @telefono VARCHAR(20)
AS
BEGIN
    UPDATE padres
    SET tipo_documento = @tipo_documento, 
    nombre_completo = @nombre_completo,
    direccion = @direccion,
    telefono = @telefono
    WHERE numero_documento = @numero_documento
END


--- elimini

CREATE PROCEDURE EliminarPadre
    @numero_documento INT
AS
BEGIN
    DELETE FROM padres WHERE numero_documento = @numero_documento
END

---agregar padre 

CREATE PROCEDURE AgregarPadre
    @tipo_documento VARCHAR(10),
    @numero_documento INT,
    @nombre_completo VARCHAR(50),
    @direccion VARCHAR(100),
    @telefono VARCHAR(20)
AS
BEGIN
    INSERT INTO padres (tipo_documento, numero_documento, nombre_completo, direccion, telefono)
    VALUES (@tipo_documento, @numero_documento, @nombre_completo, @direccion, @telefono)
END

