CREATE TABLE [dbo].[Profesores](
	[idProfesor] [int] NOT NULL,
	[Apellido] [varchar](50) COLLATE Modern_Spanish_CI_AS NOT NULL,
	[Nombre] [varchar](50) COLLATE Modern_Spanish_CI_AS NOT NULL,
	[FechaNacim] [smalldatetime] NULL,
	[domCalle] [varchar](50) COLLATE Modern_Spanish_CI_AS NULL,
	[domNro] [int] NULL,
	[domPiso] [int] NULL,
	[domDepto] [char](4) COLLATE Modern_Spanish_CI_AS NULL,
	[domCodPostal] [char](8) COLLATE Modern_Spanish_CI_AS NULL,
	[domProv] [int] NULL,
	[domLocalid] [varchar](50) COLLATE Modern_Spanish_CI_AS NULL,
	[Telefono] [varchar](50) COLLATE Modern_Spanish_CI_AS NULL,
	[Mail] [varchar](50) COLLATE Modern_Spanish_CI_AS NULL,
	[Estado] [char](1) COLLATE Modern_Spanish_CI_AS NULL,
 CONSTRAINT [PK_Profesores] PRIMARY KEY CLUSTERED 
(
	[idProfesor] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON),
 CONSTRAINT [FK_Profesores_Provincias] FOREIGN KEY([domProv])
REFERENCES [dbo].[Provincias] ([idProvincia])
)


