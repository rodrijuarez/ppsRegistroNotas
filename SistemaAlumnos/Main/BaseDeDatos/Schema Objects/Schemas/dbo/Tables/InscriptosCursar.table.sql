CREATE TABLE [dbo].[InscriptosCursar](
	[idTurnosCursar] [int] NOT NULL,
	[idLegajo] [char](10) COLLATE Modern_Spanish_CI_AS NOT NULL,
	[NotaPrimParcial] [int] NULL,
	[NotaSegParcial] [int] NULL,
	[PrimerRecTipo] [int] NULL,
	[Rec1] [int] NULL,
	[SegRecTipo] [int] NULL,
	[Rec2] [int] NULL,
	[TerRecTipo] [int] NULL,
	[Rec3] [int] NULL,
	[Estado] [char](1) COLLATE Modern_Spanish_CI_AS NOT NULL CONSTRAINT [DF_InscriptosCursar_Estado]  DEFAULT ('C'),
	[EstadoCorrelatividad] [varchar](1) COLLATE Modern_Spanish_CI_AS NULL,
 CONSTRAINT [PK_InscriptosCursar] PRIMARY KEY CLUSTERED 
(
	[idTurnosCursar] ASC,
	[idLegajo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON),
 CONSTRAINT [InscriptosCursar_Alumnos] FOREIGN KEY([idLegajo])
REFERENCES [dbo].[Alumnos] ([idLegajo]),
 CONSTRAINT [InscriptosCursar_TurnosCursar] FOREIGN KEY([idTurnosCursar])
REFERENCES [dbo].[TurnosCursar] ([idTurnosCursar])
)


