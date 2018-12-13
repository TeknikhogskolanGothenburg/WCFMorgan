CREATE TABLE [dbo].[Car] (
    [Id]           INT           IDENTITY (1, 1) NOT NULL,
    [LicensePlate] NVARCHAR (10) NULL,
    [Brand]        NVARCHAR (50) NULL,
    [Model]        NVARCHAR (50) NULL,
    [Year] INT NULL, 
    CONSTRAINT [PK_Car] PRIMARY KEY CLUSTERED ([Id] ASC)
);

