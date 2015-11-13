CREATE TABLE [dbo].[InscriptosRendir](
	[idTurnosRendir] [int] NOT NULL,
	[idLegajo] [char](10) COLLATE Modern_Spanish_CI_AS NOT NULL,
	[Estado] [char](1) COLLATE Modern_Spanish_CI_AS NOT NULL,
	[FechaElegida] [smalldatetime] NOT NULL,
	[idTomo] [int] NOT NULL,
	[idFolio] [int] NOT NULL,
	[EstadoCorrelatividad] [varchar](1) COLLATE Modern_Spanish_CI_AS NULL,
 CONSTRAINT [PK_InscriptosRendir] PRIMARY KEY CLUSTERED 
(
	[idTurnosRendir] ASC,
	[idLegajo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON),
 CONSTRAINT [FK_InscriptosRendir_Alumnos] FOREIGN KEY([idLegajo])
REFERENCES [dbo].[Alumnos] ([idLegajo])
)


