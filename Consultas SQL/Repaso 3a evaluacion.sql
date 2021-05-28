USE BIBLIOTECA_V2;
GO
--EJERCICIO 01
CREATE PROCEDURE sp_insertarLibro @ISBN CHAR(13), @titulo VARCHAR(200), @autor VARCHAR(200), @unidades SMALLINT
AS
BEGIN TRY
	IF (@ISBN IS NULL OR @titulo IS NULL OR @autor IS NULL OR @unidades IS NULL)
		BEGIN
			PRINT ('Faltan parámetros');
			RETURN 0;
		END;

	BEGIN TRAN
	INSERT INTO LIBROS
	VALUES (@ISBN, @titulo, @autor, @unidades);
	COMMIT;
	RETURN -1;
END TRY
BEGIN CATCH
	ROLLBACK;
	DECLARE @mensajeError VARCHAR(100) = ERROR_MESSAGE();
	RAISERROR(@mensajeError, 17, 1);
END CATCH;

DECLARE @ret INT;
EXEC @ret = sp_insertarLibro 'lalalalalalal', 'Tokyo Blues', 'Haruki Murakami', 3;

--EJERCICIO02
CREATE PROCEDURE sp_modificarSocio @codSocio INT, @nombreApe VARCHAR(200), @direccion VARCHAR(300)
AS
BEGIN TRY
	IF (@codSocio IS NULL OR @nombreApe IS NULL OR @direccion IS NULL)
		BEGIN
			PRINT ('Faltan parámetros');
			RETURN 0;
		END;
	BEGIN TRAN
		UPDATE SOCIOS
		SET nombreApe = @nombreApe, direccion = @direccion
		WHERE codSocio = @codSocio;
	COMMIT;
	RETURN -1;
END TRY
BEGIN CATCH
	ROLLBACK;
	DECLARE @mensajeError VARCHAR(100) = ERROR_MESSAGE();
	RAISERROR(@mensajeError, 17, 1);
END CATCH;

DECLARE @ret VARCHAR(100);
EXEC @ret = sp_modificarSocio 1, 'Juanfran', 'Calle Desconocida';

--Ejercicio03
CREATE PROCEDURE sp_devuelveLibro @ISBN CHAR(13), @titulo VARCHAR(200) OUTPUT, @autor VARCHAR(200) OUTPUT, @unidades SMALLINT OUTPUT
AS
BEGIN TRY
	IF (@ISBN IS NULL)
		BEGIN
			PRINT ('Faltan parámetros');
			RETURN 0;
		END;
	SET @titulo = (SELECT titulo FROM LIBROS WHERE ISBN = @ISBN);
	SET @autor = (SELECT autor FROM LIBROS WHERE ISBN = @ISBN);
	SET @unidades = (SELECT unidades FROM LIBROS WHERE ISBN = @ISBN);
	RETURN -1;
END TRY
BEGIN CATCH
	DECLARE @mensajeError VARCHAR(100) = ERROR_MESSAGE();
	RAISERROR(@mensajeError, 17, 1);
END CATCH;

DECLARE @ret VARCHAR(100), @titulo VARCHAR(200), @autor VARCHAR(200), @unidades SMALLINT;
EXEC @ret = sp_devuelveLibro 'lalalalalalal', @titulo OUTPUT, @autor OUTPUT, @unidades OUTPUT;
PRINT CONCAT(@titulo, @autor, @unidades);

--EJERCICIO04
CREATE PROCEDURE sp_prestarLibro @ISBN CHAR(13), @codSocio INT
AS
BEGIN TRY

	IF (@ISBN IS NULL OR @codSocio IS NULL)
		BEGIN
			PRINT 'Faltan parámetros';
			RETURN 0;
		END;
	IF (@ISBN NOT IN (SELECT ISBN FROM LIBROS) OR @codSocio NOT IN (SELECT codSocio FROM SOCIOS))
		BEGIN
			PRINT 'Al menos uno de los parámetros no es correcto';
			RETURN 0;
		END;
	IF ((SELECT unidades FROM LIBROS WHERE ISBN = @ISBN) = 0)
		BEGIN
			PRINT 'No hay suficientes unidades de este libro para prestarse';
			RETURN 0;
		END;

	BEGIN TRAN
		INSERT INTO PRESTAMOS (codSocio, ISBN, fechaPrestamo)
		VALUES (@codSocio, @ISBN, GETDATE() );
	COMMIT;
	PRINT 'Prestamo insertado correctamente';
	RETURN -1;

END TRY
BEGIN CATCH
	ROLLBACK;
	DECLARE @mensajeError VARCHAR(100) = ERROR_MESSAGE();
	RAISERROR(@mensajeError, 17, 1);
END CATCH;

DECLARE @ret INT;
EXEC @ret = sp_prestarLibro '9788416693436', 1;

--Ejercicio05
ALTER PROCEDURE sp_devolverLibro @ISBN CHAR(13), @codSocio INT
AS
BEGIN TRY

	IF (@ISBN IS NULL OR @codSocio IS NULL)
		BEGIN
			PRINT 'Faltan parámetros';
			RETURN 0;
		END;
	IF (@ISBN NOT IN (SELECT ISBN FROM PRESTAMOS WHERE fechaDevol IS NULL) OR @codSocio NOT IN (SELECT codSocio FROM PRESTAMOS WHERE fechaDevol IS NULL))
		BEGIN
			PRINT 'Al menos uno de los parámetros no es correcto';
			RETURN 0;
		END;

	BEGIN TRAN
		UPDATE PRESTAMOS
		SET fechaDevol = GETDATE()
		WHERE ISBN = @ISBN 
		AND codSocio = @codSocio
		AND fechaDevol IS NULL;		
	COMMIT;
	PRINT 'Prestamo devuelto correctamente';
	RETURN -1;

END TRY
BEGIN CATCH
	ROLLBACK;
	DECLARE @mensajeError VARCHAR(100) = ERROR_MESSAGE();
	RAISERROR(@mensajeError, 17, 1);
END CATCH;

DECLARE @ret INT;
EXEC @ret = sp_devolverLibro '9788416693436', 1;


--EJERCICIO06
CREATE TRIGGER TX_prestamo ON PRESTAMOS AFTER INSERT
AS
BEGIN
	DECLARE @ISBN char(13) = (SELECT ISBN FROM inserted);
	DECLARE @codSocio INT = (SELECT codSocio FROM inserted);

	UPDATE LIBROS
	SET unidades -= 1
	WHERE ISBN = @ISBN;

	UPDATE SOCIOS
	SET numLibPrestados += 1
	WHERE codSocio = @codSocio;
END;

--EJERCICIO07
ALTER TRIGGER TX_prestamo02 ON PRESTAMOS AFTER UPDATE
AS
BEGIN
	
	DECLARE @ISBN char(13) = (SELECT TOP(1) ISBN FROM inserted);
	DECLARE @codSocio INT = (SELECT TOP(1) codSocio FROM inserted);
	DECLARE @fechaDevol SMALLDATETIME = (SELECT TOP(1) fechaDevol FROM deleted);

	PRINT @fechaDevol;
	IF (@fechaDevol IS NULL)
		BEGIN
		UPDATE LIBROS
		SET unidades += 1
		WHERE ISBN = @ISBN;

		UPDATE SOCIOS
		SET numLibPrestados -= 1
		WHERE codSocio = @codSocio;
		END;
END;
