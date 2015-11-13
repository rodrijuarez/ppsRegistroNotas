CREATE PROCEDURE Profesores_TxId
	@IdProfesor INT
AS
BEGIN
	SELECT * FROM Profesores
	WHERE idProfesor = @IdProfesor
END