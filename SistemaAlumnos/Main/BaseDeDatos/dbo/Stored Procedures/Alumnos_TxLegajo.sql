CREATE PROCEDURE [dbo].[Alumnos_TxLegajo] 
	@leg char(10)
AS
BEGIN
	
	SELECT * 
	from Alumnos
	where Alumnos.idLegajo = @leg
END