CREATE TABLE [dbo].[UltimoTomoFolio](
	[IdUltimo] [int] NOT NULL,
	[UltimoTomoGenerado] [int] NOT NULL,
	[UltimoFolioGenerado] [int] NOT NULL,
	[UltimoTomoFolioFechaCreacion] [smalldatetime] NOT NULL,
	[FechaGeneracionActa] [smalldatetime] NOT NULL,
 CONSTRAINT [PK_UltimoTomoFolio] PRIMARY KEY CLUSTERED 
(
	[IdUltimo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)


