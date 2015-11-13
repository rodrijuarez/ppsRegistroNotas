CREATE PROCEDURE Carreras_A
	@idCarrera int,
	@descripcion varchar(50),
	@duracion int,
	@fechacreacion smalldatetime,
	@fechanovigencia smalldatetime,
	@totalhoras int,
	@cantmaterias int
AS
	begin
	INSERT INTO Carreras (idCarrera, descripcion, duracion,fechacreacion, fechanovigencia, totalhoras, cantmaterias)
		VALUES (@idCarrera,@descripcion,@duracion,@fechacreacion,@fechanovigencia,@totalhoras,@cantmaterias)
end