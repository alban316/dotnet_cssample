Command-line basics:

dotnet new #initializes a project with Program.cs and project.json

dotnet restore #generates a 'lock' file required by dotnet build

dotnet build #compiles to a dll which can be invoked by dotnet

dotnet publish #complies a binary executable under the following conditions: 1. The project.json does not include a type under Microsoft.NETCore.App of "platform", 2. there's an appropriate runtimes node in project.json. Note(s): a. If runtime node is added after dotnet restore, it may be necessary to re-run dotnet restore. b. Even though linuxmint.17.3-x64 is a supported RID and an exact match for my system, dotnet detected and required the ubuntu.14.04-x64 RID instead.


To run as portable:

dotnet /bin/Debug/netcoreapp1.0/cssample.dll


Creating self-contained binaries:

https://docs.microsoft.com/en-us/dotnet/articles/core/app-types#self-contained-application


Runtime IDentifier (RID):

https://docs.microsoft.com/en-us/dotnet/articles/core/rid-catalog#what-are-rids
