CREATE TABLE [dbo].[Materias](
	[idmateria] [int] NOT NULL,
	[idcarrera] [int] NOT NULL,
	[descripcion] [varchar](50) COLLATE Modern_Spanish_CI_AS NOT NULL,
	[cargahoraria] [int] NOT NULL,
	[cuatrimestre] [int] NOT NULL,
 CONSTRAINT [PK_Materias] PRIMARY KEY CLUSTERED 
(
	[idmateria] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON),
 CONSTRAINT [Materias_Carreras] FOREIGN KEY([idcarrera])
REFERENCES [dbo].[Carreras] ([idCarrera])
)


