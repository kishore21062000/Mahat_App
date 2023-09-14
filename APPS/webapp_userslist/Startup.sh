#!/bin/bash
ROOTDIRECTORY=$(cd -P -- "$(dirname -- "${BASH_SOURCE[0]}")" && pwd -P)


ExistFile="$ROOTDIRECTORY"/userslist.Models/userslist.Models.csproj
if [ -f "$ExistFile" ]; then
	echo "Model File Found"
else
	echo cma2020# | sudo -S  dotnet new classlib -n userslist.Models --framework netcoreapp3.1 --force
	cd "$ROOTDIRECTORY"/userslist.Models
	echo cma2020# | sudo -S  dotnet add package FluentValidation.AspNetCore --version 8.6.2
fi
echo "Into the build section for Models"
cd "$ROOTDIRECTORY"/userslist.Models
echo "The current directory is : Expecting Model folder"
pwd
echo cma2020# | sudo -S  dotnet build
echo "This is before check for DAL project file"
ExistFile="$ROOTDIRECTORY"/userslist.DAL/userslist.DAL.csproj
if [ -f "$ExistFile" ]; then
	echo "DAL File Found"
else
    cd "$ROOTDIRECTORY"
	echo cma2020# | sudo -S  dotnet new classlib -n userslist.DAL --framework netcoreapp3.1 --force
	echo cma2020# | sudo -S  dotnet add userslist.DAL/userslist.DAL.csproj reference userslist.Models/userslist.Models.csproj
	cd userslist.DAL
	echo cma2020# | sudo -S  dotnet add package Npgsql --version 5.0.3
    echo cma2020# | sudo -S  dotnet add package Microsoft.AspNetCore.Mvc.NewtonsoftJson --version 3.1.6
fi
cd "$ROOTDIRECTORY"/userslist.DAL
echo "The current directory is : Expecting DAL folder"
pwd
echo cma2020# | sudo -S  dotnet build

ExistFile="$ROOTDIRECTORY"/userslist/userslist.csproj
if [ -f "$ExistFile" ]; then
	echo "userslist Web found"
else
	cd "$ROOTDIRECTORY"
	echo cma2020# | sudo -S  dotnet new web -n userslist --framework netcoreapp3.1 --force
	echo "This is after Web userslist create"
	echo cma2020# | sudo -S  cp -f "$ROOTDIRECTORY"/PreRequisites/*.* "$ROOTDIRECTORY"/userslist/
	echo cma2020# | sudo -S  dotnet add userslist/userslist.csproj reference userslist.Models/userslist.Models.csproj
	echo cma2020# | sudo -S  dotnet add userslist/userslist.csproj reference userslist.DAL/userslist.DAL.csproj
	echo "after adding Project References"
	cd "$ROOTDIRECTORY"/userslist
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
echo "Into the build section for userslist"
cd "$ROOTDIRECTORY"/userslist
echo cma2020# | sudo -S  dotnet build
echo cma2020# | sudo -S  dotnet publish -o "$ROOTDIRECTORY"/Publish/userslist

echo "Setting up the Publish Evnrionment"
cd /home/ubuntu/Automaton/AutomatonClient/wwwroot/PublishedFiles
echo cma2020# | sudo -S  chown -R ubuntu userslist
cd "$ROOTDIRECTORY"
echo cma2020# | sudo -S  rm -f /etc/nginx/sites-enabled/sandbox83
echo cma2020# | sudo -S  rm -f /etc/supervisor/conf.d/userslist*.conf                
echo cma2020# | sudo -S  cp "$ROOTDIRECTORY"/PublishRequisites/*.conf /etc/supervisor/conf.d/
echo cma2020# | sudo -S  cp "$ROOTDIRECTORY"/PublishRequisites/sandbox83 /etc/nginx/sites-enabled/
echo cma2020# | sudo -S  supervisorctl reread
echo cma2020# | sudo -S  supervisorctl update
echo cma2020# | sudo -S  supervisorctl restart userslistuserslist
echo cma2020# | sudo -S  service nginx reload
curl -v --header "Connection: keep-alive" "http://localhost:5011/ContactUs/sentPublishedNotification?projectid=96120896-7735-46b2-b84f-e633e91bd89b"

