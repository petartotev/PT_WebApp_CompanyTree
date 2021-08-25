CREATE TABLE [dbo].[Employees](
[Id] [int] IDENTITY(1,1) NOT NULL,
[FirstName] [nvarchar](30) NOT NULL,
[MiddleName] [nvarchar](30),
[LastName] [nvarchar](30) NOT NULL,
[Nationality] [nvarchar](30) NOT NULL,
[Image] [nvarchar](250),
[Phone] [nvarchar](30),
[Email] [nvarchar](100),
[DateBirth] [datetime] NOT NULL,
[DateHired] [datetime] NOT NULL,
[DateCreated] [datetime],
[DateUpdated] [datetime],
[IsBoardMember] [bit] NOT NULL,
[RoleId] [int] NOT NULL,
[TeamId] [int],
CONSTRAINT [PK_Employees_Id] PRIMARY KEY CLUSTERED ([Id] ASC))

ALTER TABLE [dbo].[Employees] 
WITH CHECK ADD CONSTRAINT [FK_Employees_Roles_RoleId] 
FOREIGN KEY ([RoleId]) 
REFERENCES [dbo].[Roles] ([Id])

ALTER TABLE [dbo].[Employees] 
WITH CHECK ADD CONSTRAINT [FK_Employees_Teams_TeamId] 
FOREIGN KEY ([TeamId]) 
REFERENCES [dbo].[Teams] ([Id])

SET IDENTITY_INSERT [dbo].[Employees] ON

INSERT INTO [dbo].[Employees] ([Id], [FirstName], [LastName], [Nationality], [Image], [Phone], [Email], [DateBirth], [DateHired], [DateCreated], [DateUpdated], [IsBoardMember], [RoleId], [TeamId])
VALUES (1, 'Dennis', 'Ritchie', 'United Kingdom', 'assets/images/employees/1.jpg', '00441234567890', 'dennis.ritchie@company.com', '1970-01-01', '2012-01-01', '2021-08-22', '2021-08-22', 1, 1, NULL)

INSERT INTO [dbo].[Employees] ([Id], [FirstName], [LastName], [Nationality], [Image], [Phone], [Email], [DateBirth], [DateHired], [DateCreated], [DateUpdated], [IsBoardMember], [RoleId], [TeamId])
VALUES (2, 'Linus', 'Torvalds', 'Bulgaria', 'assets/images/employees/2.jpg', '003591234567890', 'linus.torvalds@company.com', '1987-01-02', '2013-04-05', '2021-08-22', '2021-08-22', 0, 2, NULL)

INSERT INTO [dbo].[Employees] ([Id], [FirstName], [LastName], [Nationality], [Image], [Phone], [Email], [DateBirth], [DateHired], [DateCreated], [DateUpdated], [IsBoardMember], [RoleId], [TeamId])
VALUES (3, 'Ken', 'Thompson', 'United Kingdom', 'assets/images/employees/3.jpg', '004491234567891', 'ken.thompson@company.com', '1983-04-15', '2015-12-25', '2021-08-22', '2021-08-22', 0, 3, NULL)

INSERT INTO [dbo].[Employees] ([Id], [FirstName], [LastName], [Nationality], [Image], [Phone], [Email], [DateBirth], [DateHired], [DateCreated], [DateUpdated], [IsBoardMember], [RoleId], [TeamId])
VALUES (4, 'Brian', 'Kernighan', 'United Kingdom', 'assets/images/employees/4.jpg', '004491234567892', 'brian.kernighan@company.com', '1973-08-28', '2017-11-18', '2021-08-22', '2021-08-22', 0, 3, NULL)

INSERT INTO [dbo].[Employees] ([Id], [FirstName], [LastName], [Nationality], [Image], [Phone], [Email], [DateBirth], [DateHired], [DateCreated], [DateUpdated], [IsBoardMember], [RoleId], [TeamId])
VALUES (5, 'Bill', 'Gates', 'Bulgaria', 'assets/images/employees/5.jpg', '0035991234567891', 'bill.gates@company.com', '1974-05-05', '2012-12-12', '2021-08-22', '2021-08-22', 0, 4, 1)

