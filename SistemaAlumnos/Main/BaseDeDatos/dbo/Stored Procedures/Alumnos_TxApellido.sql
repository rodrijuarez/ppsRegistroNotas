CREATE PROCEDURE [dbo].[Alumnos_TxApellido]
	@apellido varchar
as
BEGIN
	select *
	from Alumnos
	Where alumnos.Apellido like '%'+ @apellido +'%'
END