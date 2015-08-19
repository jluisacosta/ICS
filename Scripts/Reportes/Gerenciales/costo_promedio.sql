

select p.id_producto,p.categoria,p.nombre,SUM(mpp.cantidad*mp.precio) as costo
from productos p, materiaporproducto mpp,materias_primas mp
where p.id_producto = mpp.id_producto
and mpp.id_materia = mp.id_materia
group by p.id_producto

