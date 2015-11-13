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
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)


