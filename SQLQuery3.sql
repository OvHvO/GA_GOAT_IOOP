select * from Receptionists
select * from Receptionists where rcptionistUsername='Ados' and rcptionistPW='6668'
Insert into Receptionists(rcptionistUsername,rcptionistPW,rcptionistContactNum)
values('Tan','1111','019801902')
Select Scope_Identity()
select * from Users
select count(*) 
from Users,Receptionists
where Receptionists.rcptionistUsername = 'Ados' and Receptionists.rcptionistPW = '6668'

select Roles from Users
where Username='ados' and Password='12345'