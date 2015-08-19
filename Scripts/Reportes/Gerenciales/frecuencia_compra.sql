
select c.id_cliente,c.razon_social,count(f.id_factura) as cuenta,sum(v.total) as total
from clientes c,facturas f, ventas v
where c.id_cliente = f.id_cliente
and f.id_venta = v.id_venta
and f.fecha >= '2004/01/01' and f.fecha < '2004/02/01'
group by c.id_cliente
