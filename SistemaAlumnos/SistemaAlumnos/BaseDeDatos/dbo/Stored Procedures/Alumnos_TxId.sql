create procedure Alumnos_TxId
@idLegajo INT
AS
SELECT * FROM Alumnos
	WHERE idLegajo= @idLegajo