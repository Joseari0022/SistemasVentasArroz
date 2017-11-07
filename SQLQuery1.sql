create table Facturas(
IdFactura int primary key identity (1,1),
FechaCreacion datetime,
TipoPago varchar(80),
NombreCliente varchar(80),
Descripcion varchar(80),
Cantidad decimal,
Precio decimal
)