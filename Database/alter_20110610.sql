-----------------------------
-- add new column to store payment type
-- whether it cash or credit payment
-- 0 for cash and 1 for credit payment
-----------------------------
alter table orders
add PaymentValue float null default 0
go
update orders
set PaymentValue=0
go

