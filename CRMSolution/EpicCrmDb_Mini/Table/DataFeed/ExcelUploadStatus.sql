﻿CREATE TABLE [dbo].[ExcelUploadStatus]
(
	[Id] BIGINT NOT NULL PRIMARY KEY IDENTITY,
	[TenantId] BIGINT NOT NULL REFERENCES dbo.Tenant,
	[UploadType] NVARCHAR(50) NOT NULL,
	[UploadTable] NVARCHAR(50) NOT NULL,
	[UploadFileName] NVARCHAR(512) NOT NULL,
	[RecordCount] BIGINT NOT NULL,
	[RequestedBy] NVARCHAR(50) NOT NULL,
	[IsCompleteRefresh] BIT NOT NULL DEFAULT 0,
	[RequestTimestamp] DATETIME2 NOT NULL,
	[IsPosted] BIT NOT NULL DEFAULT 0,
	[PostingTimestamp] DATETIME2 NOT NULL,
	[LocalFileName] NVARCHAR(512) NOT NULL DEFAULT '',
	[IsParsed] BIT NOT NULL DEFAULT 0,
	[ErrorCount] INT NOT NULL DEFAULT 0,
	[IsLocked] BIT NOT NULL DEFAULT 0,
	[LockTimestamp] DATETIME2 NOT NULL DEFAULT SYSUTCDATETIME()
)
