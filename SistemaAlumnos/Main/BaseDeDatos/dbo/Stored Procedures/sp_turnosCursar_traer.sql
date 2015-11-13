CREATE PROCEDURE [dbo].[sp_turnosCursar_traer]
AS
BEGIN
	SELECT idTurnosCursar,Turno,Division FROM TurnosCursar
END