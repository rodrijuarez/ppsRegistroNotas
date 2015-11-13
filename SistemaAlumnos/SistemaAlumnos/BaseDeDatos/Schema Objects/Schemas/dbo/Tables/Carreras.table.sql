CREATE TABLE [dbo].[Carreras](
	[idCarrera] [int] NOT NULL,
	[descripcion] [varchar](50) COLLATE Modern_Spanish_CI_AS NOT NULL,
	[duracion] [int] NULL,
	[fechacreacion] [smalldatetime] NULL,
	[fechanovigencia] [smalldatetime] NULL,
	[ordenanza] [varchar](10) COLLATE Modern_Spanish_CI_AS NULL,
	[totalhoras] [int] NULL,
	[cantmaterias] [int] NULL,
 CONSTRAINT [PK_Carreras] PRIMARY KEY CLUSTERED 
(
	[idCarrera] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)


