create procedure Materias_TxIdCarrera
@idcarrera int
as
select * from Materias where idcarrera = @idcarrera;