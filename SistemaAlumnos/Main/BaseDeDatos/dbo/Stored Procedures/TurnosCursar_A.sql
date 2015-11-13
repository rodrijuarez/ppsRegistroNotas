create procedure TurnosCursar_A
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
insert into TurnosCursar (AnioLectivo,Cuatrimestre,IdCarrera,IdMateria,Turno,Division,DiaDictado1,DiaDictado2,Duracion,Duracion2,IdProfesor)
values (@AnioLectivo,@Cuatrimestre,@IdCarrera,@IdMateria,@Turno,@Division,@DiaDictado1,@DiaDictado2,@Duracion,@Duracion2,@IdProfesor);