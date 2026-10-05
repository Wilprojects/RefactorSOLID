using RefactorSOLID.Services;

Console.WriteLine("=== GENERACIÓN DE REPORTE ===");
Console.WriteLine();

var reporteService = new ReporteService();

reporteService.ConsultarDatos();
reporteService.GenerarReporte();
reporteService.EnviarCorreo();
reporteService.GuardarArchivo();

Console.WriteLine();
Console.WriteLine("Proceso completado.");