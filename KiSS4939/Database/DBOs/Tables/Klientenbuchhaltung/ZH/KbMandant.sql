﻿CREATE TABLE [dbo].[KbMandant](
	[KbMandantID] [int] IDENTITY(1,1) NOT NULL,
	[Mandant] [varchar](100) NOT NULL,
	[PeriodeVon] [datetime] NOT NULL,
	[PeriodeBis] [datetime] NULL,
	[PeriodeStatusCode] [int] NOT NULL,
	[KbMandantTS] [timestamp] NOT NULL,
 CONSTRAINT [PK_KBMANDANT] PRIMARY KEY CLUSTERED 
(
	[KbMandantID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON, FILLFACTOR = 90) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING ON