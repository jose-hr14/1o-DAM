CREATE TABLE MENSAJE (
	idMensaje INT PRIMARY KEY IDENTITY(1,1),
	mensajeOriginal VARCHAR(MAX),
	mensajeCifrado VARCHAR(MAX),
	idMetodoCifrado INT, 
	FOREIGN KEY (idMetodoCifrado) REFERENCES METODO_CIFRADO (idCifrado)	
);