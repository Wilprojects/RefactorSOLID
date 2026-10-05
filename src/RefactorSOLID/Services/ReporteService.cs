namespace RefactorSOLID.Services;

public class ReporteService
{
    private readonly DatosService _datosService;
    private readonly GeneradorReporteService _generadorReporteService;
    private readonly CorreoService _correoService;
    private readonly ArchivoService _archivoService;

    public ReporteService(DatosService datosService, GeneradorReporteService generadorReporteService, CorreoService correoService, ArchivoService archivoService)
    {
        _datosService = datosService;
        _generadorReporteService = generadorReporteService;
        _correoService = correoService;
        _archivoService = archivoService;
    }

    public void ProcesarReporte()
    {
        _datosService.ConsultarDatos();
        _generadorReporteService.GenerarReporte();
        _correoService.EnviarCorreo();
        _archivoService.GuardarArchivo();
    }
}