CREATE TABLE [dbo].[Teams](
[Id] [int] IDENTITY(1,1) NOT NULL,
[Name] [nvarchar](25) NOT NULL,
[Description] [nvarchar](500) NOT NULL,
[Image] [nvarchar](250) NOT NULL,
[DateEstablished] [datetime] NOT NULL,
[DateCreated] [datetime],
[DateUpdated] [datetime],
CONSTRAINT [PK_Teams_Id] PRIMARY KEY CLUSTERED ([Id] ASC))

SET IDENTITY_INSERT [dbo].[Teams] ON

INSERT INTO [dbo].Teams([Id], [Name], [Description], [Image], [DateEstablished], [DateCreated], [DateUpdated])
VALUES (1, 'Infinity', 'Team Infinity is responsible for Company.Cashier service.', './images/teams/team_infinity.jpg', '2012-01-01', '2021-08-22', '2021-08-22')

INSERT INTO [dbo].Teams([Id], [Name], [Description], [Image], [DateEstablished], [DateCreated], [DateUpdated])
VALUES (2, 'Team-X', 'Team-X is responsible for Company.BetRT service.', './images/teams/team_team-x.jpg', '2012-02-03', '2021-08-22', '2021-08-22')

INSERT INTO [dbo].Teams([Id], [Name], [Description], [Image], [DateEstablished], [DateCreated], [DateUpdated])
VALUES (3, 'Vanguard', 'Team Vanguard is responsible for the deeds of the wallet service.', './images/teams/team_vanguard.jpg', '2013-04-27', '2021-08-22', '2021-08-22')

SET IDENTITY_INSERT [dbo].[Teams] OFF
