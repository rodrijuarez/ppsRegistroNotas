
CREATE procedure [dbo].[sp_alumnoPorNombreApellido]
	@nombre varchar(50),
	@apellido varchar(50)
as
begin
select idLegajo,Nombres,Apellido from Alumnos
where Nombres = @nombre or Apellido = @apellido
end