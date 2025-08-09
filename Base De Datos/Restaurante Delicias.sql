--Crear Base de Datos
	CREATE DATABASE Restaurante_Delicias;

CREATE TABLE tbl_GestionPedidos 
(
	CodigoPedido INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	Fecha DATETIME,
	MenuProducto VARCHAR(50),
	Cantidad INT,
	Precio DECIMAL,
	PrecioTotal DECIMAL,
	Propina DECIMAL,
	TotalPedido DECIMAL	
);

Select * From tbl_GestionPedidos ;

INSERT INTO tbl_GestionPedidos (Fecha, MenuProducto, Cantidad, Precio, PrecioTotal, Propina, TotalPedido)
VALUES (12/07/2025, 'Menu1', 3, 1000, 2000, 20, 2200);