CREATE PROCEDURE [dbo].[sp_turnosCursar_traerxidMateria]
	@idMateria int
AS
BEGIN
	SELECT * FROM TurnosCursar WHERE IdMateria = @idMateria
END