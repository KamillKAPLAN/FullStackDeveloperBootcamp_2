/*
 select distinct StateProvince from SalesLT.Address
 select Count(distinct StateProvince) from SalesLT.Address
 -- select count(*) as aa from (select distinct StateProvince from SalesLT.Address) --
 select * from SalesLT.Address where StateProvince = 'Washington' and AddressLine2 is not null
 select * from SalesLT.Address where Not StateProvince = 'Washington'
 select * from SalesLT.Address where StateProvince != 'Washington'
 select * from SalesLT.Address order by City desc, StateProvince asc
 select * from SalesLT.Address where AddressLine2 is null and ModifiedDate = '2005-09-01 00:00:00.000'

 DBCC CHECKIDENT ('Products', RESEED, 1); --table Id restart

 -- 12.11.2022
 select count(*) as NewCity from (select distinct City from Customers )
 
 select * from Customers where City = 'Elgin'
 
 select * from Customers 
 --where Country = 'Germany' and City = 'Berlin'
 --where Country = 'Germany' or City = 'Berlin'
 where not Country = 'Germany' 
 
 select * from Customers
 --order by Country 
 --order by Country desc
 order by Country , CustomerName desc

  select * from Categories
  --where Description is not null
  where Description is null

  select top 10 * from Customers
  where Country = 'Germany'

  select Min(Price) as 'Price Min', Max(Price) as MaxPrice from Products

  select Count(*) as 'ProductCount', AVG(Price) as PriceAvg, Sum(Price) as 'Toplam Fiyat' from Products

  /* Like JOKER KARAKTERLER */
  select * from Products 
  --where Name like 'ca%'
  --where TRIM(Name) like '%rs'
  --where Name like '%er%'
  --where TRIM(Name) like 'c%s'
  --where TRIM(Name) like 'c_%'
  where TRIM(Name) like '[g-t]%'
  order by Name

  select * from Products
  --where Name = '' and Name = '' and Name = ''
  --where Name in('Chais','Chang','Ikura')
  where Name not in ('Chais','Chang','Ikura') 

  select * from Products 
  --where Price between 10 and 20
  --where Price not between 10 and 20 and CategoryId in (1,2,3)
  where Name between 'Alice Mutton' and 'Chang'
  order by Name
  
  select * from Orders
  where OrderDate between '1996-07-04' and '1996-07-16'

  select CustomerName as 'Müşteri Adı', ContactName as 'İletişim Adı', Address as 'Adres Bilgisi', City as [İl]
  from Customers as c

   -- Procut & Category
  select c.CategoryName as 'Kategori Adı', p.Name as [Ürün Adı], p.Price ÜrünFiyatı from Categories c
  inner join Products p on c.Id = p.CategoryId

  select c.Id, c.CategoryName as 'Kategori Adı', p.Name as [Ürün Adı], p.Price ÜrünFiyatı from Categories c
  left join Products p on c.Id = p.CategoryId

  select p.Id, c.CategoryName as 'Kategori Adı', p.Name as [Ürün Adı], p.Price ÜrünFiyatı from Categories c
  right join Products p on c.Id = p.CategoryId
  order by c.CategoryName 

  select c.CategoryName as 'Kategori Adı', p.Name as [Ürün Adı], p.Price ÜrünFiyatı from Categories c
  full outer join Products p on c.Id = p.CategoryId
  order by c.CategoryName 

  select * from Categories C, Products P
  where C.Id = P.CategoryId

  -- count, max, min, sum, avg metotlarını group by kullanır.
 select Country, Count(*) from Customers group by Country
 select * from Customers where Country = 'Germany'

 select CategoryId, count(Name) from Products group by CategoryId
 select * from Products where CategoryId = 4
 
 select CategoryName, COUNT(p.Name) from Products as p
 inner join Categories as c
 on p.CategoryId = c.Id
 where p.Price > 10
 group by c.CategoryName
 
 select CategoryName, SUM(p.Price) from Products as p
 inner join Categories as c
 on p.CategoryId = c.Id
 group by c.CategoryName
 having(SUM(p.Price) >10)

 select Country, Count(Id)
 from Customers
 group by Country
 having(Count(Id) >5)

 -- unions, exits, any, all, mssql functions

 insert into Products (Name, SupplierId, CategoryId, Unit) values('Bootcamp Ders deneme', 3,2,'10 boxes x 8 pieces')
 insert into Products (SupplierId, Name, CategoryId, Unit) values(2, 'Bootcamp', 6,'4 X 8 pieces')
 insert into Products values ('FullStack Bootcamp', 5, 6, '10 boxes x 8 pieces', 3)

 select getDate()

 update Products set Name = 'Bootcamp Ders', SupplierId = 5, CategoryId =9 where Id = 82
 
 delete from Products where Id in (81,82,83)

 ------ Stored Procedure
  create procedure sp_products 
  as 
  select * from Products where CategoryId in (1,2,3)
  
  exec sp_products

  create procedure sp_customers @Country nchar(40), @City nchar(50)
  as 
  select * from Customers where Country = @Country and City = @City
  
  exec sp_Customers @Country = 'Germany', @City = 'Berlin'

  create procedure sp_insertCustomer @CustomerName nchar(50), @ContactName nchar(50), 
  @Address nchar(50), @City nchar(50), @PostalCode nvarchar(50), @Country nchar(40)
  as
  insert into Customers 
  values (@CustomerName, @ContactName, @Address, @City, @PostalCode, @Country)
  
  exec sp_insertCustomer 'Kamil', 'Ev', 'Zafer Mah. Bahç. /İST.', 'İstanbul', 2435, 'Türkiye'

   create procedure sp_updateCustomer @Id int, @CustomerName nchar(50), @ContactName nchar(50) = null
   as
   update Customers 
   set CustomerName = @CustomerName, ContactName = @ContactName
   where Id = @Id
 
   exec sp_updateCustomer @Id = 92,  @CustomerName = 'KAMİL'
 */













