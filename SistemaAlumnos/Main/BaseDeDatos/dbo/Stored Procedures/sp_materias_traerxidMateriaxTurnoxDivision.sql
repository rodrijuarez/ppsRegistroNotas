CREATE PROCEDURE [dbo].[sp_materias_traerxidMateriaxTurnoxDivision]
	@idMateria int,
	@Turno varchar(40),
	@Division int
AS
BEGIN
	SELECT * FROM TurnosCursar WHERE IdMateria = @idMateria AND Turno = @Turno AND Division = @Division
END