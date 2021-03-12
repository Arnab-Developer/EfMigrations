# EF Migrations demo

An example ASP.NET application with EF Migrations following below doc

https://docs.microsoft.com/en-us/ef/core/managing-schemas/migrations/?tabs=dotnet-core-cli

I have used two databases for this app. One is for dev env and another is for prd env. To create and 
update dev database, I have used EF Migrations (add migrations and update database). 

```
dotnet ef migrations add InitialCreate

dotnet ef database update

dotnet ef migrations add AddStudentSubject

dotnet ef database update
```

To create and update prd database, I have generated SQL script with EF Migrations and executed in there.

```
dotnet ef migrations script

dotnet ef migrations script InitialCreate
```