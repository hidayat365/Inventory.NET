alter table items add 
	QuantityCarton float default 0
go
alter table orderdetails add
	TrxType int default 0,
	ReferenceID int null,
	constraint FK_OrderDetails_Reference 
		foreign key (ReferenceID) references Orders (ID)
go
alter table orderdetails 
	alter column itemid int null
go
