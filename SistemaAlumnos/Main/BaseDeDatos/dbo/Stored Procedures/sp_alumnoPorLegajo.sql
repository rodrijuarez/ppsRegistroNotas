

CREATE procedure [dbo].[sp_alumnoPorLegajo]
	@legajo char(10)	
as

begin
	select idLegajo,Nombres,Apellido from Alumnos
	where idLegajo = @legajo
end