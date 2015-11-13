CREATE TABLE [dbo].[AcademicoPorParcial](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[idLegajo] [char](10) COLLATE Modern_Spanish_CI_AS NOT NULL,
	[idcarrera] [int] NOT NULL,
	[idmateria] [int] NOT NULL,
	[fecha] [smalldatetime] NOT NULL,
	[aniolectivo] [int] NOT NULL,
	[cuatrimestre] [int] NOT NULL,
	[primerparcial] [int] NULL,
	[segundoparcial] [int] NULL,
	[primerrecuptipo] [int] NULL,
	[notaprimerrecup] [int] NULL,
	[segundorecuptipo] [int] NULL,
	[notasegundorecup] [int] NULL,
	[tercerrecuptipo] [int] NULL,
	[notatercerrecup] [int] NULL,
	[estado] [char](1) COLLATE Modern_Spanish_CI_AS NOT NULL,
 CONSTRAINT [PK_Parciales] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON),
 CONSTRAINT [Parciales_Carreras] FOREIGN KEY([idcarrera])
REFERENCES [dbo].[Carreras] ([idCarrera]),
 CONSTRAINT [Parciales_Materias] FOREIGN KEY([idmateria])
REFERENCES [dbo].[Materias] ([idmateria])
)


