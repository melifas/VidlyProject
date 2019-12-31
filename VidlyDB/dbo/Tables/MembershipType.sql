CREATE TABLE [dbo].[MembershipType] (
    [Id]               INT           IDENTITY (1, 1) NOT NULL,
    [SignUpFee]        NCHAR (10)    NULL,
    [DurationInMonths] INT           NULL,
    [DiscountRate]     INT           NULL,
    [Name]             NVARCHAR (50) NULL,
    CONSTRAINT [PK_MembershipType] PRIMARY KEY CLUSTERED ([Id] ASC)
);

