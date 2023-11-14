﻿CREATE TABLE [dbo].[BonusAgreementDetail](
	[Id] [bigint] NOT NULL PRIMARY KEY IDENTITY(1,1),
	[AgreementId] [bigint] NOT NULL REFERENCES [EntityAgreement]([Id]),
	[AgreementNumber] [nvarchar](50) NOT NULL,
	[AgreementDate] [datetime] NOT NULL,
	[EntityId] [bigint] NOT NULL REFERENCES [Entity]([Id]),
	[EntityName] [nvarchar](50) NOT NULL,
	[TypeName] [nvarchar](50) NOT NULL,
	[SeasonName] [nvarchar](50) NOT NULL,
	[LandSizeInAcres] [decimal](19, 2) NOT NULL,
	[RatePerKg] [decimal](19, 2) NOT NULL,
	[NetWeight] [decimal](19, 2) NOT NULL,
	[NetPaid] [decimal](19, 2) NOT NULL,
	[BonusRate] [decimal](19, 2) NOT NULL,
	[BonusAmountPayable] [decimal](19, 2) NOT NULL,
	[BonusAmountPaid] [decimal](19, 2) NOT NULL,
	[BonusStatus] [nvarchar](50) NOT NULL,
	[HQCode] [nvarchar](50) NOT NULL,
	[PaymentReference] [nvarchar](50) NULL,
	[BankAccountName] [nvarchar](50) NULL,
	[BankName] [nvarchar](50) NULL,
	[BankAccountNumber] [nvarchar](50) NULL,
	[BankIFSC] [nvarchar](50) NULL,
	[BankBranch] [nvarchar](50) NOT NULL,
	[Comments] [nvarchar](500) NULL,
	[CreatedBy] [nvarchar](50) NOT NULL,
	[UpdatedBy] [nvarchar](50) NOT NULL,
	[DateCreated] [datetime] NOT NULL,
	[DateUpdated] [datetime] NOT NULL
)
GO