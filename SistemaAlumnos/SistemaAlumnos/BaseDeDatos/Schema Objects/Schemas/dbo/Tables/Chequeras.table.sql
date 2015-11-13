CREATE TABLE [dbo].[Chequeras](
	[idChequera] [int] IDENTITY(1,1) NOT NULL,
	[AnioLectivo] [int] NOT NULL,
	[Cuatrimestre] [int] NOT NULL,
	[idLegajo] [char](10) COLLATE Modern_Spanish_CI_AS NOT NULL,
	[FechaPago1] [smalldatetime] NULL,
	[ImportePago1] [decimal](19, 4) NULL,
	[FechaPago2] [smalldatetime] NULL,
	[ImportePago2] [decimal](18, 0) NULL,
	[FechaPago3] [smalldatetime] NULL,
	[ImportePago3] [decimal](18, 0) NULL,
	[FechaPago4] [smalldatetime] NULL,
	[ImportePago4] [decimal](18, 0) NULL,
	[FechaPago5] [smalldatetime] NULL,
	[ImportePago5] [decimal](18, 0) NULL,
	[FechaPagoMatricula] [smalldatetime] NULL,
	[Estado] [char](10) COLLATE Modern_Spanish_CI_AS NOT NULL,
 CONSTRAINT [PK_Chequeras] PRIMARY KEY CLUSTERED 
(
	[idChequera] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON),
 CONSTRAINT [Chequeras_Alumnos] FOREIGN KEY([idLegajo])
REFERENCES [dbo].[Alumnos] ([idLegajo])
)


