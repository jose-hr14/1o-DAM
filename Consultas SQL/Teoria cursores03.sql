USE JARDINERIA;
GO


DECLARE Cur_Clientes CURSOR FOR
	SELECT nombre_cliente
	FROM CLIENTES;

DECLARE @nomCliente VARCHAR(100);
DECLARE @acumulado NUMERIC(15,2);
DECLARE @total NUMERIC(15,2);
DECLARE @codCliente INT;

OPEN Cur_Clientes

FETCH NEXT FROM Cur_Clientes INTO @nomCliente

WHILE (@@FETCH_STATUS = 0)
BEGIN
	PRINT @nomCliente;
	SET @total = 0;
	-- cursor anidado

		DECLARE Cur_Pagos CURSOR FOR
		SELECT total
		FROM PAGOS
		WHERE codCliente = @nomCliente;
				
		OPEN Cur_Pagos;

		FETCH NEXT FROM Cur_Pagos INTO @total;

		WHILE (@@FETCH_STATUS = 0)
		BEGIN
			SET @acumulado = @acumulado + @total;
			FETCH NEXT FROM Cur_Pagos INTO @total;
		END;

		CLOSE Cur_Pagos;
		DEALLOCATE Cur_Pagos;
		


	-- cursor anidado cerrado
	PRINT CONCAT ('El Cliente ', @codCliente, ' ha gastado: ', @acumulado, ' euros');

	FETCH NEXT FROM Cur_Clientes INTO @nomCliente;
END

CLOSE Cur_Clientes;
DEALLOCATE Cur_Clientes;