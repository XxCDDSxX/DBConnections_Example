CREATE DATABASE ejemplo_db
WITH OWNER cdds
ENCODING 'UTF-8';
\c ejemplo_db

CREATE SCHEMA main;
CREATE DOMAIN main.nombre AS VARCHAR(50) CONSTRAINT d1 CHECK (VALUE~*'^[A-Z ]+$');
CREATE TABLE main.usuarios(
    id BIGINT PRIMARY KEY NOT NULL,
    nombre main.nombre NOT NULL,
    correo VARCHAR(30) DEFAULT 'ejemplo@correo.com'
);