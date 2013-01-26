------------------------------------
-- new opening balance menu
-- after running this script,
-- please edit application roles
-- to give access to new menus
------------------------------------
insert into applications (code, name, active)
select 'IMS-03101','Opening Balance Customer',1 union all
select 'IMS-03102','Opening Balance Vendor',1 
go
insert into applicationroles
select applications.id,roles.id,0,0,0,0 from roles, applications
where applications.active = 1
and applications.id not in (select applicationid from applicationroles)
go
