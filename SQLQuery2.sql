--Select 
--ANSII
Select ContactName Adi,CompanyName Sirketadi,City Sehir from Customers

Select * from Customers where City = 'Berlin'

-- case insensitive
select * from Products where CategoryID =1 or CategoryID =3

select * from Products where CategoryID =1 and UnitPrice>=10

select * from Products order by UnitPrice asc  --ascending
select * from Products order by UnitPrice desc  --descending

select * from Products where CategoryID =1 order by UnitPrice desc

select count (*) from Products
select count (*) Adet from Products where CategoryID =2


select count (*) Adet from Products      
select CategoryID from Products group by CategoryID   -- Bütün kategorileri tekrar etmeden listele
select CategoryID,count(*) from Products group by CategoryID --Hangi kategoride kaç farklı ürün var?


select CategoryID,count(*) from Products group by CategoryID  having count (*)<10 --İçerisinde 10 taneden az olan ürün kategorisini listele

select CategoryID,count(*) from Products where UnitPrice>20 group by CategoryID  having count (*)<10

select * from Products inner join Categories on Products.CategoryID = Categories.CategoryID
select Products.ProductID,Products.ProductName,Products.UnitPrice,Categories.CategoryName from Products inner join Categories on Products.CategoryID = Categories.CategoryID
select Products.ProductID,Products.ProductName,Products.UnitPrice,Categories.CategoryName from Products inner join Categories on Products.CategoryID = Categories.CategoryID where Products.UnitPrice>10
--DTO Data Transformation object

select * from Products p inner join [Order Details] od on p.ProductID = od.ProductID
select * from Products p left join [Order Details] od on p.ProductID = od.ProductID

select * from Customers c left join Orders o on c.CustomerID =o.CustomerID
select * from Customers c left join Orders o on c.CustomerID =o.CustomerID where o.CustomerID is null  --Sisteme kayıt olan fakat ürün almayan müşterinin ona özel indirim olması durumu.

select * from Products p inner join [Order Details] od on p.ProductID = od.ProductID inner join Orders o on o.OrderID = od.OrderID




