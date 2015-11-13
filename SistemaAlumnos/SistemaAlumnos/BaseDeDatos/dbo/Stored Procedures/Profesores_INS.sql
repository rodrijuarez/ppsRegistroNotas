CREATE PROCEDURE Profesores_INS
	@Apellido VARCHAR(50),
	@Nombre VARCHAR(50),
	@FechaNacimiento DATE,
	@DomCalle VARCHAR(50),
	@DomNro INT,
	@DomPiso INT,
	@DomDepto VARCHAR(4),
	@DomCodPostal VARCHAR(8),
	@DomProv int,
	@DomLocalidad VARCHAR(50),
	@Mail VARCHAR(50),
	@Telefono VARCHAR(50),
	@Estadolegajo CHAR
AS 
BEGIN
	INSERT INTO Profesores(Apellido, Nombre, FechaNacim, domCalle, domNro, domPiso, domDepto, domCodPostal, domProv, domLocalid, Mail, Telefono, Estado)
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