SET ROOTDIRECTORY=%~dp0
SET ExistFile=%ROOTDIRECTORY%\DineandDiscover.Models\DineandDiscover.Models.csproj
cd %ROOTDIRECTORY%
if exist %ExistFile% goto  RUN_DOTNET
dotnet new classlib -n DineandDiscover.Models --framework netcoreapp3.1 --force
cd DineandDiscover.Models
dotnet add package FluentValidation.AspNetCore --version 8.6.2
dotnet build
cd..
dotnet new classlib -n DineandDiscover.DAL --framework netcoreapp3.1 --force
dotnet add DineandDiscover.DAL/DineandDiscover.DAL.csproj reference DineandDiscover.Models/DineandDiscover.Models.csproj
cd DineandDiscover.DAL
dotnet add package Npgsql --version 5.0.3
dotnet add package Microsoft.AspNetCore.Mvc.NewtonsoftJson --version 3.1.6
dotnet build
:RUN_DOTNET
cd %ROOTDIRECTORY%\
cd DineandDiscover.Models
dotnet build
cd..
cd DineandDiscover.DAL
dotnet build
cd..
setx ASPNETCORE_ENVIRONMENT "Development"
SET ExistProjectFile=%ROOTDIRECTORY%\DineandDiscover\DineandDiscover.csproj
if exist %ExistProjectFile% goto  RUN_DOTNET
dotnet new web -n DineandDiscover --framework netcoreapp3.1 --force
xcopy /y  "%ROOTDIRECTORY%\PreRequisites" "%ROOTDIRECTORY%\DineandDiscover"
dotnet add DineandDiscover/DineandDiscover.csproj reference DineandDiscover.Models/DineandDiscover.Models.csproj
dotnet add DineandDiscover/DineandDiscover.csproj reference DineandDiscover.DAL/DineandDiscover.DAL.csproj
cd DineandDiscover
dotnet add package Wdc.System.Net.Http.Formatting.NetStandard --version 1.0.7
dotnet add package NLog --version 4.7.2
dotnet add package NLog.Web.AspNetCore  --version 4.9.2
dotnet add package NLog.Extensions.Logging  --version 1.6.4
dotnet add package NLog.MailKit  --version 3.2.0
dotnet add package Microsoft.AspNetCore.Mvc.NewtonsoftJson --version 3.1.6
dotnet add package Microsoft.AspNetCore.Authentication.JwtBearer --version 3.1.6
dotnet add package Microsoft.AspNetCore.Mvc.Razor.RuntimeCompilation --version 3.1.6
dotnet add package Swashbuckle.AspNetCore --version 6.1.1
dotnet add package Swashbuckle.AspNetCore.SwaggerUi --version 6.1.1
dotnet add package RestSharp --version 106.11.7
:RUN_DOTNET
cd %ROOTDIRECTORY%\DineandDiscover
dotnet run

