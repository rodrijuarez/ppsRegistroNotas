CREATE TABLE [dbo].[Alumnos](
	[idAlumno] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[idLegajo] [char](10) COLLATE Modern_Spanish_CI_AS NOT NULL,
	[Apellido] [varchar](50) COLLATE Modern_Spanish_CI_AS NULL,
	[Nombres] [varchar](50) COLLATE Modern_Spanish_CI_AS NULL,
	[Sexo] [int] NULL,
	[idCarrera1] [int] NULL,
	[idCarrera2] [int] NULL,
	[idCarrera3] [int] NULL,
	[FechaNacim] [smalldatetime] NULL,
	[NumeroDocumento] [bigint] NULL,
	[TipoDocumento] [int] NULL,
	[DomCalle] [varchar](50) COLLATE Modern_Spanish_CI_AS NULL,
	[DomNro] [nvarchar](50) COLLATE Modern_Spanish_CI_AS NULL,
	[DomPiso] [nvarchar](50) COLLATE Modern_Spanish_CI_AS NULL,
	[DomDepto] [nvarchar](2) COLLATE Modern_Spanish_CI_AS NULL,
	[DomCodPostal] [nvarchar](10) COLLATE Modern_Spanish_CI_AS NULL,
	[DomProv] [int] NOT NULL,
	[DomLocalidad] [varchar](50) COLLATE Modern_Spanish_CI_AS NULL,
	[Mail] [varchar](50) COLLATE Modern_Spanish_CI_AS NULL,
	[Telefono] [varchar](50) COLLATE Modern_Spanish_CI_AS NULL,
	[FechaIngreso1] [smalldatetime] NULL,
	[FechaIngreso2] [smalldatetime] NULL,
	[FechaIngreso3] [smalldatetime] NULL,
	[FechaEgreso1] [smalldatetime] NULL,
	[FechaEgreso2] [smalldatetime] NULL,
	[FechaEgreso3] [smalldatetime] NULL,
	[Estado] [char](1) COLLATE Modern_Spanish_CI_AS NOT NULL,
	[Ultfechaestado] [smalldatetime] NOT NULL,
	[Trabaja] [bit] NULL,
	[EstadoCivil] [int] NULL,
	[LugarNacimiento] [varchar](50) COLLATE Modern_Spanish_CI_AS NULL,
	[FechaEgresoSecundario] [varchar](6) COLLATE Modern_Spanish_CI_AS NULL,
 CONSTRAINT [PK_Alumnos] PRIMARY KEY CLUSTERED 
(
	[idLegajo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON),
 CONSTRAINT [FK_Alumnos_Provincias] FOREIGN KEY([DomProv])
REFERENCES [dbo].[Provincias] ([idProvincia]),
 CONSTRAINT [FK_Alumnos_Sexo] FOREIGN KEY([Sexo])
REFERENCES [dbo].[Sexo] ([idSexo])
ON UPDATE CASCADE
ON DELETE CASCADE,
 CONSTRAINT [FK_Alumnos_TipoDocumento] FOREIGN KEY([TipoDocumento])
REFERENCES [dbo].[TipoDocumento] ([idTipoDocumento])
ON UPDATE CASCADE
ON DELETE CASCADE
)


