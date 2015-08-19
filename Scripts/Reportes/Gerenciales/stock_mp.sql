
select m.id_materia,m.nombre,o.costo_total
from ordenes_compra o,detalle_compra dc,materias_primas m
where dc.id_orden_compra = o.id_orden_compra
and dc.id_materia_prima = m.id_materia
and o.fecha_pedido >= '2004/01/03'and o.fecha_pedido <= '2004/01/03'