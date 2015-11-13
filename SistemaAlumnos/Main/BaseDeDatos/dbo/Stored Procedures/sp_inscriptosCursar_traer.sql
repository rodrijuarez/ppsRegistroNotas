CREATE PROCEDURE [dbo].[sp_inscriptosCursar_traer]
	@idTurnosCursar int
AS
BEGIN
	SELECT * FROM InscriptosCursar,Alumnos 
		WHERE InscriptosCursar.Estado = 'C' 
			AND idTurnosCursar = @idTurnosCursar 
			AND InscriptosCursar.idLegajo = Alumnos.idLegajo
END