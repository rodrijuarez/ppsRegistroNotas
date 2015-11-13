CREATE TABLE [dbo].[Actas](
	[idtomo] [int] NOT NULL,
	[idfolio] [int] NOT NULL,
	[fecha] [smalldatetime] NOT NULL,
	[idcarrera] [int] NOT NULL,
	[idmateria] [int] NOT NULL,
	[inscriptos] [int] NOT NULL,
	[estado] [char](1) COLLATE Modern_Spanish_CI_AS NOT NULL,
	[aprobados] [int] NOT NULL,
	[ausentes] [int] NOT NULL,
	[desaprobados] [int] NOT NULL,
	[idUsuarioResponsable] [int] NOT NULL,
	[fechaIngreso] [smalldatetime] NOT NULL,
 CONSTRAINT [PK_Actas] PRIMARY KEY CLUSTERED 
(
	[idtomo] ASC,
	[idfolio] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON),
 CONSTRAINT [Actas_Carreras] FOREIGN KEY([idcarrera])
REFERENCES [dbo].[Carreras] ([idCarrera]),
 CONSTRAINT [Actas_Materias] FOREIGN KEY([idmateria])
REFERENCES [dbo].[Materias] ([idmateria])
)


