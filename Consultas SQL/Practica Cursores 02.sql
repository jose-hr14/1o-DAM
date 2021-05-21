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

--4.- Nombre y precio de productos en BD JARDINERIA
--Crea un script que recorra con cursores la tabla EMPLEADOS y que muestre los siguientes
--datos de cada empleado: nombre, apellido1, apellido2 y email. Deberás formatearlos
--utilizando la función CONCAT.

--5.- Cursores anidados en BD JARDINERIA
--En este script deberás utilizar un cursor que recorra la tabla PEDIDOS y dentro de éste
--cursor otro que recorra la tabla DETALLE_PEDIDOS. El objetivo es que dentro de este
--segundo cursor se acumule el total por línea de cada pedido y que finalmente se muestre el
--total acumulado para cada pedido.
--“Nº Pedido XXXX tiene un coste total de XXXX €”