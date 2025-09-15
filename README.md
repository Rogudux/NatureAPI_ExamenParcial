# NatureAPI
Una API RESTful simple construida con .NET para catalogar y explorar lugares naturales de México.

# Tecnologías y Conceptos Clave
Lenguaje y Framework: C# con .NET 9.

- Base de Datos: Entity Framework Core para la comunicación con la base de datos de SQL server, levantada con un contenedor de Docker.

- Documentación: Swagger (Swashbuckle) para la interfaz de prueba de la API.

- Editor: JetBrains Rider.

## Técnicas:

Diseño de API RESTful con Controllers.

Uso de DTOs para separar el modelo de la base de datos de la API.

Inyección de Dependencias.

# Estructura
La solución tiene dos proyectos: LibraryAPI (contiene las entidades y DTOs) y NatureAPi (el proyecto principal de la API).

# Cómo Empezar
Clona el repositorio:

git clone https://github.com/Rogudux/NatureAPI_ExmenParcial.git
Configura la conexión: Modifica la ConnectionString en NatureAPi/appsettings.Development.json.

