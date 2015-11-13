
	CREATE PROCEDURE [dbo].[insertarChequeras]
		@legajo char(10),
		@anioLectivo int,
		@cuatrimestre int,
		@cuota1 decimal(18,0),
		@cuota2 decimal(18,0),
		@cuota3 decimal(18,0),
		@cuota4 decimal(18,0),
		@cuota5 decimal(18,0),
		@fechaC1 smalldatetime,
		@fechaC2 smalldatetime,
		@fechaC3 smalldatetime,
		@fechaC4 smalldatetime,
		@fechaC5 smalldatetime,
		@estado char(10)

	AS 

	BEGIN
		update Chequeras
		set FechaPago1 = @cuota1, FechaPago2 = @cuota2,	FechaPago3 = @cuota3, FechaPago4 = @cuota4, FechaPago5 = @cuota5, AnioLectivo = @anioLectivo, Cuatrimestre = @cuatrimestre, Estado = @estado
		where idLegajo = @legajo
	END