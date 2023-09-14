SET ROOTDIRECTORY=%~dp0
SET ExistFile=%ROOTDIRECTORY%\Client\Client.csproj
cd %ROOTDIRECTORY%
if exist %ExistFile% goto  RUN_DOTNET
dotnet new web -n Client --framework netcoreapp3.1 --force
xcopy /y  "%ROOTDIRECTORY%\ClientRequisites" "%ROOTDIRECTORY%\Client"
robocopy  "%ROOTDIRECTORY%\wwwroot" "%ROOTDIRECTORY%\\Client\wwwroot" /E 
dotnet add Client/Client.csproj reference Multilingual.Models/Multilingual.Models.csproj
cd Client
dotnet add package Wdc.System.Net.Http.Formatting.NetStandard --version 1.0.7
dotnet add package NLog --version 4.7.2
dotnet add package System.Data.SqlClient --version 4.8.3
dotnet add package NLog.Web.AspNetCore  --version 4.9.2
dotnet add package NLog.Extensions.Logging  --version 1.6.4
dotnet add package NLog.MailKit  --version 3.2.0
dotnet add package Microsoft.AspNetCore.Mvc.Razor.RuntimeCompilation --version 3.1.6
dotnet add package Microsoft.AspNetCore.Mvc.NewtonsoftJson --version 3.1.6
dotnet add package IdentityServer4.AccessTokenValidation --version 2.7.0
dotnet add package Microsoft.AspNetCore.Authentication.OpenIdConnect --version 3.1.9
:RUN_DOTNET
cd %ROOTDIRECTORY%\Client
dotnet run

