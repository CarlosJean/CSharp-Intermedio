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

## Requisitos funcionales

- El Sistema debe permitir registrar clientes.
- El sistema debería permitir modificar los datos del cliente.
- El sistema debería consultar clientes.
- El sistema debería permitir registrar productos.
- El sistema debería permitir modificar productos.
- El sistema debería permitir consultar productos.
- El sistema debería permitir generar facturas.
- El sistema debería permitir generar y presentar los impuestos correspondientes.
- El sistema debería permitir consultar todas las facturas emitidas.
- Al momento de generarse una factura, el sistema debería actualizar el stock de los productos vendidos.

## Diagrama de base de datos

<img width="1001" height="432" alt="DiagramaBaseDatos" src="https://github.com/user-attachments/assets/db79185c-d166-45f1-ac68-82748db99fcb" />

## Diagrama de flujo

<img width="110" height="1031" alt="imagen" src="https://github.com/user-attachments/assets/0a39d8a9-d0ca-4c94-8d30-02cc94b54b7a" />

