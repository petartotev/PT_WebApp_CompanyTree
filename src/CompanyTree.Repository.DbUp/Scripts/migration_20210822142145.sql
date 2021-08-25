CREATE TABLE [dbo].[Roles](
[Id] [int] IDENTITY(1,1) NOT NULL,
[Name] [nvarchar](50) NOT NULL,
[Description] [nvarchar](500) NOT NULL,
[Image] [nvarchar](250),
[DateCreated] [datetime],
[DateUpdated] [datetime],
CONSTRAINT [PK_Roles_Id] PRIMARY KEY CLUSTERED ([Id] ASC))

SET IDENTITY_INSERT [dbo].[Roles] ON

INSERT INTO [dbo].[Roles]([Id], [Name], [Description], [DateCreated], [DateUpdated])
VALUES (1, 'Board Member', 'Board members memberize the board of the company.', '2021-08-22', '2021-08-22')

INSERT INTO [dbo].[Roles]([Id], [Name], [Description], [DateCreated], [DateUpdated])
VALUES (2, 'Platform Manager', 'Manager that is responsible for handling the Platform.', '2021-08-22', '2021-08-22')

INSERT INTO [dbo].[Roles]([Id], [Name], [Description], [DateCreated], [DateUpdated])
VALUES (3, 'Tribe Manager', 'Manager that is responsible for handling the Tribe.', '2021-08-22', '2021-08-22')

INSERT INTO [dbo].[Roles]([Id], [Name], [Description], [DateCreated], [DateUpdated])
VALUES (4, 'Team Lead', 'Team Leads literally lead teams. They are responsible for the friendly and open environment within their group, as well as control over the programming process.', '2021-08-22', '2021-08-22')

INSERT INTO [dbo].[Roles]([Id], [Name], [Description], [DateCreated], [DateUpdated])
VALUES (5, 'Developer', 'Developers are responsible for handling the programming process and the development of services within teams.', '2021-08-22', '2021-08-22')

INSERT INTO [dbo].[Roles]([Id], [Name], [Description], [DateCreated], [DateUpdated])
VALUES (6, 'QA', 'QA, a.k.a. Quality Assurance specialists are responsible for testing the services that the developers create.', '2021-08-22', '2021-08-22')

INSERT INTO [dbo].[Roles]([Id], [Name], [Description], [DateCreated], [DateUpdated])
VALUES (7, 'HR', 'Human Resources specialists are responsible for keeping the enviornment within the company united and friendly.', '2021-08-22', '2021-08-22')

UPDATE [dbo].[Roles]
SET [Image] = 'assets/images/roles/1.jpg'
WHERE [Id] = 1

UPDATE [dbo].[Roles]
SET [Image] = 'assets/images/roles/2.jpg'
WHERE [Id] = 2

UPDATE [dbo].[Roles]
SET [Image] = 'assets/images/roles/3.jpg'
WHERE [Id] = 3

UPDATE [dbo].[Roles]
SET [Image] = 'assets/images/roles/4.jpg'
WHERE [Id] = 4

UPDATE [dbo].[Roles]
SET [Image] = 'assets/images/roles/5.jpg'
WHERE [Id] = 5

UPDATE [dbo].[Roles]
SET [Image] = 'assets/images/roles/6.jpg'
WHERE [Id] = 6

UPDATE [dbo].[Roles]
SET [Image] = 'assets/images/roles/7.jpg'
WHERE [Id] = 7

SET IDENTITY_INSERT [dbo].[Roles] OFF
