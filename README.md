# Alb.BlazorApp

## Capa de presentación - Alb.BlazorApp.Client
Es la capa de UI intereacción con el usuario y validación de entradas, interactua con la capa de aplicación consumiendo la api a traves de peticiones HTTP.
Hace uso de los DTO para intercambiar mensajes con la Web API.

### Proyecto
- Proyecto Blazor WebAssembly
- .Net 6.0

### Referencia
- Alb.BlazorApp.Shared


## Capa de aplicación - Alb.BlazorApp.Server
Es la capa de aplicación, se encarga de los casos de uso, interactua con el dominio enviando mensajes para ser procesados conforme a la logica de negocio y espera respuesta.
Interactua con la UI mediante DTOs y mapea modelos a partir de los DTOs para interactuar con el dominio.
Tiene visibilidad de los DTO
Tiene visibilidad de las entidades

### Proyecto
- Proyecto Web API
- .Net 6.0
- AutoMapper

### Referencia
- Alb.BlazorApp.Client
- Alb.BlazorApp.Share
- Alb.Entities

## Capa de compartida - Alb.BlazorApp.Shared
Capa comun o capa compartida entre las demas capas, contiene clases, enumeradores, y definicios que son visibles por las capas Client y Server.

### Proyecto
- Proyecto Class Library
- .Net 6.0

### Referencia
- Sin referencias a capas superiores

## Capa de dominio - Alb.ConsoleApp.Microservice
Capa de dominio responsable de la logica de negocio, se encarga de la logica de negocio de los casos de uso recibidos desde la capa de aplicación
gestiona el acceso a la BD y devuelve el resultado usando modelos para counicarse con la capa de aplicación.

### Proyecto
- Proyecto Console App
- .Net 6.0

### Referencia
- Alb.Entities

## Capa de entidades - Alb.Entities
Capa definida para separar las entidades y modelos de negocio fuera de la capa de dominio, la justificación de esta capa es la cantidad de modelos y entidades definidas para el proyecto,
las entidades y modelos deben ser visibles para la capa de dominio y aplicación

### Proyecto
- Proyecto Class Library
- .Net Standard 2.1

### Referencia
- Sin referencias a capas superiores
