CREATE TABLE [dbo].[Customer] (
    [CusID]      NVARCHAR (50) NOT NULL,
    [CusName]    NVARCHAR (50) NULL,
    [CusIC]      NVARCHAR (50) NULL,
    [CusAddress] NVARCHAR (50) NULL,
    [CusEmail]   NVARCHAR (50) NULL,
    [CusContact] NVARCHAR (50) NULL,
    [CusStatus]  NVARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([CusID] ASC)
);

