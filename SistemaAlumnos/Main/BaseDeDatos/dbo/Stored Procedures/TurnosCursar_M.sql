create procedure TurnosCursar_M
@idTurnosCursar int,
@AnioLectivo int,
@Cuatrimestre int,
@IdCarrera int,
@IdMateria int,
@Turno char(1),
@Division char(3),
@DiaDictado1 char(2),
@DiaDictado2 char(2),
@Duracion char(1),
@Duracion2 char(1),
@IdProfesor int
as
update TurnosCursar set AnioLectivo=@AnioLectivo,Cuatrimestre=@Cuatrimestre,IdCarrera=@IdCarrera,IdMateria=@IdMateria,
Turno=@Turno,Division=@Division,DiaDictado1=@DiaDictado1,DiaDictado2=@DiaDictado2,Duracion=@Duracion,Duracion2=@Duracion2,IdProfesor=@IdProfesor
 where idTurnosCursar=@idTurnosCursar;