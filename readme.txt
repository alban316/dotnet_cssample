dotnet new #initializes a project with Program.cs and project.json
dotnet restore #generates a 'lock' file required by dotnet build
dotnet build #compiles to a dll which can be invoked by dotnet
dotnet publish #supposedly complies an executable - if there's a runtimes node in project.json


To run as portable:

dotnet /bin/Debug/netcoreapp1.0/cssample.dll

Creating Self-Contained apps:

https://docs.microsoft.com/en-us/dotnet/articles/core/app-types#self-contained-application

Runtime IDentifier (RID):

https://docs.microsoft.com/en-us/dotnet/articles/core/rid-catalog#what-are-rids
