/************************************************
 * Run this script and modify access rules
 * from Application Roles menu available in IMS
 ************************************************/
update applications set active = 1
where code in ('IMS-02005','IMS-02006','IMS-01004','IMS-01005')
go
insert into applicationroles
select applications.id,roles.id,0,0,0,0 from roles, applications
where applications.active = 1
and applications.id not in (select applicationid from applicationroles)
go