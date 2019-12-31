CREATE TABLE [dbo].[Customer] (
    [Id]                       INT           IDENTITY (1, 1) NOT NULL,
    [Name]                     NVARCHAR (50) NULL,
    [IsSubscribedToNewsLetter] BIT           NULL,
    [MembershipTypeId]         INT           NULL,
    CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Customer_MembershipType] FOREIGN KEY ([MembershipTypeId]) REFERENCES [dbo].[MembershipType] ([Id])
);

