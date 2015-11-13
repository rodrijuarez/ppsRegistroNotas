create procedure TurnosCursar_TxIdMateria
@idmateria int
as
select * from TurnosCursar where IdMateria = @idmateria;