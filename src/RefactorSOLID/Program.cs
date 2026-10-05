using RefactorSOLID.Services;

Console.WriteLine("=== GENERACIÓN DE REPORTE ===");
Console.WriteLine();

var datosService = new DatosService();
var generadorReporteService = new GeneradorReporteService();
var correoService = new CorreoService();
var archivoService = new ArchivoService();

var reporteService = new ReporteService(datosService, generadorReporteService, correoService, archivoService);

reporteService.ProcesarReporte();

Console.WriteLine();
Console.WriteLine("Proceso completado.");