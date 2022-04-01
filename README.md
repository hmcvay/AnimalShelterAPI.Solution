# Animal Shelter API

#### By Hayley McVay

## Description

An API that functions to keep track of adoptable pets for an animal shelter. It utilizes RESTful principles, and Swagger UI. 

<br>

## Technologies Used

* C#
* .NET 5.0
* Microsoft EntityFrameworkCore
* ASP.NET MVC
* MySQL Workbench
* Postman
* Swagger

<br>

## Setup/Installation Requirements
<br>

### NECESSARY INSTALLATIONS

* [.NET SDK](https://dotnet.microsoft.com/en-us/download/dotnet/thank-you/sdk-5.0.401-macos-x64-installer)
* [MySQL Workbench](https://dev.mysql.com/downloads/workbench/)
* (Optional)[Postman](https://www.postman.com/downloads/)

### SETUP STEPS

1. Clone [this](https://github.com/hmcvay/AnimalShelterAPI.Solution) repository to your desktop.
2. Navigate to the project's root directory and create `appsettings.json` file with the following code: 

```
{
  "Logging": {
    "LogLevel": {
      "Default": "Warning",
      "System": "Information",
      "Microsoft": "Information"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=hayley_mcvay;uid=root;pwd={YOURPASSWORDHERE};"
  }
}
```

3. Change the server, port, and userid as necessary. Replace `{YOURPASSWORDHERE}` with the password you used when setting up MySQLWorkbench.

### COMMANDS

1. Navigate to the production directory, `AnimalShelter`: 
  * Run `dotnet restore` to restore all dependencies
  * Run `dotnet ef database update` to connect to the database
  * Run `dotnet build` to ensure no errors
  * Run `dotnet run` to run the program
  * You can now access the API either in Postman or your browser

<br>

## EXPLORING THE API

<b>Using Swagger:</b> To explore the API with Swagger, after launching the project with `dotnet run`, input the following URL to the browser: `http://localhost:5000/swagger`

You will be able to browse/access endpoints here via swagger, or alternatively 

<b>Using Postman</b> Enter endpoints into the `GET`, or alternatively, add objects into the API via `POST`.

### ENDPOINTS

Base URL: `http://localhost:5000`
HTTP Request Structure
```
GET /api/animals
POST /api/animals
GET /api/animals/{id}
PUT /api/animals/{id}
DELETE /api/animals{id}
```
<br>
Example request:
```
http://localhost:5000/api/animals/4
```
<br>
Sample JSON Response
```
{
  "animalId": 2,
  "species": "dog",
  "name": "burger",
  "age": 1,
  "sex": "F",
  "description": "loves belly rubs"
}
```
<br>

### QUERIES





<br>

## Known Bugs

* Currently you can have duplicate relationships; you can add croissant to "sweet" more than once, so when you click on "sweet" flavor it will list multiple "croissant"s.

<br>

## License

[ISC](https://opensource.org/licenses/ISC)

<br>

## Contact

_Copyright (c) 2022 Hayley McVay_

