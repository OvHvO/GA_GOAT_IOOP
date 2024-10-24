Insert into Users(Username,Password,Roles)
values('James','123456','Customer')
Select SCOPE_IDENTITY()
from Customers

select Users.User_ID,Customers.customerUsername
from Users
Inner join Customers on Users.User_ID = Customers.User_ID

select Users.User_ID
from Users
where Users.Username='James'
