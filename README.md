# Blazor Clean Architecture

Repositorio de ejemplo que implementa una aplicación Blazor Server en C# con una estructura basada en Clean Architecture.

## Descripción

Esta solución está organizada en capas para separar responsabilidades y facilitar el mantenimiento:

- `src/BlazorCleanArch.Domain` — Entidades, valores de objeto e interfaces para el dominio.
- `src/BlazorCleanArch.Application` — Casos de uso, contratos y servicios de aplicación.
- `src/BlazorCleanArch.Infrastructure` — Implementaciones de repositorios e inyección de dependencias.
- `src/BlazorCleanArch.Web` — Proyecto Blazor Server que consume los servicios de la aplicación.

## Estructura del proyecto

- `BlazorCleanArch.sln` — Solución con los cuatro proyectos.
- `BlazorCleanArch.Domain/` — Modelo de dominio y contrato de repositorio.
- `BlazorCleanArch.Application/` — DTOs, servicios de aplicación y registro de dependencias.
- `BlazorCleanArch.Infrastructure/` — Repositorio en memoria y registro de servicios.
- `BlazorCleanArch.Web/` — UI Blazor, páginas, estilos y configuración de servidor.

## Requisitos previos

- .NET SDK 8.0 o posterior
- Git instalado para controlar versiones
- Opcional: Visual Studio 2022/2023, Visual Studio Code u otro editor compatible

## Ejecutar localmente

1. Abre una terminal en la carpeta raíz del repositorio:

```powershell
cd C:\Users\GONZALO\blazor-clean-arch\src
```

2. Restaurar paquetes NuGet:

```powershell
dotnet restore
```

3. Ejecutar la aplicación Blazor Server:

```powershell
dotnet run --project BlazorCleanArch.Web\BlazorCleanArch.Web.csproj
```

4. Abre el navegador en `https://localhost:5001` o la URL indicada en la salida.

## Publicar en GitHub

### 1. Inicializar el repositorio local

En la raíz del proyecto:

```powershell
cd C:\Users\GONZALO\blazor-clean-arch
git init
git add .
git commit -m "Initial commit: Blazor Clean Architecture"
```

### 2. Crear el repositorio en GitHub

Puedes crear un repositorio en GitHub usando la web de GitHub o la CLI de GitHub (`gh`):

```powershell
gh repo create blazor-clean-arch --public --source=. --remote=origin --push
```

Si no usas la CLI, crea el repositorio en github.com y luego añade el remoto:

```powershell
git remote add origin https://github.com/<tu-usuario>/blazor-clean-arch.git
git branch -M main
git push -u origin main
```

### 3. Confirmar el primer push

```powershell
git push -u origin main
```

## Buenas prácticas

- Usa `main` como rama principal.
- Añade `README.md`, `.gitignore` y `.gitattributes` al control de versiones.
- Protege ramas importantes en GitHub si es un proyecto de producción.

## Archivos incluidos

- `.gitignore` — Ignora artefactos de compilación y archivos temporales.
- `.gitattributes` — Normaliza finales de línea y trata archivos como texto.
- `README.md` — Documentación del proyecto.

## Integración continua (CI/CD)

Este repositorio incluye un workflow de GitHub Actions (`.github/workflows/dotnet-build.yml`) que:

- Se ejecuta automáticamente en cada push a `main`
- Compila la solución con .NET 8.0
- Ejecuta pruebas unitarias (si existen)

El flujo garantiza que los cambios compilados siempre estén en estado limpio.

## Notas

Este repositorio usa una implementación simple en memoria para `IWeatherForecastRepository` como ejemplo.
Para producción, reemplaza esa implementación por una fuente de datos real (base de datos, API, etc.).
