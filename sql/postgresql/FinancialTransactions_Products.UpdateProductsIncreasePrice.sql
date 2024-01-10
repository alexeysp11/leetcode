begin transaction isolation level read committed;
do
$$
declare 
	lMaxProductId integer;
begin
	select max(p.productid) into lMaxProductId from Products p;
	update Products
	set price = price + 1
	where productid = lMaxProductId;
end;
$$;
commit;