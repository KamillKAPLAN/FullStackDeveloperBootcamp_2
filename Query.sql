/*
 select distinct StateProvince from SalesLT.Address
 select Count(distinct StateProvince) from SalesLT.Address
 -- select count(*) as aa from (select distinct StateProvince from SalesLT.Address) --
 select * from SalesLT.Address where StateProvince = 'Washington' and AddressLine2 is not null
 select * from SalesLT.Address where Not StateProvince = 'Washington'
 select * from SalesLT.Address where StateProvince != 'Washington'
 select * from SalesLT.Address order by City desc, StateProvince asc
 select * from SalesLT.Address where AddressLine2 is null and ModifiedDate = '2005-09-01 00:00:00.000'
 */

 -- top