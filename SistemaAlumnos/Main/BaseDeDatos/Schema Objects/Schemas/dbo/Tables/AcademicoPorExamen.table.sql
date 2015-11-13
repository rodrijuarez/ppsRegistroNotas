CREATE TABLE [dbo].[AcademicoPorExamen](
	[idtomo] [int] NOT NULL,
	[idfolio] [int] NOT NULL,
	[idlegajo] [char](10) COLLATE Modern_Spanish_CI_AS NOT NULL,
	[nota] [int] NULL,
 CONSTRAINT [PK_Finales] PRIMARY KEY CLUSTERED 
(
	[idlegajo] ASC,
	[idtomo] ASC,
	[idfolio] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON),
 CONSTRAINT [Finales_Actas] FOREIGN KEY([idtomo], [idfolio])
REFERENCES [dbo].[Actas] ([idtomo], [idfolio]),
 CONSTRAINT [Finales_Alumnos] FOREIGN KEY([idlegajo])
REFERENCES [dbo].[Alumnos] ([idLegajo])
)


