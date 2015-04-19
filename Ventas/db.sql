USE Ventas;

CREATE TABLE Facturas(
	Id int NOT NULL,
	Fecha smalldatetime NOT NULL,
	ValorTotal numeric(18, 1) NOT NULL,
	Ciudad varchar(50) NOT NULL,
	CONSTRAINT pk_facturas PRIMARY KEY (Id)
);

CREATE TABLE DetalleFacturas(
	Id int IDENTITY(1,1) NOT NULL,
	IdFactura int NOT NULL,
	NombreProducto varchar(50) NOT NULL,
	Cantidad int NOT NULL,
	Precio numeric(18, 1) NOT NULL,
	CONSTRAINT pk_detallefacturas PRIMARY KEY (Id),
	CONSTRAINT fk_detallefacturas_facturas FOREIGN KEY (Id) REFERENCES Facturas(Id)
);