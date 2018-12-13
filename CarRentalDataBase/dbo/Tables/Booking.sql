CREATE TABLE [dbo].[Booking] (
    [Id]         INT      IDENTITY (1, 1) NOT NULL,
    [CarId]      INT      NULL,
    [CustomerId] INT      NULL,
    [Start]      DATETIME NOT NULL,
    [Stop]       DATETIME NOT NULL,
    CONSTRAINT [PK_Booking] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Booking_Car] FOREIGN KEY ([CarId]) REFERENCES [dbo].[Car] ([Id]),
    CONSTRAINT [FK_Booking_Customer] FOREIGN KEY ([CustomerId]) REFERENCES [dbo].[Customer] ([Id])
);

