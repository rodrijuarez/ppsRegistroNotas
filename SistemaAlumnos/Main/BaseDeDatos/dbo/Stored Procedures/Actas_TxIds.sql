CREATE PROCEDURE Actas_TxIds
@idfolio INT,
@idtomo INT
AS
SELECT A.idtomo as "Nro. de Tomo", 
	   A.idfolio as "Nro. de Folio", 
	   A.fecha as Fecha,
	   C.descripcion as Carrera,
	   M.descripcion as Materia,
	   A.inscriptos as Inscriptos,
	   A.estado as Estado,
	   A.aprobados as "Cant. de Aprobados",
	   A.ausentes as "Cant. de Ausentes",
	   A.desaprobados as "Cant. de Desaprobados",
	   A.idUsuarioResponsable as "Usuario Responsable",
	   A.fechaIngreso as "Fecha de Ingreso"
FROM Actas as A, Carreras as C, Materias as M
WHERE idfolio=@idfolio AND idtomo=@idtomo
AND C.idCarrera=A.idcarrera AND M.idmateria = A.idmateria