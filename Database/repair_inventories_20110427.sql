/*
 * Run this script to repair iteminventories table
 * please make sure, that triggers for items, 
 * orderdetails and warehouses already in place
 * if not, please run trigger creation script
 */
delete from iteminventories
go
insert into iteminventories
select itemid,warehouses.id,quantity
from (
	select itemid, sum(CASE 
				WHEN OrderType='IA' THEN Quantity  
				WHEN OrderType='RR' THEN Quantity  
				WHEN OrderType='DO' THEN -Quantity 
				ELSE 0 END) quantity
	from Orders A join OrderDetails B on A.ID=B.OrderID
	group by itemid
	) TA
, warehouses
go
