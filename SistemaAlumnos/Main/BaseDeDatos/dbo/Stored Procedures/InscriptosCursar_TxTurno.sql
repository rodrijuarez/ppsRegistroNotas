CREATE PROCEDURE InscriptosCursar_TxTurno
	@idTurnosCursar int
AS
BEGIN
	SELECT * FROM InscriptosCursar 
		WHERE Estado = 'C' 
			AND idTurnosCursar = @idTurnosCursar 
END