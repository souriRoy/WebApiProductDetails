

  Create table Product
(
ProductId int  Primary key not null Identity,
ProductName varchar(200) not null,
ProductPhotoPath varchar(250),
ProductPhotoName varchar(100),
ProductPrice int not null,
ProductUpdatedDate date not null
)
select * from Product

--insert into Product values ('Camera','`F:\Images','Camera',200, '2017-01-01')

--update Product
--set ProductPhotoName = 'Camera.jpg'
--where ProductId = 1

