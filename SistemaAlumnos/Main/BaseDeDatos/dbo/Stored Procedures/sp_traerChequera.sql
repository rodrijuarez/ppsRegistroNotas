


CREATE procedure [dbo].[sp_traerChequera]
	@legajo char(10)	
as

begin
	select c.FechaPago1, c.FechaPago2, c.FechaPago3, c.FechaPago4, c.FechaPago5, c.ImportePago1, 
	c.ImportePago2, c.ImportePago3, c.ImportePago4, c.ImportePago5 from Chequeras c
	where idLegajo = @legajo
end