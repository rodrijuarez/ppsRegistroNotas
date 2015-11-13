CREATE TABLE [dbo].[TurnosCursar](
	[idTurnosCursar] [int] IDENTITY(1,1) NOT NULL,
	[AnioLectivo] [int] NOT NULL,
	[Cuatrimestre] [int] NOT NULL,
	[IdCarrera] [int] NOT NULL,
	[IdMateria] [int] NOT NULL,
	[Turno] [char](1) COLLATE Modern_Spanish_CI_AS NOT NULL,
	[Division] [char](3) COLLATE Modern_Spanish_CI_AS NOT NULL,
	[DiaDictado1] [char](2) COLLATE Modern_Spanish_CI_AS NOT NULL,
	[DiaDictado2] [char](2) COLLATE Modern_Spanish_CI_AS NULL,
	[Duracion] [char](1) COLLATE Modern_Spanish_CI_AS NOT NULL,
	[Duracion2] [char](1) COLLATE Modern_Spanish_CI_AS NULL,
	[IdProfesor] [int] NOT NULL,
 CONSTRAINT [PK_TurnosCursar] PRIMARY KEY CLUSTERED 
(
	[idTurnosCursar] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON),
 CONSTRAINT [TurnosCursar_Carreras] FOREIGN KEY([IdCarrera])
REFERENCES [dbo].[Carreras] ([idCarrera]),
 CONSTRAINT [TurnosCursar_Materias] FOREIGN KEY([IdMateria])
REFERENCES [dbo].[Materias] ([idmateria]),
 CONSTRAINT [TurnosCursar_Profesores] FOREIGN KEY([IdProfesor])
REFERENCES [dbo].[Profesores] ([idProfesor])
)


