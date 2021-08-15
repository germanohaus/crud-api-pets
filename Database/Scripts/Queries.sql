
-- 3) Monte uma query que selecione apenas os nomes da tabela Cats que comecem com 'c', e os nomes da tabela Dogs que terminem com 'e'.
/***************************** <3> ****************************/

select name from cats where name like 'c%'
union
select name from dogs where name like '%e'
go

/***************************** </3> ****************************/
-- 4) Selecione o registro na tabela Dogs com menor Age
/***************************** <4> ****************************/

select top 1 id,name,age,ownerid from dogs order by age
go

/***************************** </4> ****************************/
-- 5) Selecione a soma da coluna Age da tabela Cats
/***************************** <5> ****************************/

select sum(age) from cats
go

/***************************** </5> ****************************/
-- 6) Selecione os nomes dos Owner e seus respectivos Cats
/***************************** <6> ****************************/

select 
	o.name as owner_name
	, c.name as cat_name
	, c.age as cat_age
from 
	owner o
inner join
	cats c on c.ownerid = o.id
go

/***************************** </6> ****************************/
-- 7) Selecione os registros da tabela Dogs com maior Age separados por OwnerId
/***************************** <7> ****************************/

select 
	ownerid, 
	max(age) 
from 
	dogs
group by
	ownerid
order by 2 desc
go

/***************************** </7> ****************************/
--8) Retorne o nome do Owner e a respectiva quantidade de animais total
/***************************** <8> ****************************/

select 
	o.name, 
	count(pets.id) as qtdpets
from 
	owner o
inner join
	(select id,ownerid from dogs union all select id,ownerid from cats) pets
	on pets.ownerid = o.id
group by
	o.name
order by 2 desc
go

/***************************** </8> ****************************/
