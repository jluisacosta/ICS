
select mp.nombre,m.tipo_movimiento
from movimientos m,detalle_movimiento dm,materias_primas mp
where m.id_movimiento = dm.id_movimiento
and dm.id_materia_prima = mp.id_materia
and m.fecha >= '2004/01/01' and m.fecha < '2004/02/01'
