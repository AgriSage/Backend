# AgriSage API

Breve descripción de la aplicación.

## Requisitos

- [.NET Framework](https://dotnet.microsoft.com/download)
- [MySQL](https://www.mysql.com/downloads/)

## Configuración

1. Clona el repositorio:

    ```bash
    git clone https://github.com/AgriSage/Backend.git
    ```

2. Abre el proyecto en tu IDE favorito.

3. Configura la cadena de conexión a la base de datos en el archivo `appsettings.json`.

    ```json
    {
      "ConnectionStrings": {
         "DefaultConnection": "Server=localhost;Database=nombre_base_de_datos;Uid=usuario;Pwd=contraseña;"
      }
    }
    ```

## Uso

1. Ejecuta la aplicación:

    ```bash
    dotnet run
    ```
    o
    Ejecutalo desde tu IDE.

2. Accede a la API en `http://localhost:5000`.
