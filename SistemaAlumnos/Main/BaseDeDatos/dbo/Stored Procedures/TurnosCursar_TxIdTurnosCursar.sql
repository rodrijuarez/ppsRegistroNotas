CREATE PROCEDURE TurnosCursar_TxIdTurnosCursar
	@Turno char 
AS
BEGIN
	SELECT idTurnosCursar FROM TurnosCursar WHERE Turno = @Turno 
END
