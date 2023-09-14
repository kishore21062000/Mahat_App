#!/bin/bash
ROOTDIRECTORY=$(cd -P -- "$(dirname -- "${BASH_SOURCE[0]}")" && pwd -P)


ExistFile="$ROOTDIRECTORY"/Timemajesty.Models/Timemajesty.Models.csproj
if [ -f "$ExistFile" ]; then
	echo "Model File Found"
else
	echo cma2020# | sudo -S  dotnet new classlib -n Timemajesty.Models --framework netcoreapp3.1 --force
	cd "$ROOTDIRECTORY"/Timemajesty.Models
	echo cma2020# | sudo -S  dotnet add package FluentValidation.AspNetCore --version 8.6.2
fi
echo "Into the build section for Models"
cd "$ROOTDIRECTORY"/Timemajesty.Models
echo "The current directory is : Expecting Model folder"
pwd
echo cma2020# | sudo -S  dotnet build
echo "This is before check for DAL project file"
ExistFile="$ROOTDIRECTORY"/Timemajesty.DAL/Timemajesty.DAL.csproj
if [ -f "$ExistFile" ]; then
	echo "DAL File Found"
else
    cd "$ROOTDIRECTORY"
	echo cma2020# | sudo -S  dotnet new classlib -n Timemajesty.DAL --framework netcoreapp3.1 --force
	echo cma2020# | sudo -S  dotnet add Timemajesty.DAL/Timemajesty.DAL.csproj reference Timemajesty.Models/Timemajesty.Models.csproj
	cd Timemajesty.DAL
	echo cma2020# | sudo -S  dotnet add package Npgsql --version 5.0.3
    echo cma2020# | sudo -S  dotnet add package Microsoft.AspNetCore.Mvc.NewtonsoftJson --version 3.1.6
fi
cd "$ROOTDIRECTORY"/Timemajesty.DAL
echo "The current directory is : Expecting DAL folder"
pwd
echo cma2020# | sudo -S  dotnet build

ExistFile="$ROOTDIRECTORY"/Timemajesty/Timemajesty.csproj
if [ -f "$ExistFile" ]; then
	echo "Timemajesty Web found"
else
	cd "$ROOTDIRECTORY"
	echo cma2020# | sudo -S  dotnet new web -n Timemajesty --framework netcoreapp3.1 --force
	echo "This is after Web Timemajesty create"
	echo cma2020# | sudo -S  cp -f "$ROOTDIRECTORY"/PreRequisites/*.* "$ROOTDIRECTORY"/Timemajesty/
	echo cma2020# | sudo -S  dotnet add Timemajesty/Timemajesty.csproj reference Timemajesty.Models/Timemajesty.Models.csproj
	echo cma2020# | sudo -S  dotnet add Timemajesty/Timemajesty.csproj reference Timemajesty.DAL/Timemajesty.DAL.csproj
	echo "after adding Project References"
	cd "$ROOTDIRECTORY"/Timemajesty
	echo cma2020# | sudo -S  dotnet add package NLog --version 4.7.2
	echo cma2020# | sudo -S  dotnet add package NLog.Web.AspNetCore --version 4.9.2
	echo cma2020# | sudo -S  dotnet add package NLog.Extensions.Logging --version 1.6.4
	echo cma2020# | sudo -S  dotnet add package NLog.MailKit --version 3.2.0
    echo cma2020# | sudo -S  dotnet add package Microsoft.AspNet.WebApi.Cors --version 5.2.7
    echo cma2020# | sudo -S  dotnet add package Microsoft.AspNetCore.Mvc.NewtonsoftJson --version 3.1.6
    echo cma2020# | sudo -S  dotnet add package Microsoft.AspNetCore.Authentication.JwtBearer --version 3.1.6
    echo cma2020# | sudo -S  dotnet add package Microsoft.AspNetCore.Mvc.Razor.RuntimeCompilation --version 3.1.6
    echo cma2020# | sudo -S  dotnet add package Swashbuckle.AspNetCore --version 6.1.1
    echo cma2020# | sudo -S  dotnet add package Swashbuckle.AspNetCore.SwaggerUi --version 6.1.1
	echo cma2020# | sudo -S  dotnet add package RestSharp --version 106.11.7
    echo cma2020# | sudo -S  dotnet add package IdentityServer4.AccessTokenValidation --version 2.7.0
     
fi
echo "Into the build section for Timemajesty"
cd "$ROOTDIRECTORY"/Timemajesty
echo cma2020# | sudo -S  dotnet build
echo cma2020# | sudo -S  dotnet publish -o "$ROOTDIRECTORY"/Publish/Timemajesty

echo "Setting up the Publish Evnrionment"
cd /home/ubuntu/Automaton/AutomatonClient/wwwroot/PublishedFiles
echo cma2020# | sudo -S  chown -R ubuntu Timemajesty
cd "$ROOTDIRECTORY"
echo cma2020# | sudo -S  rm -f /etc/nginx/sites-enabled/sandbox83
echo cma2020# | sudo -S  rm -f /etc/supervisor/conf.d/Timemajesty*.conf                
echo cma2020# | sudo -S  cp "$ROOTDIRECTORY"/PublishRequisites/*.conf /etc/supervisor/conf.d/
echo cma2020# | sudo -S  cp "$ROOTDIRECTORY"/PublishRequisites/sandbox83 /etc/nginx/sites-enabled/
echo cma2020# | sudo -S  supervisorctl reread
echo cma2020# | sudo -S  supervisorctl update
echo cma2020# | sudo -S  supervisorctl restart TimemajestyTimemajesty
echo cma2020# | sudo -S  service nginx reload
curl -v --header "Connection: keep-alive" "http://localhost:5011/ContactUs/sentPublishedNotification?projectid=1d39fb25-1890-47af-8481-f36e2e72dca5"

