-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Academico_TxParcial]
	
	@leg char(10)

AS
BEGIN
	select A.Nombres , A.Apellido, C.descripcion as Carrera,  M.descripcion as Materias,
	CONVERT(VARCHAR(20), Ap.fecha, 101) as Fecha, Ap.aniolectivo, Ap.cuatrimestre, Ap.primerparcial, Ap.segundoparcial, Ap.primerrecuptipo,
	Ap.notaprimerrecup, Ap.segundorecuptipo, Ap.notasegundorecup, Ap.tercerrecuptipo, Ap.notatercerrecup, Ap.estado
	from AcademicoPorParcial Ap, Alumnos A, Materias M, Carreras C
	where Ap.idLegajo = @leg
	and Ap.idcarrera = C.idCarrera
	and Ap.idmateria = M.idMateria
END