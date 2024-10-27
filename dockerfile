# Usa la imagen oficial de PostgreSQL
FROM postgres:latest

# Establece las variables de entorno para la base de datos
ENV POSTGRES_USER=cdds
ENV POSTGRES_PASSWORD=1234

# Copia el archivo de script SQL a la carpeta raíz
COPY Ejemplo.sql /Ejemplo.sql

# Expone el puerto de PostgreSQL
EXPOSE 5432
