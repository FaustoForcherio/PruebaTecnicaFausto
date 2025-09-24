# Prueba Tecnica Fausto Forcherio


Pregunta #3
Asumiendo que tiene dos tablas en SQL, una llamada Producto cuyos campos son [ID, DESCRIPCION, CODIGO], y otra llamada Descuento cuyos campos son [ID, ID_PRODUCTO, FECHA_INICIO, FECHA_FIN, PORCENTAJE] arme una query por cada uno de los siguientes requerimientos:

SELECT Producto.CODIGO,Producto.DESCRIPCION FROM Producto JOIN Descuento on Descuento.ID_PRODUCTO=Producto.ID where Descuento.PORCENTAJE>60 AND (FECHA_INICIO>GETDATE() OR Descuento.FECHA_FIN<GETDATE());

SELECT Producto.CODIGO,Producto.DESCRIPCION,Descuento.PORCENTAJE,Descuento.FECHA_INICIO,Descuento.FECHA_FIN FROM Producto JOIN Descuento ON Descuento.ID_PRODUCTO=Producto.ID WHERE (FECHA_INICIO<'2021-03-01' AND FECHA_INICIO>'2021-01-01') OR (Descuento.FECHA_FIN>'2021-01-01' AND Descuento.FECHA_FIN<'2021-03-01');

SELECT Producto.CODIGO,Producto.DESCRIPCION,Descuento.PORCENTAJE,Descuento.FECHA_INICIO,Descuento.FECHA_FIN FROM Producto JOIN Descuento ON Producto.ID = Descuento.ID_PRODUCTO WHERE Producto.CODIGO IN ('ADF32','POP79','LLE51');
