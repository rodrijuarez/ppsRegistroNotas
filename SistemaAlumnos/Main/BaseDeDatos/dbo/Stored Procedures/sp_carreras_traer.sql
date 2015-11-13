CREATE PROCEDURE [dbo].[sp_carreras_traer]
AS
BEGIN
	SELECT idCarrera,descripcion FROM Carreras
END