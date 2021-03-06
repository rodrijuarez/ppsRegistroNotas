/****** Object:  Table [dbo].[AcademicoPorExamen]    Script Date: 31/08/2013 01:06:36 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[AcademicoPorExamen](
	[idtomo] [int] NOT NULL,
	[idfolio] [int] NOT NULL,
	[idlegajo] [char](10) NOT NULL,
	[nota] [int] NULL,
 CONSTRAINT [PK_Finales] PRIMARY KEY CLUSTERED 
(
	[idlegajo] ASC,
	[idtomo] ASC,
	[idfolio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[AcademicoPorParcial]    Script Date: 31/08/2013 01:06:36 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[AcademicoPorParcial](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[idLegajo] [char](10) NOT NULL,
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
	[estado] [char](1) NOT NULL,
 CONSTRAINT [PK_Parciales] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Actas]    Script Date: 31/08/2013 01:06:36 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Actas](
	[idtomo] [int] NOT NULL,
	[idfolio] [int] NOT NULL,
	[fecha] [date] NOT NULL,
	[idcarrera] [int] NOT NULL,
	[idmateria] [int] NOT NULL,
	[inscriptos] [int] NOT NULL,
	[estado] [char](1) NOT NULL,
	[aprobados] [int] NOT NULL,
	[ausentes] [int] NOT NULL,
	[desaprobados] [int] NOT NULL,
	[idUsuarioResponsable] [int] NOT NULL,
	[fechaIngreso] [date] NOT NULL,
 CONSTRAINT [PK_Actas] PRIMARY KEY CLUSTERED 
(
	[idtomo] ASC,
	[idfolio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Alumnos]    Script Date: 31/08/2013 01:06:36 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Alumnos](
	[idAlumno] [int] IDENTITY(1,1) NOT NULL,
	[idLegajo] [char](10) NOT NULL,
	[Apellido] [varchar](50) NULL,
	[Nombres] [varchar](50) NULL,
	[Sexo] [int] NULL,
	[idCarrera1] [int] NULL,
	[idCarrera2] [int] NULL,
	[idCarrera3] [int] NULL,
	[FechaNacim] [date] NULL,
	[NumeroDocumento] [bigint] NULL,
	[TipoDocumento] [int] NULL,
	[DomCalle] [varchar](50) NULL,
	[DomNro] [nvarchar](50) NULL,
	[DomPiso] [nvarchar](50) NULL,
	[DomDepto] [nvarchar](2) NULL,
	[DomCodPostal] [nvarchar](10) NULL,
	[DomProv] [int] NOT NULL,
	[DomLocalidad] [varchar](50) NULL,
	[Mail] [varchar](50) NULL,
	[Telefono] [varchar](50) NULL,
	[FechaIngreso1] [date] NULL,
	[FechaIngreso2] [date] NULL,
	[FechaIngreso3] [date] NULL,
	[FechaEgreso1] [date] NULL,
	[FechaEgreso2] [date] NULL,
	[FechaEgreso3] [date] NULL,
	[Estado] [char](1) NOT NULL,
	[Ultfechaestado] [date] NOT NULL,
	[Trabaja] [bit] NULL,
	[EstadoCivil] [int] NULL,
	[LugarNacimiento] [varchar](50) NULL,
	[FechaEgresoSecundario] [date] NULL,
 CONSTRAINT [PK_Alumnos] PRIMARY KEY CLUSTERED 
(
	[idLegajo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Aspirantes]    Script Date: 31/08/2013 01:06:36 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Aspirantes](
	[IdAspirante] [int] IDENTITY(1,1) NOT NULL,
	[Apellido] [varchar](50) NOT NULL,
	[Nombres] [varchar](50) NOT NULL,
	[Sexo] [char](10) NOT NULL,
	[IdCarrera1] [int] NOT NULL,
	[FechaNac] [date] NOT NULL,
	[Documento] [varchar](15) NOT NULL,
	[DomCalle] [varchar](50) NOT NULL,
	[DomNumero] [int] NOT NULL,
	[DomPiso] [int] NULL,
	[DomDpto] [nvarchar](2) NULL,
	[DomProv] [int] NOT NULL,
	[DomLocalidad] [varchar](50) NOT NULL,
	[DomCodPostal] [int] NOT NULL,
	[Mail] [varchar](50) NULL,
	[Telefono] [varchar](50) NOT NULL,
	[FechaCursoIngreso] [date] NOT NULL,
	[Turno] [char](1) NULL,
	[Division] [char](10) NULL,
	[Ex1LC] [int] NULL,
	[Ex2LC] [int] NULL,
	[Ex1MA] [int] NULL,
	[Ex2MA] [int] NULL,
	[Ex1AL] [int] NULL,
	[Ex2AL] [int] NULL,
	[Condicion] [char](1) NOT NULL,
	[Estado] [char](1) NULL,
	[UltFechaEstado] [date] NOT NULL,
 CONSTRAINT [PK_Aspirantes] PRIMARY KEY CLUSTERED 
(
	[IdAspirante] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[AuxiliarInscriptos]    Script Date: 31/08/2013 01:06:36 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[AuxiliarInscriptos](
	[IdAuxiliar] [int] IDENTITY(1,1) NOT NULL,
	[IdLegajo] [char](10) NOT NULL,
	[turno] [char](1) NOT NULL,
	[estado] [char](1) NOT NULL,
	[IdMateria1] [int] NULL,
	[DivMat1] [char](10) NULL,
	[IdMateria2] [int] NULL,
	[DivMat2] [char](10) NULL,
	[IdMateria3] [int] NULL,
	[DivMat3] [char](10) NULL,
	[IdMateria4] [int] NULL,
	[DivMat4] [char](10) NULL,
	[IdMateria5] [int] NULL,
	[DivMat5] [char](10) NULL,
 CONSTRAINT [PK_AuxiliarInscriptos] PRIMARY KEY CLUSTERED 
(
	[IdAuxiliar] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Bibliografia]    Script Date: 31/08/2013 01:06:36 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Bibliografia](
	[IdLibro] [int] IDENTITY(1,1) NOT NULL,
	[Titulo] [varchar](150) NULL,
	[Autor1] [varchar](50) NULL,
	[Autor2] [varchar](50) NULL,
	[Autor3] [varchar](50) NULL,
	[NumeroISBN] [varchar](50) NULL,
	[Editorial] [varchar](50) NULL,
	[AñoEdicion] [int] NULL,
	[Estado] [char](1) NULL,
	[MotivoBaja] [varchar](250) NULL,
	[IdlegajoPrestado] [int] NULL,
	[FechaPrestado] [date] NULL,
	[FechaDevolucion] [date] NULL,
 CONSTRAINT [PK_Bibliografia] PRIMARY KEY CLUSTERED 
(
	[IdLibro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Carreras]    Script Date: 31/08/2013 01:06:36 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Carreras](
	[idCarrera] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](50) NOT NULL,
	[duracion] [int] NULL,
	[fechacreacion] [date] NULL,
	[fechanovigencia] [date] NULL,
	[ordenanza] [varchar](10) NULL,
	[totalhoras] [int] NULL,
	[cantmaterias] [int] NULL,
 CONSTRAINT [PK_Carreras] PRIMARY KEY CLUSTERED 
(
	[idCarrera] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Chequeras]    Script Date: 31/08/2013 01:06:36 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Chequeras](
	[idChequera] [int] IDENTITY(1,1) NOT NULL,
	[AnioLectivo] [int] NOT NULL,
	[Cuatrimestre] [int] NOT NULL,
	[idLegajo] [char](10) NOT NULL,
	[FechaPago1] [date] NULL,
	[ImportePago1] [decimal](19, 4) NULL,
	[FechaPago2] [date] NULL,
	[ImportePago2] [decimal](18, 0) NULL,
	[FechaPago3] [date] NULL,
	[ImportePago3] [decimal](18, 0) NULL,
	[FechaPago4] [date] NULL,
	[ImportePago4] [decimal](18, 0) NULL,
	[FechaPago5] [date] NULL,
	[ImportePago5] [decimal](18, 0) NULL,
	[FechaPagoMatricula] [date] NULL,
	[Estado] [char](10) NOT NULL,
 CONSTRAINT [PK_Chequeras] PRIMARY KEY CLUSTERED 
(
	[idChequera] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Correlatividades]    Script Date: 31/08/2013 01:06:36 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Correlatividades](
	[IdCarrera] [int] NOT NULL,
	[IdCodMateria] [int] NOT NULL,
	[IdCodMateriaCursar1] [int] NULL,
	[EstadoC1] [int] NULL,
	[IdCodMateriaCursar2] [int] NULL,
	[EstadoC2] [int] NULL,
	[IdCodMateriaCursar3] [int] NULL,
	[EstadoC3] [int] NULL,
	[IdCodMateriaCursar4] [int] NULL,
	[EstadoC4] [int] NULL,
	[IdCodMateriaCursar5] [int] NULL,
	[EstadoC5] [int] NULL,
	[IdCodMateriaCursar6] [int] NULL,
	[Estado6] [int] NULL,
	[IdCodMateriaRendir1] [int] NULL,
	[EstadoR1] [int] NULL,
	[IdCodMateriaRendir2] [int] NULL,
	[EstadoR2] [int] NULL,
	[IdCodMateriaRendir3] [int] NULL,
	[EstadoR3] [int] NULL,
	[IdCodMateriaRendir4] [int] NULL,
	[EstadoR4] [int] NULL,
	[IdCodMateriaRendir5] [int] NULL,
	[EstadoR5] [int] NULL,
	[IdCodMateriaRendir6] [int] NULL,
	[EstadoR6] [int] NULL,
 CONSTRAINT [PK_Correlatividades] PRIMARY KEY CLUSTERED 
(
	[IdCarrera] ASC,
	[IdCodMateria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Correlatividades_Aprobada]    Script Date: 31/08/2013 01:06:36 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Correlatividades_Aprobada](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdCarrera] [int] NOT NULL,
	[IdMateria] [int] NOT NULL,
	[Aprobada] [int] NOT NULL,
 CONSTRAINT [PK_Correlatividades_Aprobada] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Correlatividades_Cursada]    Script Date: 31/08/2013 01:06:36 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Correlatividades_Cursada](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdCarrera] [int] NOT NULL,
	[IdMateria] [int] NOT NULL,
	[Cursada] [int] NOT NULL,
 CONSTRAINT [PK_Correlatividades_Cursada] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Correlatividades_Rendir]    Script Date: 31/08/2013 01:06:36 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Correlatividades_Rendir](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdCarrera] [int] NOT NULL,
	[IdMateria] [int] NOT NULL,
	[Rendir] [int] NOT NULL,
 CONSTRAINT [PK_Correlatividades_Rendir] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[InscriptosCursar]    Script Date: 31/08/2013 01:06:36 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[InscriptosCursar](
	[idTurnosCursar] [int] NOT NULL,
	[idLegajo] [char](10) NOT NULL,
	[NotaPrimParcial] [int] NULL,
	[NotaSegParcial] [int] NULL,
	[PrimerRecTipo] [int] NULL,
	[Rec1] [int] NULL,
	[SegRecTipo] [int] NULL,
	[Rec2] [int] NULL,
	[TerRecTipo] [int] NULL,
	[Rec3] [int] NULL,
	[Estado] [char](1) NOT NULL,
	[EstadoCorrelatividad] [char](10) NULL,
 CONSTRAINT [PK_InscriptosCursar] PRIMARY KEY CLUSTERED 
(
	[idTurnosCursar] ASC,
	[idLegajo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[InscriptosRendir]    Script Date: 31/08/2013 01:06:36 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[InscriptosRendir](
	[idTurnosRendir] [int] NOT NULL,
	[idLegajo] [char](10) NOT NULL,
	[Estado] [char](1) NOT NULL,
	[FechaElegida] [smalldatetime] NOT NULL,
	[idTomo] [int] NOT NULL,
	[idFolio] [int] NOT NULL,
	[EstadoCorrelatividad] [varchar](1) NULL,
 CONSTRAINT [PK_InscriptosRendir] PRIMARY KEY CLUSTERED 
(
	[idTurnosRendir] ASC,
	[idLegajo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Materias]    Script Date: 31/08/2013 01:06:36 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Materias](
	[idmateria] [int] IDENTITY(1,1) NOT NULL,
	[idcarrera] [int] NOT NULL,
	[descripcion] [varchar](50) NOT NULL,
	[cargahoraria] [int] NOT NULL,
	[cuatrimestre] [int] NOT NULL,
 CONSTRAINT [PK_Materias] PRIMARY KEY CLUSTERED 
(
	[idmateria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ParametrosSistema]    Script Date: 31/08/2013 01:06:36 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ParametrosSistema](
	[UltimoLegajo] [int] NULL,
	[FechaUltimoLegajo] [smalldatetime] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Profesores]    Script Date: 31/08/2013 01:06:36 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Profesores](
	[idProfesor] [int] IDENTITY(1,1) NOT NULL,
	[Apellido] [varchar](50) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[FechaNacim] [smalldatetime] NULL,
	[domCalle] [varchar](50) NULL,
	[domNro] [int] NULL,
	[domPiso] [int] NULL,
	[domDepto] [char](4) NULL,
	[domCodPostal] [char](8) NULL,
	[domProv] [int] NULL,
	[domLocalid] [varchar](50) NULL,
	[Telefono] [varchar](50) NULL,
	[Mail] [varchar](50) NULL,
	[Estado] [char](1) NULL,
 CONSTRAINT [PK_Profesores] PRIMARY KEY CLUSTERED 
(
	[idProfesor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Provincias]    Script Date: 31/08/2013 01:06:36 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Provincias](
	[idProvincia] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Provincias] PRIMARY KEY CLUSTERED 
(
	[idProvincia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Sexo]    Script Date: 31/08/2013 01:06:36 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Sexo](
	[idSexo] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Sexo] PRIMARY KEY CLUSTERED 
(
	[idSexo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TipoDocumento]    Script Date: 31/08/2013 01:06:36 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TipoDocumento](
	[idTipoDocumento] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](20) NOT NULL,
 CONSTRAINT [PK_TipoDocumento] PRIMARY KEY CLUSTERED 
(
	[idTipoDocumento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TurnosCursar]    Script Date: 31/08/2013 01:06:36 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TurnosCursar](
	[idTurnosCursar] [int] IDENTITY(1,1) NOT NULL,
	[AnioLectivo] [int] NOT NULL,
	[Cuatrimestre] [int] NOT NULL,
	[IdCarrera] [int] NOT NULL,
	[IdMateria] [int] NOT NULL,
	[Turno] [char](1) NOT NULL,
	[Division] [char](3) NOT NULL,
	[DiaDictado1] [char](2) NOT NULL,
	[DiaDictado2] [char](2) NULL,
	[Duracion] [char](1) NOT NULL,
	[Duracion2] [char](1) NULL,
	[IdProfesor] [int] NOT NULL,
 CONSTRAINT [PK_TurnosCursar] PRIMARY KEY CLUSTERED 
(
	[idTurnosCursar] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TurnosRendir]    Script Date: 31/08/2013 01:06:36 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TurnosRendir](
	[IdTurnosRendir] [int] IDENTITY(1,1) NOT NULL,
	[IdCarrera] [int] NOT NULL,
	[IdMateria] [int] NOT NULL,
	[Turno] [char](1) NOT NULL,
	[FechaPrimTurno] [smalldatetime] NOT NULL,
	[FechaSegTurno] [smalldatetime] NOT NULL,
 CONSTRAINT [PK_TurnosRendir] PRIMARY KEY CLUSTERED 
(
	[IdTurnosRendir] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[UltimoTomoFolio]    Script Date: 31/08/2013 01:06:36 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UltimoTomoFolio](
	[IdUltimo] [int] IDENTITY(1,1) NOT NULL,
	[UltimoTomoGenerado] [int] NOT NULL,
	[UltimoFolioGenerado] [int] NOT NULL,
	[UltimoTomoFolioFechaCreacion] [date] NOT NULL,
	[FechaGeneracionActa] [date] NOT NULL,
 CONSTRAINT [PK_UltimoTomoFolio] PRIMARY KEY CLUSTERED 
(
	[IdUltimo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 31/08/2013 01:06:36 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Usuarios](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Apellido] [varchar](50) NOT NULL,
	[Nivel] [int] NOT NULL,
	[Password] [varchar](50) NOT NULL,
	[Usuario] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Usuarios] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[InscriptosCursar] ADD  CONSTRAINT [DF_InscriptosCursar_Estado]  DEFAULT ('C') FOR [Estado]
GO
ALTER TABLE [dbo].[AcademicoPorExamen]  WITH NOCHECK ADD  CONSTRAINT [Finales_Actas] FOREIGN KEY([idtomo], [idfolio])
REFERENCES [dbo].[Actas] ([idtomo], [idfolio])
GO
ALTER TABLE [dbo].[AcademicoPorExamen] CHECK CONSTRAINT [Finales_Actas]
GO
ALTER TABLE [dbo].[AcademicoPorExamen]  WITH NOCHECK ADD  CONSTRAINT [Finales_Alumnos] FOREIGN KEY([idlegajo])
REFERENCES [dbo].[Alumnos] ([idLegajo])
GO
ALTER TABLE [dbo].[AcademicoPorExamen] CHECK CONSTRAINT [Finales_Alumnos]
GO
ALTER TABLE [dbo].[AcademicoPorParcial]  WITH NOCHECK ADD  CONSTRAINT [Parciales_Carreras] FOREIGN KEY([idcarrera])
REFERENCES [dbo].[Carreras] ([idCarrera])
GO
ALTER TABLE [dbo].[AcademicoPorParcial] CHECK CONSTRAINT [Parciales_Carreras]
GO
ALTER TABLE [dbo].[AcademicoPorParcial]  WITH NOCHECK ADD  CONSTRAINT [Parciales_Materias] FOREIGN KEY([idmateria])
REFERENCES [dbo].[Materias] ([idmateria])
GO
ALTER TABLE [dbo].[AcademicoPorParcial] CHECK CONSTRAINT [Parciales_Materias]
GO
ALTER TABLE [dbo].[Actas]  WITH NOCHECK ADD  CONSTRAINT [Actas_Carreras] FOREIGN KEY([idcarrera])
REFERENCES [dbo].[Carreras] ([idCarrera])
GO
ALTER TABLE [dbo].[Actas] CHECK CONSTRAINT [Actas_Carreras]
GO
ALTER TABLE [dbo].[Actas]  WITH NOCHECK ADD  CONSTRAINT [Actas_Materias] FOREIGN KEY([idmateria])
REFERENCES [dbo].[Materias] ([idmateria])
GO
ALTER TABLE [dbo].[Actas] CHECK CONSTRAINT [Actas_Materias]
GO
ALTER TABLE [dbo].[Alumnos]  WITH NOCHECK ADD  CONSTRAINT [FK_Alumnos_Provincias] FOREIGN KEY([DomProv])
REFERENCES [dbo].[Provincias] ([idProvincia])
GO
ALTER TABLE [dbo].[Alumnos] CHECK CONSTRAINT [FK_Alumnos_Provincias]
GO
ALTER TABLE [dbo].[Alumnos]  WITH CHECK ADD  CONSTRAINT [FK_Alumnos_Sexo] FOREIGN KEY([Sexo])
REFERENCES [dbo].[Sexo] ([idSexo])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Alumnos] CHECK CONSTRAINT [FK_Alumnos_Sexo]
GO
ALTER TABLE [dbo].[Alumnos]  WITH CHECK ADD  CONSTRAINT [FK_Alumnos_TipoDocumento] FOREIGN KEY([TipoDocumento])
REFERENCES [dbo].[TipoDocumento] ([idTipoDocumento])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Alumnos] CHECK CONSTRAINT [FK_Alumnos_TipoDocumento]
GO
ALTER TABLE [dbo].[Aspirantes]  WITH NOCHECK ADD  CONSTRAINT [FK_Aspirantes_Carreras] FOREIGN KEY([IdCarrera1])
REFERENCES [dbo].[Carreras] ([idCarrera])
GO
ALTER TABLE [dbo].[Aspirantes] CHECK CONSTRAINT [FK_Aspirantes_Carreras]
GO
ALTER TABLE [dbo].[Aspirantes]  WITH NOCHECK ADD  CONSTRAINT [FK_Aspirantes_Provincias] FOREIGN KEY([DomProv])
REFERENCES [dbo].[Provincias] ([idProvincia])
GO
ALTER TABLE [dbo].[Aspirantes] CHECK CONSTRAINT [FK_Aspirantes_Provincias]
GO
ALTER TABLE [dbo].[AuxiliarInscriptos]  WITH NOCHECK ADD  CONSTRAINT [FK_AuxiliarInscriptos_Alumnos] FOREIGN KEY([IdLegajo])
REFERENCES [dbo].[Alumnos] ([idLegajo])
GO
ALTER TABLE [dbo].[AuxiliarInscriptos] CHECK CONSTRAINT [FK_AuxiliarInscriptos_Alumnos]
GO
ALTER TABLE [dbo].[AuxiliarInscriptos]  WITH NOCHECK ADD  CONSTRAINT [FK_AuxiliarInscriptos_Materias] FOREIGN KEY([IdMateria1])
REFERENCES [dbo].[Materias] ([idmateria])
GO
ALTER TABLE [dbo].[AuxiliarInscriptos] NOCHECK CONSTRAINT [FK_AuxiliarInscriptos_Materias]
GO
ALTER TABLE [dbo].[AuxiliarInscriptos]  WITH NOCHECK ADD  CONSTRAINT [FK_AuxiliarInscriptos_Materias1] FOREIGN KEY([IdMateria2])
REFERENCES [dbo].[Materias] ([idmateria])
GO
ALTER TABLE [dbo].[AuxiliarInscriptos] NOCHECK CONSTRAINT [FK_AuxiliarInscriptos_Materias1]
GO
ALTER TABLE [dbo].[AuxiliarInscriptos]  WITH NOCHECK ADD  CONSTRAINT [FK_AuxiliarInscriptos_Materias2] FOREIGN KEY([IdMateria3])
REFERENCES [dbo].[Materias] ([idmateria])
GO
ALTER TABLE [dbo].[AuxiliarInscriptos] NOCHECK CONSTRAINT [FK_AuxiliarInscriptos_Materias2]
GO
ALTER TABLE [dbo].[AuxiliarInscriptos]  WITH NOCHECK ADD  CONSTRAINT [FK_AuxiliarInscriptos_Materias3] FOREIGN KEY([IdMateria4])
REFERENCES [dbo].[Materias] ([idmateria])
GO
ALTER TABLE [dbo].[AuxiliarInscriptos] CHECK CONSTRAINT [FK_AuxiliarInscriptos_Materias3]
GO
ALTER TABLE [dbo].[AuxiliarInscriptos]  WITH NOCHECK ADD  CONSTRAINT [FK_AuxiliarInscriptos_Materias4] FOREIGN KEY([IdMateria5])
REFERENCES [dbo].[Materias] ([idmateria])
GO
ALTER TABLE [dbo].[AuxiliarInscriptos] NOCHECK CONSTRAINT [FK_AuxiliarInscriptos_Materias4]
GO
ALTER TABLE [dbo].[Bibliografia]  WITH CHECK ADD  CONSTRAINT [FK_Bibliografia_Profesores] FOREIGN KEY([IdlegajoPrestado])
REFERENCES [dbo].[Profesores] ([idProfesor])
GO
ALTER TABLE [dbo].[Bibliografia] CHECK CONSTRAINT [FK_Bibliografia_Profesores]
GO
ALTER TABLE [dbo].[Chequeras]  WITH NOCHECK ADD  CONSTRAINT [Chequeras_Alumnos] FOREIGN KEY([idLegajo])
REFERENCES [dbo].[Alumnos] ([idLegajo])
GO
ALTER TABLE [dbo].[Chequeras] CHECK CONSTRAINT [Chequeras_Alumnos]
GO
ALTER TABLE [dbo].[Correlatividades_Aprobada]  WITH NOCHECK ADD  CONSTRAINT [FK_Correlatividades_Aprobada_Carreras] FOREIGN KEY([IdCarrera])
REFERENCES [dbo].[Carreras] ([idCarrera])
GO
ALTER TABLE [dbo].[Correlatividades_Aprobada] CHECK CONSTRAINT [FK_Correlatividades_Aprobada_Carreras]
GO
ALTER TABLE [dbo].[Correlatividades_Aprobada]  WITH CHECK ADD  CONSTRAINT [FK_Correlatividades_Aprobada_Materias] FOREIGN KEY([IdMateria])
REFERENCES [dbo].[Materias] ([idmateria])
GO
ALTER TABLE [dbo].[Correlatividades_Aprobada] CHECK CONSTRAINT [FK_Correlatividades_Aprobada_Materias]
GO
ALTER TABLE [dbo].[Correlatividades_Aprobada]  WITH CHECK ADD  CONSTRAINT [FK_Correlatividades_Aprobada_Materias1] FOREIGN KEY([Aprobada])
REFERENCES [dbo].[Materias] ([idmateria])
GO
ALTER TABLE [dbo].[Correlatividades_Aprobada] CHECK CONSTRAINT [FK_Correlatividades_Aprobada_Materias1]
GO
ALTER TABLE [dbo].[Correlatividades_Cursada]  WITH NOCHECK ADD  CONSTRAINT [FK_Correlatividades_Cursada_Carreras] FOREIGN KEY([IdCarrera])
REFERENCES [dbo].[Carreras] ([idCarrera])
GO
ALTER TABLE [dbo].[Correlatividades_Cursada] CHECK CONSTRAINT [FK_Correlatividades_Cursada_Carreras]
GO
ALTER TABLE [dbo].[Correlatividades_Cursada]  WITH CHECK ADD  CONSTRAINT [FK_Correlatividades_Cursada_Materias] FOREIGN KEY([IdMateria])
REFERENCES [dbo].[Materias] ([idmateria])
GO
ALTER TABLE [dbo].[Correlatividades_Cursada] CHECK CONSTRAINT [FK_Correlatividades_Cursada_Materias]
GO
ALTER TABLE [dbo].[Correlatividades_Cursada]  WITH CHECK ADD  CONSTRAINT [FK_Correlatividades_Cursada_Materias1] FOREIGN KEY([Cursada])
REFERENCES [dbo].[Materias] ([idmateria])
GO
ALTER TABLE [dbo].[Correlatividades_Cursada] CHECK CONSTRAINT [FK_Correlatividades_Cursada_Materias1]
GO
ALTER TABLE [dbo].[Correlatividades_Rendir]  WITH NOCHECK ADD  CONSTRAINT [FK_Correlatividades_Rendir_Carreras] FOREIGN KEY([IdCarrera])
REFERENCES [dbo].[Carreras] ([idCarrera])
GO
ALTER TABLE [dbo].[Correlatividades_Rendir] CHECK CONSTRAINT [FK_Correlatividades_Rendir_Carreras]
GO
ALTER TABLE [dbo].[Correlatividades_Rendir]  WITH CHECK ADD  CONSTRAINT [FK_Correlatividades_Rendir_Materias] FOREIGN KEY([IdMateria])
REFERENCES [dbo].[Materias] ([idmateria])
GO
ALTER TABLE [dbo].[Correlatividades_Rendir] CHECK CONSTRAINT [FK_Correlatividades_Rendir_Materias]
GO
ALTER TABLE [dbo].[Correlatividades_Rendir]  WITH CHECK ADD  CONSTRAINT [FK_Correlatividades_Rendir_Materias1] FOREIGN KEY([Rendir])
REFERENCES [dbo].[Materias] ([idmateria])
GO
ALTER TABLE [dbo].[Correlatividades_Rendir] CHECK CONSTRAINT [FK_Correlatividades_Rendir_Materias1]
GO
ALTER TABLE [dbo].[InscriptosCursar]  WITH NOCHECK ADD  CONSTRAINT [InscriptosCursar_Alumnos] FOREIGN KEY([idLegajo])
REFERENCES [dbo].[Alumnos] ([idLegajo])
GO
ALTER TABLE [dbo].[InscriptosCursar] CHECK CONSTRAINT [InscriptosCursar_Alumnos]
GO
ALTER TABLE [dbo].[InscriptosCursar]  WITH NOCHECK ADD  CONSTRAINT [InscriptosCursar_TurnosCursar] FOREIGN KEY([idTurnosCursar])
REFERENCES [dbo].[TurnosCursar] ([idTurnosCursar])
GO
ALTER TABLE [dbo].[InscriptosCursar] CHECK CONSTRAINT [InscriptosCursar_TurnosCursar]
GO
ALTER TABLE [dbo].[InscriptosRendir]  WITH NOCHECK ADD  CONSTRAINT [FK_InscriptosRendir_Alumnos] FOREIGN KEY([idLegajo])
REFERENCES [dbo].[Alumnos] ([idLegajo])
GO
ALTER TABLE [dbo].[InscriptosRendir] CHECK CONSTRAINT [FK_InscriptosRendir_Alumnos]
GO
ALTER TABLE [dbo].[Materias]  WITH NOCHECK ADD  CONSTRAINT [Materias_Carreras] FOREIGN KEY([idcarrera])
REFERENCES [dbo].[Carreras] ([idCarrera])
GO
ALTER TABLE [dbo].[Materias] CHECK CONSTRAINT [Materias_Carreras]
GO
ALTER TABLE [dbo].[Profesores]  WITH NOCHECK ADD  CONSTRAINT [FK_Profesores_Provincias] FOREIGN KEY([domProv])
REFERENCES [dbo].[Provincias] ([idProvincia])
GO
ALTER TABLE [dbo].[Profesores] CHECK CONSTRAINT [FK_Profesores_Provincias]
GO
ALTER TABLE [dbo].[TurnosCursar]  WITH NOCHECK ADD  CONSTRAINT [TurnosCursar_Carreras] FOREIGN KEY([IdCarrera])
REFERENCES [dbo].[Carreras] ([idCarrera])
GO
ALTER TABLE [dbo].[TurnosCursar] CHECK CONSTRAINT [TurnosCursar_Carreras]
GO
ALTER TABLE [dbo].[TurnosCursar]  WITH NOCHECK ADD  CONSTRAINT [TurnosCursar_Materias] FOREIGN KEY([IdMateria])
REFERENCES [dbo].[Materias] ([idmateria])
GO
ALTER TABLE [dbo].[TurnosCursar] CHECK CONSTRAINT [TurnosCursar_Materias]
GO
ALTER TABLE [dbo].[TurnosCursar]  WITH NOCHECK ADD  CONSTRAINT [TurnosCursar_Profesores] FOREIGN KEY([IdProfesor])
REFERENCES [dbo].[Profesores] ([idProfesor])
GO
ALTER TABLE [dbo].[TurnosCursar] CHECK CONSTRAINT [TurnosCursar_Profesores]
GO
ALTER TABLE [dbo].[TurnosRendir]  WITH NOCHECK ADD  CONSTRAINT [TurnosRendir_Carreras] FOREIGN KEY([IdCarrera])
REFERENCES [dbo].[Carreras] ([idCarrera])
GO
ALTER TABLE [dbo].[TurnosRendir] CHECK CONSTRAINT [TurnosRendir_Carreras]
GO
ALTER TABLE [dbo].[TurnosRendir]  WITH NOCHECK ADD  CONSTRAINT [TurnosRendir_Materias] FOREIGN KEY([IdMateria])
REFERENCES [dbo].[Materias] ([idmateria])
GO
ALTER TABLE [dbo].[TurnosRendir] CHECK CONSTRAINT [TurnosRendir_Materias]
GO
