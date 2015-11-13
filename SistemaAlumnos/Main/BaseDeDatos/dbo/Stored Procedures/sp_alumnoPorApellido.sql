

CREATE procedure [dbo].[sp_alumnoPorApellido]
	@apellido varchar(50)
as
begin
select idLegajo,Nombres as Nombre,Apellido from Alumnos
where Apellido = @apellido
end