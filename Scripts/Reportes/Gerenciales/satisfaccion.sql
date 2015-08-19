select c.id_cliente,c.rfc,c.razon_social,v.fecha,v.total
from clientes c,facturas f,ventas v
where c.id_cliente = f.id_cliente
and f.id_venta = v.id_venta
and v.fecha >= '2004/01/01'
and v.fecha <= '2004/02/01'
order by v.fecha, c.id_cliente