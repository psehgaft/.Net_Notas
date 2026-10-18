# .Net_Notas

Notas y proyectos de ejemplo de la certificación .NET: una colección de demos en ASP.NET Web Forms (clásico) y servicios web ASMX, usada como material de estudio.

## Proyectos incluidos

| Carpeta | Tipo | Qué contiene |
|---|---|---|
| `ASP` | ASP.NET Web Forms | Demos básicos: controles de servidor, controles HTML de servidor, master page (`Site.master`), páginas `Default` / `Demo1` / `Demo2` |
| `DemoMap` | ASP.NET Web Forms | Sitio de ejemplo más completo: login (`Account`), scripts, estilos y mapa del sitio (`Web.sitemap`) |
| `DemoWebService` | Servicio web ASMX | `Service.asmx` con los métodos `HelloWorld` y `ObtenerAutor` (lee la tabla de autores de la base de ejemplo Pubs) |
| `WebSite1` | Servicio web ASMX | Plantilla mínima de servicio (`HelloWorld`), punto de partida para nuevos servicios |

## Requisitos

- Windows con IIS (o IIS Express)
- .NET Framework
- Visual Studio (la edición Community es suficiente)

Son proyectos de ASP.NET clásico (Web Forms + ASMX), tecnología diseñada para ejecutarse en IIS sobre Windows.

## Uso

1. En IIS crea un sitio o una aplicación virtual que apunte a la carpeta del demo (por ejemplo `DemoWebService`).
2. Abre `Service.asmx` en el navegador para probar los métodos del servicio web, o navega las páginas `.aspx` en los demos de Web Forms.
3. `DemoWebService` espera en `web.config` la cadena de conexión `PubsConnectionString` hacia la base de ejemplo Pubs.

## Licencia

Distribuido bajo la licencia [GNU GPL v3](LICENSE).
