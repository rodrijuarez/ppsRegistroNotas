CREATE TABLE [dbo].[Bibliografia](
	[IdLibro] [int] IDENTITY(1,1) NOT NULL,
	[Titulo] [varchar](150) COLLATE Modern_Spanish_CI_AS NULL,
	[Autor1] [varchar](50) COLLATE Modern_Spanish_CI_AS NULL,
	[Autor2] [varchar](50) COLLATE Modern_Spanish_CI_AS NULL,
	[Autor3] [varchar](50) COLLATE Modern_Spanish_CI_AS NULL,
	[NumeroISBN] [varchar](50) COLLATE Modern_Spanish_CI_AS NULL,
	[Editorial] [varchar](50) COLLATE Modern_Spanish_CI_AS NULL,
	[AñoEdicion] [int] NULL,
	[Estado] [char](1) COLLATE Modern_Spanish_CI_AS NULL,
	[MotivoBaja] [varchar](250) COLLATE Modern_Spanish_CI_AS NULL,
	[IdlegajoPrestado] [int] NULL,
	[FechaPrestado] [date] NULL,
	[FechaDevolucion] [date] NULL,
 CONSTRAINT [PK_Bibliografia] PRIMARY KEY CLUSTERED 
(
	[IdLibro] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON),
 CONSTRAINT [FK_Bibliografia_Profesores] FOREIGN KEY([IdlegajoPrestado])
REFERENCES [dbo].[Profesores] ([idProfesor])
)


