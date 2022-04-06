use FixManutencaoDB
select *
from Fix_ManutencaoNew
where saida like '%2022-04-05%'

/*select *
from marcaPonto
select *
from loginUser

delete from marcaPonto */
-----------------------------------------------
/*APAGA TABELA*/
/*
DROP TABLE Fix_ManutencaoNew
*/

-----------------------------------------------
/*CRIAR UMA TABELA*/
/*
create table Fix_ManutencaoNew(
	id int primary key identity not null,
	entrada datetime2 not null,
	os varchar(50) not null,
	patrimonio varchar(50) not null,
	modelo varchar(150) not null,
	cor varchar(50) not null,
	defeito text not null,
	reparo text,
	status_tb varchar(50) not null,
	obs text,
	saida datetime2,
	laudo varchar(3) not null,
	garantia varchar(3) not null
)
*/

-----------------------------------------------
/*DELETA DADOS DA PLANILHA*/
/*delete from marcaPonto*/

-----------------------------------------------
/*APAGA COLUNA ESPECIFICA - PRIMEIRO VERIFIQUE SE NÃO É UM PK*/
/*
alter table Fix_ManutencaoNew
drop column id
*/

-----------------------------------------------
/*ADICIONA UMA NOVA COLUNA*/
/*
alter table Fix_ManutencaoNew
add last_update datetime;
*/

-----------------------------------------------
/*FILTRAR E CONTAR*/
/*
select status_tb, count(id) as Total
from Fix_ManutencaoNew
where status_tb != ''
group by status_tb
*/

-----------------------------------------------
/*ADICIONA DADOS AO BANCO DE DADOS*/
/*
insert into Fix_ManutencaoNew(entrada,os,patrimonio,modelo,cor,defeito,reparo,status_tb,obs,saida,laudo,garantia)
values 

-----------------------------------------------
/*ALTERA INFORMAÇÕES NO BANCO*/
/*
UPDATE Fix_ManutencaoNew SET laudo = 'Não' where laudo like 'No'
UPDATE Fix_ManutencaoNew SET laudo = 'Sim' where laudo like 'Yes'
UPDATE Fix_ManutencaoNew SET garantia = 'Sim' where garantia like 'Yes'
UPDATE Fix_ManutencaoNew SET garantia = 'Não' where garantia like 'No'*/
*/
