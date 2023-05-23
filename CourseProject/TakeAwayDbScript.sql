Create Database TakeAwayProject
go

Use TakeAwayProject
go

Create Table TakeAwayUsers
(
	UserId int primary key identity(1,1),
	FullName nvarchar(100),
	Username varchar(40),
	Password varchar(40),
	UserRole int /* 1: Admin, 2: Cashier */
)
go

Create Table MenuItems
(
	ItemId int primary key identity(1,1),
	ItemName nvarchar(50),
	ItemPrice float,
	ItemImagePath varchar(255)
)
go

Create Table Orders
(
	OrderId int primary key identity(1,1),
	OrderDateTime datetime,
	OrderStatus int, /* 1: In progress, 2: Submitted, 3: Cancelled */
	UserId int,
	Foreign key(UserId) References TakeAwayUsers(UserId)
)
go

Create Table OrderMenuItems
(
	OrderId int,
	ItemId int,
	primary key(OrderId, ItemId)
)
go