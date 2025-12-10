# Documentación técnica

## ¿Cómo inicializar el proyecto?

1. Clonar el repositorio: `github.com/CarlosJean/CSharp-Intermedio`.
2. Dirigirse a la ruta `https://github.com/CarlosJean/CSharp-Intermedio/tree/master/Semana_5/BillingSystem`.
3. Abrir el proyecto a través del archivo `BillingSystem.sln`.
4. En el explorador de la solución acceder al archivo `appsettings.json`.
5. En el archivo appsettings.json colocar su connection string:
   `"ConnectionStrings": {
    "DefaultConnection": "Data Source={your_server};Initial Catalog={your_database};Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False"}`.
6. Abrir la terminal de su máquina.
7. Dirigirse a la ruta del proyecto y ejecutar el comando: `dotnet ef database update --project BillingSystem.DAL -s BillingSystem.Web`.
8. Dentro de su editor de código, ejecutar el proyecto.

## Arquitectura

El proyecto se conforma por cuatro capas:

- **Capa Web:** BillingSystem.Web
- **Capa de dominio:** BillingSystem.Domain
- **Capa de datos:** BillingSystem.DAL
- **Capa de núcleo:** BillingSystem.Core
