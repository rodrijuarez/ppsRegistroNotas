CREATE PROCEDURE [dbo].[sp_inscriptosCursar_modificarxidTurnoCursarxinscriptoCursar]
	@idTurnosCursar int,
	@idLegajo char(10),
	@NotaPrimParcial int,
	@NotaSegParcial int,
	@PrimerRecTipo int,
	@Rec1 int,
	@SegRecTipo int,
	@Rec2 int,
	@TerRecTipo int,
	@Rec3 int
AS
BEGIN
	UPDATE InscriptosCursar
	SET NotaPrimParcial = @NotaPrimParcial,
	NotaSegParcial = @NotaSegParcial,
	PrimerRecTipo = @PrimerRecTipo,
	Rec1 = @Rec1,
	SegRecTipo = @SegRecTipo,
	Rec2 = @Rec2,
	TerRecTipo = @TerRecTipo,
	Rec3 = @Rec3
	WHERE idTurnosCursar = @idTurnosCursar 
		AND idLegajo = @idLegajo
END