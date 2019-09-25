# Starter Template for .Net Core Web Api
--------------------------------------
This project contains recipe project that will provide CRUD operations for EntitFrameWork. Repository pattern has been implemented on this template.

### Functionality Implemented 
--------------------
* Swagger
* Authentication, Authorization with .net core identity
* Authentication mechanism is jwt bearer token with refresh token implemented.
* Nlog is used for logging
* Some action filter has been implemented to handle global exception and model validation.
* Entityframework code approach has been used in this template with intitial seed function configured
* Automapper
* App insight

### Project Structure
------------
This project is following the repository pattern and it contains the following sub-projects
* Api
* Api.Common
* Api.Core
* Api.Database
* Api.Repository
* Api.Service

##### Api
* It is our main project and it contains the controller, action filters, startup, app settings, and the dependency injection.

##### Api.Common
* This project contains common features like enum, helpers, constant which are being used by every project.

##### Api.Core
* This project contains the entity, DTO, migration, db context, jwt token implementation and the interfaces for the Repository, Services.

##### Api.Service
* This project contains the services which are being consumed by the controller furthers these services calls the repository it aslo contains the business logic. This project is working as a middle layer between Api and Repository project.

##### Api.Repository
* This project contains the repository classes which are being consumed by the services. Basically respository represents a database entity. Repository provides CRUD operations for any database entity.

##### Api.Database
It our recipe project which provides the database functions for the database operations.

### How to Start
------------
* Test Controller has been available for quick start guidance. Please have a look.
* A controller will be represting an entity for e.g users. To fetch list of users from AspNetUsers table. There must be a usercontroller with userservice through constructor injection. Please see DependecyInjection.cs how services and repository are inejected. Any new service and repository that is created will be required to register to the DependecyInjection.cs file.
* On how to create service and repository for any entity. Please have a look at TestTableService and TestTableRepository. 
* Working Authentication is available. It can be tested from swagger. with UserName : superAdmin ,pwd: B00km@rk
* TestController can be tested with authorization by fist calling login . Capture token , then passing in Authorization header through postman or from swagger. 
* Logging sample on to create Logs is availabel on Testcontroller-> GetAllTestResults(). Log file is available on project bin folder.
* For Every api response DataTransferObject class has been used that will return paginginfo ,filter, sorting etc..
* For Crud operations please see AuthService.cs


### How to add migrations and update database
-----------------------------------------
* Open package manager console then write 'add-migration 'migrationName''. see other commands at https://www.entityframeworktutorial.net/efcore/entity-framework-core-migration.aspx
* If above one doesn't work then open cli. Navigate to .Core project. Write "dotnet ef migrations add 'migrationname' -s ../Template". -S refers to startup project. For further command, use above mentioned link.

### How to generate swagger docs
-----------------------------------------
* Add the Swagger response attribute on action. 
```ruby
        [HttpGet]
        [SwaggerResponse(200, Type=typeof(DataTransferObject<<TestTableDTO>>))]
        public async Task<IActionResult> GetAllTestResults()
        {
            _logger.LogInformation("Get All Results Called...");  
            return this.JsonResponse(await testService.GetAll());
        }
```
* Run project and then go to this url for the swagger docs. 
https://localhost:44353/swagger/index.html 
