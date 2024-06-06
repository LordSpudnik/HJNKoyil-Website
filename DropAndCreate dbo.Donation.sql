--USE [aspnet-HJNKoyil-45a241ea-ba8c-4909-99ab-d9d394944ed7]
--GO

--/****** Object: Table [dbo].[Donation] Script Date: 03-06-2024 15:38:06 ******/
--SET ANSI_NULLS ON
--GO

--SET QUOTED_IDENTIFIER ON
--GO

--DROP TABLE [dbo].[Donation];


--GO
--CREATE TABLE [dbo].[Donation] (
--    [Id]            INT            IDENTITY (1, 1) NOT NULL,
--    [DonatedBy]     INT            NULL,
--    [AmountDonated] MONEY          NULL,
--    [DonationType]  INT            NULL,
--    [ReferenceInfo] NVARCHAR (255) NULL,
--    [DonatedDate]   DATETIME2 (0)  NULL,
--    [Comments]      NVARCHAR (255) NULL,
--    [IsActive]      BIT            NULL,
--    [CollectedBy]   INT            NULL,
--    [CreatedBy]     INT            NULL,
--    [CreatedDate]   DATETIME2 (0)  NULL,
--    [ModifiedBy]    INT            NULL,
--    [ModifiedDate]  DATETIME2 (0)  NULL
--);


ALTER TABLE [dbo].[Donation]
ADD FOREIGN KEY (DonationType) REFERENCES CommonMasterDtl(ID);
