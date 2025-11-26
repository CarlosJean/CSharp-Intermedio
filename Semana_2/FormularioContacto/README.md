### Pasos para configurar el proyecto

1. Descargue el proyecto en su directorio preferido.
2. Dentro del proyecto FormularioContacto.Wform, crear un archivo appsettings.cs y aplicar el siguiente contenido:
  
        {
            "ConnectionStrings": {
              "DefaultConnection": "Data Source={TuServidor};Initial Catalog=LibretaContactos;Integrated Security=True;TrustServerCertificate=True;"
            }
        }
     
2. Abrir la terminal de tu computadora y ejecutar la migración para crear la base de datos
   
        dotnet ef database update -s FormularioContacto.WForm -p FormularioContacto.DAL -c ApplicationDbContext

## Imágenes

<img width="909" height="482" alt="imagen" src="https://github.com/user-attachments/assets/5d0ef041-50f8-4714-a76e-70d7a6b4f0f2" />


### Registrar nuevo contacto
<img width="909" height="482" alt="imagen" src="https://github.com/user-attachments/assets/3ce7a6a4-fce2-48bc-a7df-71b7c1d71a2f" />
<img width="909" height="490" alt="imagen" src="https://github.com/user-attachments/assets/973a6537-6b63-4059-8480-d9025b0647e9" />
<img width="909" height="482" alt="imagen" src="https://github.com/user-attachments/assets/6af3d651-14aa-4cd5-9c45-86f2615e5852" />

### Modificar contacto
<img width="909" height="483" alt="imagen" src="https://github.com/user-attachments/assets/254ee5ae-7724-4357-b7dc-00f873ee207e" />
<img width="910" height="485" alt="imagen" src="https://github.com/user-attachments/assets/00d90bf3-8980-4b64-ab07-e6ebf870ef85" />

### Remover contactos
<img width="911" height="488" alt="imagen" src="https://github.com/user-attachments/assets/80741165-4460-4042-98a8-7c2ceb9c1700" />
<img width="910" height="487" alt="imagen" src="https://github.com/user-attachments/assets/b7aeec75-7def-4cb3-ab46-66b2cff899f7" />
<img width="909" height="482" alt="imagen" src="https://github.com/user-attachments/assets/31aecca1-3868-4485-acb9-33f618dceac6" />

### Consulta de contactos

<img width="909" height="482" alt="imagen" src="https://github.com/user-attachments/assets/5ea06545-6b95-4b8c-9730-f4aa9e73372d" />
<img width="909" height="482" alt="imagen" src="https://github.com/user-attachments/assets/1726b869-d8fa-4b20-89ab-bf54d652e6f7" />



