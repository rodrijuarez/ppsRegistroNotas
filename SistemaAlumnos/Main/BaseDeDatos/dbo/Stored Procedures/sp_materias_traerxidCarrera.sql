CREATE PROCEDURE [dbo].[sp_materias_traerxidCarrera]
	@idCarrera int
AS
BEGIN
	SELECT idmateria,descripcion,idcarrera,cargahoraria,cuatrimestre FROM Materias WHERE idcarrera = @idCarrera
END