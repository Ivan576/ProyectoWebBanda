Create database web120M;
create table Evento
(
idEvento int primary key auto_increment,
nombre varchar(25) not null,
fecha datetime not null,
ubicacion varchar(50) not null,
linkEvento text not null
);

create table Admin
(
usuario varchar(25) primary key,
contrasenia varchar(25) not null,
nombre varchar(25) not null,
correo varchar(50) not null
);

create table Noticia
(
idNoticia int primary key auto_increment,
titulo varchar(50) not null,
resumen text not null,
contenido text not null,
fecha date not null,
imagenPortada blob not null,
imagenesContenido blob not null
);

create table Vinculo
(
idVinculo int primary key auto_increment,
nombreVinculo varchar(50) not null,
imagen blob null
);

create table Multimedia
(
idMultimedia int primary key auto_increment,
titulo varchar(25) not null,
formato varchar(25) not null,
link text not null
);

create table Plataforma
(
idPlataforma int primary key auto_increment,
nombre varchar(50) not null,
link text not null,
imagen blob not null
);

create table Album
(
idAlbum int primary key auto_increment,
titulo varchar(25) not null,
tipo varchar(25) not null,
noCanciones int not null,
portada blob not null,
artista varchar(25) not null,
idMultimedia int not null,
idPlataforma int not null,
FOREIGN KEY(idMultimedia) REFERENCES Multimedia(idMultimedia),
FOREIGN KEY(idPlataforma) REFERENCES Plataforma(idPlataforma)
);

create table Cancion
(
idCancion int primary key auto_increment,
nombre varchar(25) not null,
duracion time not null,
genero varchar(25) not null,
idAlbum int not null,
idPlataforma int not null,
FOREIGN KEY(idAlbum) REFERENCES Album(idAlbum),
FOREIGN KEY(idPlataforma) REFERENCES Plataforma(idPlataforma)
);