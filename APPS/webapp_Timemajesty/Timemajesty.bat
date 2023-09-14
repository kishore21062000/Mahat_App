SET ROOTDIRECTORY=%~dp0
SET ExistFile=%ROOTDIRECTORY%\Timemajesty.Models\Timemajesty.Models.csproj
cd %ROOTDIRECTORY%
if exist %ExistFile% goto  RUN_DOTNET
dotnet new classlib -n Timemajesty.Models --framework netcoreapp3.1 --force
cd Timemajesty.Models
dotnet add package FluentValidation.AspNetCore --version 8.6.2
dotnet build
cd..
dotnet new classlib -n Timemajesty.DAL --framework netcoreapp3.1 --force
dotnet add Timemajesty.DAL/Timemajesty.DAL.csproj reference Timemajesty.Models/Timemajesty.Models.csproj
cd Timemajesty.DAL
dotnet add package Npgsql --version 5.0.3
dotnet add package Microsoft.AspNetCore.Mvc.NewtonsoftJson --version 3.1.6
dotnet build
:RUN_DOTNET
cd %ROOTDIRECTORY%\
cd Timemajesty.Models
dotnet build
cd..
cd Timemajesty.DAL
dotnet build
cd..
setx ASPNETCORE_ENVIRONMENT "Development"
SET ExistProjectFile=%ROOTDIRECTORY%\Timemajesty\Timemajesty.csproj
if exist %ExistProjectFile% goto  RUN_DOTNET
dotnet new web -n Timemajesty --framework netcoreapp3.1 --force
xcopy /y  "%ROOTDIRECTORY%\PreRequisites" "%ROOTDIRECTORY%\Timemajesty"
dotnet add Timemajesty/Timemajesty.csproj reference Timemajesty.Models/Timemajesty.Models.csproj
dotnet add Timemajesty/Timemajesty.csproj reference Timemajesty.DAL/Timemajesty.DAL.csproj
cd Timemajesty
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
cd %ROOTDIRECTORY%\Timemajesty
dotnet run

