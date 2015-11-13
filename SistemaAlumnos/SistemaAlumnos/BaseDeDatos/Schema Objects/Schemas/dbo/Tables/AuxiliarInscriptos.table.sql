CREATE TABLE [dbo].[AuxiliarInscriptos](
	[IdAuxiliar] [int] NOT NULL,
	[IdLegajo] [char](10) COLLATE Modern_Spanish_CI_AS NOT NULL,
	[turno] [char](1) COLLATE Modern_Spanish_CI_AS NOT NULL,
	[estado] [char](1) COLLATE Modern_Spanish_CI_AS NOT NULL,
	[IdMateria1] [int] NULL,
	[DivMat1] [char](10) COLLATE Modern_Spanish_CI_AS NULL,
	[IdMateria2] [int] NULL,
	[DivMat2] [char](10) COLLATE Modern_Spanish_CI_AS NULL,
	[IdMateria3] [int] NULL,
	[DivMat3] [char](10) COLLATE Modern_Spanish_CI_AS NULL,
	[IdMateria4] [int] NULL,
	[DivMat4] [char](10) COLLATE Modern_Spanish_CI_AS NULL,
	[IdMateria5] [int] NULL,
	[DivMat5] [char](10) COLLATE Modern_Spanish_CI_AS NULL,
 CONSTRAINT [PK_AuxiliarInscriptos] PRIMARY KEY CLUSTERED 
(
	[IdAuxiliar] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON),
 CONSTRAINT [FK_AuxiliarInscriptos_Alumnos] FOREIGN KEY([IdLegajo])
REFERENCES [dbo].[Alumnos] ([idLegajo]),
 CONSTRAINT [FK_AuxiliarInscriptos_Materias] FOREIGN KEY([IdMateria1])
REFERENCES [dbo].[Materias] ([idmateria]),
 CONSTRAINT [FK_AuxiliarInscriptos_Materias1] FOREIGN KEY([IdMateria2])
REFERENCES [dbo].[Materias] ([idmateria]),
 CONSTRAINT [FK_AuxiliarInscriptos_Materias2] FOREIGN KEY([IdMateria3])
REFERENCES [dbo].[Materias] ([idmateria]),
 CONSTRAINT [FK_AuxiliarInscriptos_Materias3] FOREIGN KEY([IdMateria4])
REFERENCES [dbo].[Materias] ([idmateria]),
 CONSTRAINT [FK_AuxiliarInscriptos_Materias4] FOREIGN KEY([IdMateria5])
REFERENCES [dbo].[Materias] ([idmateria])
)


