CREATE TABLE [dbo].[Correlatividades_Rendir](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdCarrera] [int] NOT NULL,
	[IdMateria] [int] NOT NULL,
	[Rendir] [int] NOT NULL,
 CONSTRAINT [PK_Correlatividades_Rendir] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON),
 CONSTRAINT [FK_Correlatividades_Rendir_Carreras] FOREIGN KEY([IdCarrera])
REFERENCES [dbo].[Carreras] ([idCarrera]),
 CONSTRAINT [FK_Correlatividades_Rendir_Materias] FOREIGN KEY([IdMateria])
REFERENCES [dbo].[Materias] ([idmateria]),
 CONSTRAINT [FK_Correlatividades_Rendir_Materias1] FOREIGN KEY([Rendir])
REFERENCES [dbo].[Materias] ([idmateria])
)


