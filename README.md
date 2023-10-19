# NotiApp-SebastianArciniegas

## Estructura del Proyecto

- **Api**: Proyecto WebApi proporiona EndPoints, tambien se configuran los controladores y autenticacion.

- **Core**: Proyecto  Contiene la logica de negocios y de la aplicacion, tambien contiene las entidades.

- **Infrastructure**:Este proyecto contiene el acceso a la base de datos y tambien la configuracion de las tablas.

## Pasos de creacion de proyecto

### Creacion de la solucion

```bash
    dotnet new sln
```

### Creacion del proyecto Api

```bash
    dotnet new webapi -o Api
```

### Creacion del proyecto Core

```bash
    dotnet new classlib -o Core
```

### Creacion del proyecto Infrastructure 

```bash
    dotnet new classlib -o Infrastructure
```

### Agregar proyectos a la solucion principal

```bash
    dotnet sln add Infrastructure
    dotnet sln add Core
    dotnet sln add Api
```

### Agregar Referencias entre proyectos
Primero nos ubicamos en api y referenciamos a Infrastructura, Luego nos ubicamos en Infrastructure y refenciamos a Core

```bash
    dotnet add reference ../Infrastructure
    dotnet add reference ../Code
```

## Instalacion de paquetes 

### Proyecto WebApi api

```bash
dotnet add package Microsoft.AspNetCore.Authentication.JwtBearer --version 7.0.10
dotnet add package Microsoft.EntityFrameworkCore --version 7.0.10
dotnet add package Microsoft.EntityFrameworkCore.Design --version 7.0.10
dotnet add package Microsoft.Extensions.DependencyInjection --version 7.0.0
dotnet add package System.IdentityModel.Tokens.Jwt --version 6.32.3
dotnet add package Serilog.AspNetCore --version 7.0.0
dotnet add package AutoMapper.Extensions.Microsoft.DependencyInjection --version 12.0.1
Despues de las entidades se implementan los metodos en los repositorios
```
### Proyecto ClassLib Infrastructure

```bash
dotnet add package Pomelo.EntityFrameworkCore.MySql --version 7.0.0
dotnet add package Microsoft.EntityFrameworkCore --version 7.0.10
dotnet add package CsvHelper --version 30.0.1
```
