CREATE TABLE [dbo].[Aspirantes](
	[IdAspirante] [int] IDENTITY(1,1) NOT NULL,
	[Apellido] [varchar](50) COLLATE Modern_Spanish_CI_AS NOT NULL,
	[Nombres] [varchar](50) COLLATE Modern_Spanish_CI_AS NOT NULL,
	[Sexo] [char](10) COLLATE Modern_Spanish_CI_AS NOT NULL,
	[IdCarrera1] [int] NOT NULL,
	[FechaNac] [smalldatetime] NOT NULL,
	[Documento] [varchar](15) COLLATE Modern_Spanish_CI_AS NOT NULL,
	[DomCalle] [varchar](50) COLLATE Modern_Spanish_CI_AS NOT NULL,
	[DomNumero] [int] NOT NULL,
	[DomPiso] [int] NULL,
	[DomDpto] [nvarchar](2) COLLATE Modern_Spanish_CI_AS NULL,
	[DomProv] [int] NOT NULL,
	[DomLocalidad] [varchar](50) COLLATE Modern_Spanish_CI_AS NOT NULL,
	[DomCodPostal] [int] NOT NULL,
	[Mail] [varchar](50) COLLATE Modern_Spanish_CI_AS NULL,
	[Telefono] [varchar](50) COLLATE Modern_Spanish_CI_AS NOT NULL,
	[FechaCursoIngreso] [smalldatetime] NOT NULL,
	[Turno] [char](1) COLLATE Modern_Spanish_CI_AS NULL,
	[Division] [char](10) COLLATE Modern_Spanish_CI_AS NULL,
	[Ex1LC] [int] NULL,
	[Ex2LC] [int] NULL,
	[Ex1MA] [int] NULL,
	[Ex2MA] [int] NULL,
	[Ex1AL] [int] NULL,
	[Ex2AL] [int] NULL,
	[Condicion] [char](1) COLLATE Modern_Spanish_CI_AS NOT NULL,
	[Estado] [char](1) COLLATE Modern_Spanish_CI_AS NULL,
	[UltFechaEstado] [smalldatetime] NOT NULL,
 CONSTRAINT [PK_Aspirantes] PRIMARY KEY CLUSTERED 
(
	[IdAspirante] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON),
 CONSTRAINT [FK_Aspirantes_Carreras] FOREIGN KEY([IdCarrera1])
REFERENCES [dbo].[Carreras] ([idCarrera]),
 CONSTRAINT [FK_Aspirantes_Provincias] FOREIGN KEY([DomProv])
REFERENCES [dbo].[Provincias] ([idProvincia])
)


