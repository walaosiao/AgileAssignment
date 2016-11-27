CREATE TABLE [dbo].[staff] (
    [StaffID]       NVARCHAR (50) NOT NULL,
    [StaffName]     NVARCHAR (50) NULL,
    [StaffIC]       NVARCHAR (50) NULL,
    [StaffAddress]  NVARCHAR (50) NULL,
    [StaffPosition] NVARCHAR (50) NULL,
    [StaffSalary]   NVARCHAR (50) NULL,
    [StaffContact]  NVARCHAR (50) NULL,
    [Password]      NVARCHAR (50) NULL,
    [StaffStatus]   NVARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([StaffID] ASC)
);

