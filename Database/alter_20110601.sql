-----------------------------
-- add new column to store payment type
-- whether it cash or credit payment
-- 0 for cash and 1 for credit payment
-----------------------------
alter table orders
add PaymentType int null default 0
go
update orders
set PaymentType=0
go


------------------------------------
-- new invoicing reports
-- after running this script,
-- please edit application roles
-- to give access to new menus
------------------------------------
insert into applications (code, name, active)
select 'IMS-94011','Report Outstanding Sales Invoices',1 union all
select 'IMS-94012','Report Payments by Customers',1 union all
select 'IMS-94021','Report Outstanding Purchase Invoices',1 union all
select 'IMS-94022','Report Payments by Vendor',1 
go
insert into applicationroles
select applications.id,roles.id,0,0,0,0 from roles, applications
where applications.active = 1
and applications.id not in (select applicationid from applicationroles)
go
