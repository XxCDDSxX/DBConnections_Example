# Ejemplo de conexión de .NET con PostgreSQL
En este repositorio se muestra el ejemplo de como conectar una base de datos de PostgreSQL utilizando C# y Visual Basic.
## Consideraciones
- La carpeta **DOTNET** es un proyecto creado con [Visual Studio 2022](https://visualstudio.microsoft.com/es/downloads/).
- Para crear la base de datos es necesaria tener una instancia de [PostgreSQL](https://www.postgresql.org/download/).
  -  La instancia también puede ser un contenedor, en el ejemplo se utiliza un contenedor de [Docker](https://docs.docker.com/desktop/install/windows-install/)
- El Script **Ejemplo.sql** crea la base de datos de ejemplo, está escrito para ejecutarse desde la terminal/cmd.

>**NOTA:**
> El script utiliza el usuario *cdds* en la parte `OWNER cdds` puede cambiarlo por el usuario predeterminado *postgres* y ejecutar el comando
>
>`psql -U postgres -d postgres -f [ruta]\Ejemplo.sql`
>

>**NOTA:**
>En el caso de utilizar el contenedor hay que cambiar los nombres de usuario y contraseña en los archivos **dockerfile** y **docker-compose.yml**.
>después, ejecute en la carpeta del proyecto el comando:
> 
> `docker-compose up -d`
>
>Esto ejecutará los archivos **dockerfile** y **docker-compose.yml**.
>
>Finalmente ejecute en el interior del contenedor el script *Ejemplo.sql* que se encuentra en root. Para acceder al contenedor utilice:
>
>`docker exec -it [ID_DEL_CONTENEDOR] bash`
