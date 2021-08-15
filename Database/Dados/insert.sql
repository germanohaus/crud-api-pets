/***************************** owner ****************************/

INSERT INTO [dbo].owner (name) values ('Adam Smith')
go
INSERT INTO [dbo].owner (name) values ('Scott Johnson')
go
INSERT INTO [dbo].owner (name) values ('Kimberly Parker')
go

/***************************** cats ****************************/

insert into [dbo].cats (name,age,ownerid) values ('Lily',5,1)
go
insert into [dbo].cats (name,age,ownerid) values ('Chloe',2,3)
go
insert into [dbo].cats (name,age,ownerid) values ('Charlie',3,2)
go

/***************************** dogs ****************************/

insert into [dbo].dogs (name,age,ownerid) values ('Maggie',1,2)
go
insert into [dbo].dogs (name,age,ownerid) values ('Duke',7,1)
go
insert into [dbo].dogs (name,age,ownerid) values ('Buddy',4,2)
go
