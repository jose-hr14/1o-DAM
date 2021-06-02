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
CREATE TRIGGER TX_prestamo02 ON PRESTAMOS AFTER UPDATE
AS
BEGIN
	
	DECLARE @ISBN char(13) = (SELECT TOP(1) ISBN FROM inserted);
	DECLARE @codSocio INT = (SELECT TOP(1) codSocio FROM inserted);
	DECLARE @fechaDevol SMALLDATETIME = (SELECT TOP(1) fechaDevol FROM deleted);
	DECLARE @count INT = (select count(*) from deleted);

	IF (@fechaDevol IS NULL)
		BEGIN
		UPDATE LIBROS
		SET unidades += @count
		WHERE ISBN = @ISBN;

		UPDATE SOCIOS
		SET numLibPrestados -= @count
		WHERE codSocio = @codSocio;
		END;
END;

--EJERCICIO08
CREATE FUNCTION fn_esPosiblePrestarLibros (@codSocio INT)
RETURNS CHAR(2)
AS
BEGIN
	DECLARE @numLibPrestamos INT = (SELECT numLibPrestados FROM SOCIOS WHERE codSocio = @codSocio);

	IF (@numLibPrestamos >= 2)
		RETURN 'NO';
	RETURN 'SI';
END;

SELECT *, dbo.fn_esPosiblePrestarLibros(codSocio) AS esPosiblePrestarLibros FROM SOCIOS;

--EJERCICIO09
CREATE FUNCTION fn_maxFechaDevol (@codPrestamo INT)
RETURNS SMALLDATETIME
AS
BEGIN
	DECLARE @fecha SMALLDATETIME = (SELECT fechaDevol FROM PRESTAMOS WHERE codPrestamo = @codPrestamo);
	SET @fecha = DATEADD(DAY, 15, @fecha);
	RETURN @fecha;
END;

SELECT *, DBO.fn_maxFechaDevol(codPrestamo) AS fechaMax FROM PRESTAMOS;

--EJERCICIO10
DECLARE TX_LIBROS CURSOR FOR
SELECT ISBN
FROM LIBROS;
DECLARE @ISBN CHAR(13);

OPEN TX_LIBROS;

FETCH NEXT FROM TX_LIBROS INTO @ISBN;
WHILE (@@FETCH_STATUS = 0)
BEGIN
	DECLARE @titulo VARCHAR(100) = (SELECT titulo FROM LIBROS WHERE ISBN = @ISBN);
	DECLARE @autor VARCHAR(100) = (SELECT autor FROM LIBROS WHERE ISBN = @ISBN);
	DECLARE @unidades INT = (SELECT unidades FROM LIBROS WHERE ISBN = @ISBN);
	PRINT CONCAT ('ISBN: ', @ISBN);
	PRINT CONCAT ('Titulo: ', @titulo);
	PRINT CONCAT ('Autor: ', @autor);
	PRINT CONCAT ('Unidades: ', @unidades);
	PRINT ('');
	FETCH NEXT FROM TX_LIBROS INTO @ISBN;
END;

CLOSE TX_LIBROS;
DEALLOCATE TX_LIBROS;

--EJERCICIO11
DECLARE TX_SOCIOS CURSOR FOR
SELECT codSocio
FROM SOCIOS;

DECLARE @codSocio INT, @contador INT;
SET @contador = 0;

OPEN TX_SOCIOS;

FETCH NEXT FROM TX_SOCIOS INTO @codSocio;

WHILE (@@FETCH_STATUS = 0)
BEGIN
	SET @contador += 1
	--CURSOR 2
	DECLARE TX_PRESTAMOS CURSOR FOR
	SELECT codPrestamo
	FROM PRESTAMOS
	WHERE codSocio = @codSocio;

	DECLARE @codPrestamo INT, @nombreSocio VARCHAR(50), @ISBN CHAR(13), @fechaPres SMALLDATETIME, @fechaDevol SMALLDATETIME;
	SET @nombreSocio = (SELECT nombreApe FROM SOCIOS WHERE codSocio = @codSocio);	

	IF (@codSocio IN (SELECT codSocio FROM PRESTAMOS) )
		PRINT CONCAT('Tratamiento del socio ', @contador, ' - ', @nombreSocio);

	OPEN TX_PRESTAMOS;
	FETCH NEXT FROM TX_PRESTAMOS INTO @codPrestamo;
	WHILE (@@FETCH_STATUS = 0)
	BEGIN

			
		SET @ISBN = (SELECT ISBN FROM PRESTAMOS WHERE codPrestamo = @codPrestamo);
		SET @fechaPres = (SELECT fechaPrestamo FROM PRESTAMOS WHERE codPrestamo = @codPrestamo);
		SET @fechaDevol = (SELECT fechaDevol FROM PRESTAMOS WHERE codPrestamo = @codPrestamo);
		
		PRINT CONCAT('Préstamo ', @codPrestamo, ' ISBN ', @ISBN, ' FechaPres: ', DAY(@fechaPres), '/', MONTH(@fechaPres), '/', YEAR(@fechaPres), ' FechaDevol ', DAY(@fechaDevol), '/', MONTH(@fechaDevol), '/', YEAR(@fechaDevol) );
		FETCH NEXT FROM TX_PRESTAMOS INTO @codPrestamo;
	END;
	CLOSE TX_PRESTAMOS;
	DEALLOCATE TX_PRESTAMOS;
	--CURSOR 2
	FETCH NEXT FROM TX_SOCIOS INTO @codSocio;
END;

CLOSE TX_SOCIOS;
DEALLOCATE TX_SOCIOS;

--FIN