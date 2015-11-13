CREATE TABLE [dbo].[TurnosRendir](
	[IdTurnosRendir] [int] IDENTITY(1,1) NOT NULL,
	[IdCarrera] [int] NOT NULL,
	[IdMateria] [int] NOT NULL,
	[Turno] [char](1) COLLATE Modern_Spanish_CI_AS NOT NULL,
	[FechaPrimTurno] [smalldatetime] NOT NULL,
	[FechaSegTurno] [smalldatetime] NOT NULL,
 CONSTRAINT [PK_TurnosRendir] PRIMARY KEY CLUSTERED 
(
	[IdTurnosRendir] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON),
 CONSTRAINT [TurnosRendir_Carreras] FOREIGN KEY([IdCarrera])
REFERENCES [dbo].[Carreras] ([idCarrera]),
 CONSTRAINT [TurnosRendir_Materias] FOREIGN KEY([IdMateria])
REFERENCES [dbo].[Materias] ([idmateria])
)


