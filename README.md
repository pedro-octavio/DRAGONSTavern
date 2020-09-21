# DRAGONSTAVERN
 DRAGONSTavern is a project that consists of a nerdy news site made with Angular, which uses a .Net Core API and a manager made with Windows Forms.
## PREREQUESITES
* [.Net Core](https://dotnet.microsoft.com/download);
* Some Database, in this case as using [MySql](https://www.mysql.com);
## CONFIGURING THE PROJECT
1) Install necessary packges:
> Executing the "Restore NuGet Packges" in Visual Studio, or dotnet restore in root directory of API
2) Insert your connectionstring in Backend/DRAGONSTavern.API/appsettings.json
3) Update database using this command:
> Visual Studio: Update-Database
> Some text editor: dotnet  ef database update
5) Run the Backend/DRAGONSTavern.API;
## MAKE WITH
* .Net Core
* EntityFramework
* FluentValidator
* Autofac
* MySql
* IdentityModel
## VERSIONS
* 1.0.0 - First Commit;
## CONTRIBUITORS
* [**Pedro Octávio**](https://github.com/pedro-octavio) - *desenvolviment of project*
