CREATE PROCEDURE [dbo].[sp_traerNotasParcial]
as begin 

select  A.Apellido as 'ApeAlumno', 
		A.Nombres as 'NombreAlumno',
	    P.Apellido as 'ApeProf', 
		P.Nombre as 'NombreProf',
        C.descripcion as 'DescripCarrera',
	    M.descripcion as 'DescripcionMat'

from TurnosCursar TC inner join InscriptosCursar IC 
			on  TC.idTurnosCursar=IC.idTurnosCursar
		inner join Alumnos A 
		    on IC.idLegajo=A.idLegajo
	    inner join Profesores P
		    on TC.IdProfesor=P.idProfesor
		inner join Carreras C
			on TC.IdCarrera=C.idCarrera
		inner join Materias M
			on TC.IdMateria=M.idmateria

where IC.Estado!='S' and IC.Estado!='L'
end