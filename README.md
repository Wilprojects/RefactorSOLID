# Entregable I - Refactor SOLID

## Descripción

Este proyecto corresponde al **Entregable I de la Capacitación de Principios SOLID y patrones de diseño en C# .NET**.

El objetivo principal es aplicar el principio **Single Responsibility Principle (SRP)** mediante la refactorización de una clase `ReporteService` que inicialmente concentra múltiples responsabilidades.

La aplicación es de consola y las funcionalidades solicitadas se simulan únicamente mediante mensajes en pantalla, tal como indica el enunciado del taller.

---

## Objetivo

Aplicar el principio **Single Responsibility Principle (SRP)** para separar responsabilidades y mejorar la organización, mantenibilidad y claridad del código.

El principio SRP establece que una clase debe tener una sola responsabilidad o, dicho de otra forma, una sola razón para cambiar.

---

## Problema inicial

La clase `ReporteService` original contiene los siguientes métodos:

- `ConsultarDatos()`
- `GenerarReporte()`
- `EnviarCorreo()`
- `GuardarArchivo()`

Esto provoca que una sola clase se encargue de varias responsabilidades diferentes:

- Consulta de datos.
- Generación del reporte.
- Envío de correo.
- Guardado del archivo.

Ejemplo conceptual de la versión inicial:

```text
ReporteService
├── ConsultarDatos()
├── GenerarReporte()
├── EnviarCorreo()
└── GuardarArchivo()
```

Esta estructura incumple el principio SRP porque `ReporteService` tiene varias razones diferentes para cambiar.

---

## Solución aplicada

Después de realizar la refactorización, cada responsabilidad fue separada en una clase específica:

- `DatosService`: consulta los datos.
- `GeneradorReporteService`: genera el reporte.
- `CorreoService`: envía el correo.
- `ArchivoService`: guarda el archivo.
- `ReporteService`: coordina el flujo completo del reporte.

La estructura lógica resultante es:

```text
ReporteService
│
├── DatosService
│   └── ConsultarDatos()
│
├── GeneradorReporteService
│   └── GenerarReporte()
│
├── CorreoService
│   └── EnviarCorreo()
│
└── ArchivoService
    └── GuardarArchivo()
```

De esta manera, cada clase tiene una responsabilidad específica y el diseño cumple con el principio **Single Responsibility Principle**.

---

## Estructura del proyecto

```text
RefactorSOLID/
│
├── Evidencias/
│   ├── 01-reporte-service-inicial.png
│   ├── 02-estructura-srp.png
│   └── 03-ejecucion-srp.png
│
├── src/
│   └── RefactorSOLID/
│       │
│       ├── Services/
│       │   ├── ArchivoService.cs
│       │   ├── CorreoService.cs
│       │   ├── DatosService.cs
│       │   ├── GeneradorReporteService.cs
│       │   └── ReporteService.cs
│       │
│       ├── Program.cs
│       └── RefactorSOLID.csproj
│
├── .gitignore
├── README.md
└── RefactorSOLID.slnx
```

> Las carpetas `.vs`, `bin` y `obj` pueden existir localmente, pero no deben subirse al repositorio porque están excluidas mediante `.gitignore`.

---

## Descripción de las clases

### DatosService

Responsable únicamente de simular la consulta de datos.

```text
Consultar datos
```

### GeneradorReporteService

Responsable únicamente de simular la generación del reporte.

```text
Generar reporte
```

### CorreoService

Responsable únicamente de simular el envío de correo.

```text
Enviar correo
```

### ArchivoService

Responsable únicamente de simular el guardado del archivo.

```text
Guardar archivo
```

### ReporteService

Su responsabilidad es coordinar el flujo del proceso utilizando las clases anteriores.

No implementa directamente la lógica de consulta, generación, envío o almacenamiento.

---

## Funcionamiento

Al ejecutar la aplicación se obtiene una salida similar a la siguiente:

```text
=== GENERACIÓN DE REPORTE ===

Consultar datos
Generar reporte
Enviar correo
Guardar archivo

Proceso completado.
```

Las funcionalidades no realizan procesos reales de base de datos, correo, generación de documentos ni almacenamiento de archivos.

Cada método únicamente utiliza `Console.WriteLine()` porque el objetivo del entregable es demostrar la aplicación del principio SRP.

---

## Tecnologías utilizadas

- C#
- .NET
- Aplicación de consola
- Visual Studio
- Git
- GitHub

---

## Requisitos

Para ejecutar el proyecto se necesita:

- Visual Studio con soporte para desarrollo .NET, o
- .NET SDK instalado.
- Git, únicamente si se desea trabajar con control de versiones.

---

## Cómo ejecutar el proyecto desde Visual Studio

1. Abrir el archivo:

```text
RefactorSOLID.slnx
```

2. Verificar que `RefactorSOLID` sea el proyecto de inicio.

3. Ejecutar con:

```text
Ctrl + F5
```

4. Comprobar que la consola muestre los mensajes correspondientes a cada operación.

---

## Cómo ejecutar desde terminal

Desde la raíz del repositorio:

```bash
dotnet run --project src/RefactorSOLID/RefactorSOLID.csproj
```

La salida esperada es:

```text
=== GENERACIÓN DE REPORTE ===

Consultar datos
Generar reporte
Enviar correo
Guardar archivo

Proceso completado.
```

---

## Evidencias

Las evidencias del desarrollo y funcionamiento se encuentran en la carpeta:

```text
./Evidencias/
```

### Evidencia 1 - Clase inicial

```text
./Evidencias/01-reporte-service-inicial.png
```

Muestra la versión inicial de `ReporteService` con las cuatro responsabilidades antes de aplicar SRP.

### Evidencia 2 - Estructura después del refactor

```text
./Evidencias/02-estructura-srp.png
```

Muestra la separación de responsabilidades en clases independientes.

### Evidencia 3 - Ejecución final

```text
./Evidencias/03-ejecucion-srp.png
```

Muestra la ejecución correcta de la aplicación después de la refactorización.

---

## Control de versiones

El historial de Git permite observar el cambio entre la implementación inicial y la versión refactorizada.

Ejemplos de commits utilizados:

```text
feat: add initial ReporteService implementation
refactor: apply single responsibility principle
docs: add README and execution evidence
```

De esta manera se puede comprobar que el proyecto pasó de una clase con múltiples responsabilidades a una estructura organizada según SRP.

---

## Principio SOLID aplicado

### S - Single Responsibility Principle

Cada clase debe tener una única responsabilidad.

Antes del refactor:

```text
ReporteService
→ consultar datos
→ generar reporte
→ enviar correo
→ guardar archivo
```

Después del refactor:

```text
DatosService
→ consultar datos

GeneradorReporteService
→ generar reporte

CorreoService
→ enviar correo

ArchivoService
→ guardar archivo

ReporteService
→ coordinar el proceso
```

Esto reduce el acoplamiento entre responsabilidades y facilita el mantenimiento del código.

---

## Conclusión

La refactorización permite transformar una clase con múltiples responsabilidades en un conjunto de clases más pequeñas y especializadas.

El resultado cumple con el principio **Single Responsibility Principle**, mejora la organización del código y permite que cada responsabilidad pueda modificarse de forma independiente sin afectar innecesariamente a las demás.

Este entregable demuestra de manera sencilla y práctica uno de los principios fundamentales de SOLID aplicado a una aplicación de consola desarrollada en C# .NET.
