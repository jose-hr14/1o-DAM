--1.- Nombre de productos en BD TIENDA
--Utilizando la BD TIENDA, crea un script que recorra con cursores la tabla PRODUCTO y
--que muestre el nombre de cada producto por pantalla.
USE TIENDA;
GO
DECLARE Cur_Producto CURSOR FOR
	SELECT nombre
	FROM PRODUCTO;
DECLARE @nombre VARCHAR(100);
OPEN Cur_Producto
FETCH NEXT FROM Cur_Producto INTO @nombre;
WHILE (@@FETCH_STATUS = 0)
	BEGIN
		PRINT @nombre;
		FETCH NEXT FROM Cur_Producto INTO @nombre
	END
CLOSE Cur_Producto;
DEALLOCATE Cur_Producto;

--2.- Nombre y precio de productos en BD TIENDA
--Ampliación del script anterior. Utilizando la BD TIENDA, crea un script que recorra con
--cursores la tabla PRODUCTO y que muestre el nombre de cada producto y su precio por
--pantalla haciendo uso de la función CONCAT.
USE TIENDA;
GO
DECLARE Cur_Producto02 CURSOR FOR
	SELECT codigo
	FROM PRODUCTO;
DECLARE @codigo INT, @nombre VARCHAR(100), @precio DECIMAL(9,2);

OPEN Cur_Producto02
FETCH NEXT FROM Cur_Producto02 INTO @codigo;
WHILE (@@FETCH_STATUS = 0)
	BEGIN
	SET @nombre =
		(SELECT nombre 
		FROM PRODUCTO
		WHERE codigo = @codigo);
	SET @precio =
		(SELECT precio 
		FROM PRODUCTO
		WHERE codigo = @codigo);
		PRINT CONCAT('Nombre: ', @nombre, CHAR(10), ' Precio: ', @precio);
		FETCH NEXT FROM Cur_Producto02 INTO @codigo
	END
CLOSE Cur_Producto02;
DEALLOCATE Cur_Producto02;
--3.- Cursores anidados en BD TIENDA
--En este script deberás utilizar un cursor que recorra la tabla FABRICANTE y dentro de éste
--cursor otro que recorra la tabla PRODUCTO. El objetivo es que dentro de este segundo
--cursor se acumule el precio de los productos de cada fabricante y que se muestre algo
--similar a lo siguiente:
--“Fabricante: nombreFabricante tiene un total de acumulado € en productos.” (siendo las
--palabras resaltadas en rojo variables)
USE TIENDA;
GO
DECLARE Cur_Fabricante CURSOR FOR
	SELECT codigo
	FROM FABRICANTE;
DECLARE @codigo INT, @nombre VARCHAR(100), @precio NUMERIC(9,2);

OPEN Cur_Fabricante;
FETCH NEXT FROM Cur_Fabricante INTO @codigo;
WHILE (@@FETCH_STATUS = 0)
	BEGIN
		-- Inicio del segundo cursor 
		DECLARE Cur_Fabricante02 CURSOR FOR
			SELECT codigo
			FROM PRODUCTO
			WHERE codigo_fabricante = @codigo;
		DECLARE @codigoProducto INT, @total NUMERIC(9,2);
		SET @total = 0;

		OPEN Cur_Fabricante02;
		FETCH NEXT FROM Cur_Fabricante02 INTO @codigoProducto;
		WHILE (@@FETCH_STATUS = 0)
			BEGIN
				SET @total += (SELECT precio FROM PRODUCTO WHERE codigo = @codigoProducto);
				FETCH NEXT FROM Cur_Fabricante02 INTO @codigoProducto;
			END
		PRINT @total;
		CLOSE Cur_Fabricante02;
		DEALLOCATE Cur_Fabricante02;
		-- Fin del segundo cursor
		FETCH NEXT FROM Cur_Fabricante INTO @codigo;
	END
CLOSE Cur_Fabricante;
DEALLOCATE Cur_Fabricante;
--4.- Nombre y precio de productos en BD JARDINERIA
--Crea un script que recorra con cursores la tabla EMPLEADOS y que muestre los siguientes
--datos de cada empleado: nombre, apellido1, apellido2 y email. Deberás formatearlos
--utilizando la función CONCAT.
USE JARDINERIA;
GO
DECLARE Cur_Empleados CURSOR FOR
	SELECT codEmpleado
	FROM EMPLEADOS;
DECLARE @codigoEmpleado INT, @nombre VARCHAR(50), @apellido1 VARCHAR(50), @apellido2 VARCHAR(50), @email VARCHAR(100);

OPEN Cur_Empleados;
FETCH NEXT FROM Cur_Empleados INTO @codigoEmpleado;
WHILE (@@FETCH_STATUS = 0)
	BEGIN
		SET @nombre = (SELECT nombre FROM EMPLEADOS WHERE codEmpleado = @codigoEmpleado);
		SET @apellido1 = (SELECT apellido1 FROM EMPLEADOS WHERE codEmpleado = @codigoEmpleado);
		SET @apellido2 = (SELECT apellido2 FROM EMPLEADOS WHERE codEmpleado = @codigoEmpleado);
		SET @email = (SELECT email FROM EMPLEADOS WHERE codEmpleado = @codigoEmpleado);
		PRINT CONCAT ('Nombre: ', @nombre, ' ', @apellido1, ' ', @apellido2, ' | Email: ', @email);
		FETCH NEXT FROM Cur_Empleados INTO @codigoEmpleado;
	END
CLOSE Cur_Empleados;
DEALLOCATE Cur_Empleados;

--5.- Cursores anidados en BD JARDINERIA
--En este script deberás utilizar un cursor que recorra la tabla PEDIDOS y dentro de éste
--cursor otro que recorra la tabla DETALLE_PEDIDOS. El objetivo es que dentro de este
--segundo cursor se acumule el total por línea de cada pedido y que finalmente se muestre el
--total acumulado para cada pedido.
--“Nº Pedido XXXX tiene un coste total de XXXX €”
