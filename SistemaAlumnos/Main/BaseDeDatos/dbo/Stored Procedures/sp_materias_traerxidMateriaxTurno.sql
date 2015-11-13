CREATE PROCEDURE [dbo].[sp_materias_traerxidMateriaxTurno]
	@idMateria int,
	@Turno varchar(40)
AS
BEGIN
	SELECT * FROM TurnosCursar WHERE IdMateria = @idMateria AND Turno = @Turno
END