CREATE PROCEDURE [dbo].[Profesores_INS]
/*	@IdProfesor INT,  */
	@Apellido VARCHAR,
	@Nombre VARCHAR,
	@FechaNacimiento DATE,
	@DomCalle VARCHAR,
	@DomNro VARCHAR,
	@DomPiso VARCHAR,
	@DomDepto VARCHAR,
	@DomCodPostal VARCHAR,
	@DomProv int,
	@DomLocalidad VARCHAR,
	@Mail VARCHAR,
	@Telefono VARCHAR,
	@Estadolegajo CHAR
AS 
BEGIN
	INSERT INTO Profesores(Apellido, Nombre, FechaNacim, domCalle, domNro, domPiso, domDepto, domCodPostal, DomProv, domLocalid, Mail, Telefono, Estado)
	VALUES(
	@Apellido,
	@Nombre,
	@FechaNacimiento,
	@DomCalle,
	@DomNro,
	@DomPiso,
	@DomDepto,
	@DomCodPostal,
	@DomProv,
	@DomLocalidad,
	@Mail,
	@Telefono,
	@Estadolegajo)
END