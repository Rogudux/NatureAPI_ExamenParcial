🏞️ NatureAPI
Una API RESTful simple construida con .NET para catalogar y explorar lugares naturales de Mexico.

🛠️ Tecnologías y Conceptos Clave
Lenguaje y Framework: C# con .NET 9.

Base de Datos: Entity Framework Core para la comunicación con la base de datos.

Documentación: Swagger (Swashbuckle) para la interfaz de prueba de la API.

Editor: JetBrains Rider [o tu editor].

Técnicas:

Diseño de API RESTful con COntrollers.

Uso de DTOs para separar el modelo de la base de datos de la API.

Inyección de Dependencias.

📂 Estructura
La solución tiene dos proyectos: LibraryAPI (contiene las entidades y DTOs) y NatureAPi (el proyecto principal de la API).

🚀 Cómo Empezar
Clona el repositorio:

Bash

git clone https://github.com/Rogudux/NatureAPI_ExmenParcial.git
Configura la conexión: Modifica la ConnectionString en NatureAPi/appsettings.Development.json.

Crea la base de datos:

Bash

cd NatureAPi
dotnet ef database update
Ejecuta la API:

Bash

dotnet run
La documentación estará en http://localhost:[TU_PUERTO]/swagger.

📡 Endpoints Principales
GET /api/places: Obtiene todos los lugares (permite filtros).

GET /api/places/{id}: Obtiene un lugar por su ID.

POST /api/places: Crea un nuevo lugar.
