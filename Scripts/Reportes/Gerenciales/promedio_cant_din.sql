select v.fecha,count(v.id_venta),SUM(v.total)
from ventas v
where v.fecha >= '2004/01/01' and v.fecha < '2004/02/01'
group by v.fecha