INSERT INTO [dbo].[Employees] ([Id], [FirstName], [LastName], [Nationality], [Image], [Phone], [Email], [DateBirth], [DateHired], [DateCreated], [DateUpdated], [IsBoardMember], [RoleId], [TeamId])
VALUES (6, 'John', 'Backus', 'Bulgaria', 'assets/images/employees/6.jpg', '0035991234567892', 'john.backus@company.com', '1985-10-25', '2014-11-10', '2021-08-22', '2021-08-22', 0, 4, 2)

INSERT INTO [dbo].[Employees] ([Id], [FirstName], [LastName], [Nationality], [Image], [Phone], [Email], [DateBirth], [DateHired], [DateCreated], [DateUpdated], [IsBoardMember], [RoleId], [TeamId])
VALUES (7, 'John', 'Kemeny', 'Bulgaria', 'assets/images/employees/7.jpg', '0035991234567893', 'john.kemeny@company.com', '1988-11-01', '2015-03-22', '2021-08-22', '2021-08-22', 0, 4, 3)

INSERT INTO [dbo].[Employees] ([Id], [FirstName], [LastName], [Nationality], [Image], [Phone], [Email], [DateBirth], [DateHired], [DateCreated], [DateUpdated], [IsBoardMember], [RoleId], [TeamId])
VALUES (8, 'Thomas', 'Kurtz', 'Bulgaria', 'assets/images/employees/8.jpg', '0035991234567894', 'thomas.kurtz@company.com', '1984-04-01', '2017-03-22', '2021-08-22', '2021-08-22', 0, 5, 1)

INSERT INTO [dbo].[Employees] ([Id], [FirstName], [LastName], [Nationality], [Image], [Phone], [Email], [DateBirth], [DateHired], [DateCreated], [DateUpdated], [IsBoardMember], [RoleId], [TeamId])
VALUES (9, 'John', 'McCarthy', 'Bulgaria', 'assets/images/employees/9.jpg', '0035991234567895', 'john.mccarthy@company.com', '1994-04-01', '2018-03-22', '2021-08-22', '2021-08-22', 0, 5, 1)

INSERT INTO [dbo].[Employees] ([Id], [FirstName], [LastName], [Nationality], [Image], [Phone], [Email], [DateBirth], [DateHired], [DateCreated], [DateUpdated], [IsBoardMember], [RoleId], [TeamId])
VALUES (10, 'Petar', 'Totev', 'Bulgaria', 'assets/images/employees/10.jpg', '0035991234567896', 'petar.totev@company.com', '1989-11-24', '2021-01-18', '2021-08-22', '2021-08-22', 0, 5, 1)

INSERT INTO [dbo].[Employees] ([Id], [FirstName], [LastName], [Nationality], [Image], [Phone], [Email], [DateBirth], [DateHired], [DateCreated], [DateUpdated], [IsBoardMember], [RoleId], [TeamId])
VALUES (11, 'Edith', 'Clarke', 'Bulgaria', 'assets/images/employees/11.jpg', '0035991234567897', 'edith.clarke@company.com', '1996-11-24', '2020-05-15', '2021-08-22', '2021-08-22', 0, 6, 1)

INSERT INTO [dbo].[Employees] ([Id], [FirstName], [LastName], [Nationality], [Image], [Phone], [Email], [DateBirth], [DateHired], [DateCreated], [DateUpdated], [IsBoardMember], [RoleId], [TeamId])
VALUES (12, 'Alan', 'Kay', 'Bulgaria', 'assets/images/employees/12.jpg', '0035991234567898', 'alan.kay@company.com', '1984-01-04', '2017-03-22', '2021-08-22', '2021-08-22', 0, 5, 2)

INSERT INTO [dbo].[Employees] ([Id], [FirstName], [LastName], [Nationality], [Image], [Phone], [Email], [DateBirth], [DateHired], [DateCreated], [DateUpdated], [IsBoardMember], [RoleId], [TeamId])
VALUES (13, 'Niklaus', 'Wirth', 'Bulgaria', 'assets/images/employees/13.jpg', '0035991234567899', 'niklaus.wirth@company.com', '1994-07-15', '2018-03-22', '2021-08-22', '2021-08-22', 0, 5, 2)

INSERT INTO [dbo].[Employees] ([Id], [FirstName], [LastName], [Nationality], [Image], [Phone], [Email], [DateBirth], [DateHired], [DateCreated], [DateUpdated], [IsBoardMember], [RoleId], [TeamId])
VALUES (14, 'James', 'Gosling', 'Bulgaria', 'assets/images/employees/14.jpg', '0035991234567887', 'james.gosling@company.com', '1989-03-27', '2021-01-18', '2021-08-22', '2021-08-22', 0, 5, 2)

INSERT INTO [dbo].[Employees] ([Id], [FirstName], [LastName], [Nationality], [Image], [Phone], [Email], [DateBirth], [DateHired], [DateCreated], [DateUpdated], [IsBoardMember], [RoleId], [TeamId])
VALUES (15, 'Guido', 'van Rossum', 'Bulgaria', 'assets/images/employees/15.jpg', '0035991234567888', 'guido.vanrossum@company.com', '1986-11-24', '2020-02-13', '2021-08-22', '2021-08-22', 0, 6, 2)

INSERT INTO [dbo].[Employees] ([Id], [FirstName], [LastName], [Nationality], [Image], [Phone], [Email], [DateBirth], [DateHired], [DateCreated], [DateUpdated], [IsBoardMember], [RoleId], [TeamId])
VALUES (16, 'Donald', 'Knuth', 'Bulgaria', 'assets/images/employees/16.jpg', '0035991234567123', 'donald.knuth@company.com', '1984-11-11', '2017-03-22', '2021-08-22', '2021-08-22', 0, 5, 3)

INSERT INTO [dbo].[Employees] ([Id], [FirstName], [LastName], [Nationality], [Image], [Phone], [Email], [DateBirth], [DateHired], [DateCreated], [DateUpdated], [IsBoardMember], [RoleId], [TeamId])
VALUES (17, 'John', 'Carmack', 'Bulgaria', 'assets/images/employees/17.jpg', '0035991234567124', 'john.carmack@company.com', '1995-03-11', '2018-03-22', '2021-08-22', '2021-08-22', 0, 5, 3)

INSERT INTO [dbo].[Employees] ([Id], [FirstName], [LastName], [Nationality], [Image], [Phone], [Email], [DateBirth], [DateHired], [DateCreated], [DateUpdated], [IsBoardMember], [RoleId], [TeamId])
VALUES (18, 'Ada', 'Lovelace', 'Bulgaria', 'assets/images/employees/18.jpg', '0035991234567125', 'ada.lovelace@company.com', '1990-08-24', '2021-08-07', '2021-08-22', '2021-08-22', 0, 5, 3)

INSERT INTO [dbo].[Employees] ([Id], [FirstName], [LastName], [Nationality], [Image], [Phone], [Email], [DateBirth], [DateHired], [DateCreated], [DateUpdated], [IsBoardMember], [RoleId], [TeamId])
VALUES (19, 'David', 'Patterson', 'Bulgaria', 'assets/images/employees/19.jpg', '0035991234567126', 'david.patterson@company.com', '1987-11-08', '2020-02-13', '2021-08-22', '2021-08-22', 0, 6, 3)

INSERT INTO [dbo].[Employees] ([Id], [FirstName], [LastName], [Nationality], [Image], [Phone], [Email], [DateBirth], [DateHired], [DateCreated], [DateUpdated], [IsBoardMember], [RoleId], [TeamId])
VALUES (20, 'Grace', 'Hopper', 'Bulgaria', 'assets/images/employees/20.jpg', '0035991234567111', 'grace.hopper@company.com', '1990-01-13', '2020-02-13', '2021-08-22', '2021-08-22', 0, 7, NULL)

SET IDENTITY_INSERT [dbo].[Employees] OFF
