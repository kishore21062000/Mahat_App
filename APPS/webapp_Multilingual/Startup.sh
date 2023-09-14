#!/bin/bash
ROOTDIRECTORY=$(cd -P -- "$(dirname -- "${BASH_SOURCE[0]}")" && pwd -P)


ExistFile="$ROOTDIRECTORY"/Multilingual.Models/Multilingual.Models.csproj
if [ -f "$ExistFile" ]; then
	echo "Model File Found"
else
	echo cma2020# | sudo -S  dotnet new classlib -n Multilingual.Models --framework netcoreapp3.1 --force
	cd "$ROOTDIRECTORY"/Multilingual.Models
	echo cma2020# | sudo -S  dotnet add package FluentValidation.AspNetCore --version 8.6.2
fi
echo "Into the build section for Models"
cd "$ROOTDIRECTORY"/Multilingual.Models
echo "The current directory is : Expecting Model folder"
pwd
echo cma2020# | sudo -S  dotnet build
echo "This is before check for DAL project file"
ExistFile="$ROOTDIRECTORY"/Multilingual.DAL/Multilingual.DAL.csproj
if [ -f "$ExistFile" ]; then
	echo "DAL File Found"
else
    cd "$ROOTDIRECTORY"
	echo cma2020# | sudo -S  dotnet new classlib -n Multilingual.DAL --framework netcoreapp3.1 --force
	echo cma2020# | sudo -S  dotnet add Multilingual.DAL/Multilingual.DAL.csproj reference Multilingual.Models/Multilingual.Models.csproj
	cd Multilingual.DAL
	echo cma2020# | sudo -S  dotnet add package EnterpriseLibrary.Caching.Database.NetCore --version 5.0.512
    echo cma2020# | sudo -S  dotnet add package Microsoft.AspNetCore.Mvc.NewtonsoftJson --version 3.1.6
fi
cd "$ROOTDIRECTORY"/Multilingual.DAL
echo "The current directory is : Expecting DAL folder"
pwd
echo cma2020# | sudo -S  dotnet build


ExistFile="$ROOTDIRECTORY"/MultilingualWebApi/MultilingualWebApi.csproj
if [ -f "$ExistFile" ]; then
	echo "Multilingual Web API found"
else
	cd "$ROOTDIRECTORY"
	echo cma2020# | sudo -S  dotnet new webapi -n MultilingualWebApi --framework netcoreapp3.1 --force
	echo "This is after WebAPI creaate"
	echo cma2020# | sudo -S  cp -f "$ROOTDIRECTORY"/MultilingualWebApiRequisites/*.* "$ROOTDIRECTORY"/MultilingualWebApi/
	echo cma2020# | sudo -S  dotnet add MultilingualWebApi/MultilingualWebApi.csproj reference Multilingual.Models/Multilingual.Models.csproj
	echo cma2020# | sudo -S  dotnet add MultilingualWebApi/MultilingualWebApi.csproj reference Multilingual.DAL/Multilingual.DAL.csproj
	echo "after adding Project References"
	cd "$ROOTDIRECTORY"/MultilingualWebApi
	echo cma2020# | sudo -S  dotnet add package NLog --version 4.7.2
	echo cma2020# | sudo -S  dotnet add package NLog.Web.AspNetCore --version 4.9.2
	echo cma2020# | sudo -S  dotnet add package NLog.Extensions.Logging --version 1.6.4
	echo cma2020# | sudo -S  dotnet add package NLog.MailKit --version 3.2.0
    echo cma2020# | sudo -S  dotnet add package Microsoft.AspNet.WebApi.Cors --version 5.2.7
    echo cma2020# | sudo -S  dotnet add package Microsoft.AspNetCore.Mvc.NewtonsoftJson --version 3.1.6
    echo cma2020# | sudo -S  dotnet add package Microsoft.AspNetCore.Authentication.JwtBearer --version 3.1.6
    echo cma2020# | sudo -S  dotnet add package Swashbuckle.AspNetCore --version 6.1.1
    echo cma2020# | sudo -S  dotnet add package Swashbuckle.AspNetCore.SwaggerUi --version 6.1.1
	echo cma2020# | sudo -S  dotnet add package RestSharp --version 106.11.7
    echo cma2020# | sudo -S  dotnet add package IdentityServer4.AccessTokenValidation --version 2.7.0
    
fi
echo "Into the build section for WebAPI"
cd "$ROOTDIRECTORY"/MultilingualWebApi
echo cma2020# | sudo -S  dotnet build
echo cma2020# | sudo -S  dotnet publish -o "$ROOTDIRECTORY"/Publish/WebApi
cd "$ROOTDIRECTORY"
                ExistFile="$ROOTDIRECTORY"/Admin/Admin.csproj
                if [ -f "$ExistFile" ]; then
                    echo "Admin Project File is Found"
                else
                    echo cma2020# | sudo -S  dotnet new web -n Admin  --framework netcoreapp3.1 --force
                    echo cma2020# | sudo -S  cp -f   "$ROOTDIRECTORY"/AdminRequisites/*.* "$ROOTDIRECTORY"/Admin/
                    echo cma2020# | sudo -S  cp -r  "$ROOTDIRECTORY"/wwwroot "$ROOTDIRECTORY"/Admin/wwwroot
                    echo cma2020# | sudo -S  dotnet add Admin/Admin.csproj reference Multilingual.Models/Multilingual.Models.csproj
                    
                    
                    cd Admin
                    echo cma2020# | sudo -S  dotnet add package Wdc.System.Net.Http.Formatting.NetStandard --version 1.0.7
                    echo cma2020# | sudo -S  dotnet add package NLog --version 4.7.2
                    echo cma2020# | sudo -S  dotnet add package NLog.Web.AspNetCore --version 4.9.2
                    echo cma2020# | sudo -S  dotnet add package NLog.Extensions.Logging --version 1.6.4
                    echo cma2020# | sudo -S  dotnet add package NLog.MailKit --version 3.2.0
                    echo cma2020# | sudo -S  dotnet add package System.Data.SqlClient --version 4.8.3
                    echo cma2020# | sudo -S  dotnet add package Microsoft.AspNetCore.Mvc.Razor.RuntimeCompilation --version 3.1.6
                    echo cma2020# | sudo -S  dotnet add package Microsoft.AspNetCore.Mvc.NewtonsoftJson --version 3.1.6   
                    echo cma2020# | sudo -S  dotnet add package IdentityServer4.AccessTokenValidation --version 2.7.0
                    echo cma2020# | sudo -S  dotnet add package Microsoft.AspNetCore.Authentication.OpenIdConnect --version 3.1.9

                fi
                cd "$ROOTDIRECTORY"/Admin
                echo cma2020# | sudo -S  dotnet build
                echo cma2020# | sudo -S  dotnet publish -o "$ROOTDIRECTORY"/Publish/Admin
                echo cma2020# | sudo -S  mkdir "$ROOTDIRECTORY"/Publish/Admin/wwwroot/uploads
                echo cma2020# | sudo -S  cp /home/ubuntu/Automaton/AutomatonClient/wwwroot/BackupFiles/Multilingual/AdminUploads/*.* "$ROOTDIRECTORY"/Publish/Admin/wwwroot/uploads

cd "$ROOTDIRECTORY"
                ExistFile="$ROOTDIRECTORY"/Client/Client.csproj
                if [ -f "$ExistFile" ]; then
                    echo "Client Project File is Found"
                else
                    echo cma2020# | sudo -S  dotnet new web -n Client  --framework netcoreapp3.1 --force
                    echo cma2020# | sudo -S  cp -f   "$ROOTDIRECTORY"/ClientRequisites/*.* "$ROOTDIRECTORY"/Client/
                    echo cma2020# | sudo -S  cp -r  "$ROOTDIRECTORY"/wwwroot "$ROOTDIRECTORY"/Client/wwwroot
                    echo cma2020# | sudo -S  dotnet add Client/Client.csproj reference Multilingual.Models/Multilingual.Models.csproj
                    
                    
                    cd Client
                    echo cma2020# | sudo -S  dotnet add package Wdc.System.Net.Http.Formatting.NetStandard --version 1.0.7
                    echo cma2020# | sudo -S  dotnet add package NLog --version 4.7.2
                    echo cma2020# | sudo -S  dotnet add package NLog.Web.AspNetCore --version 4.9.2
                    echo cma2020# | sudo -S  dotnet add package NLog.Extensions.Logging --version 1.6.4
                    echo cma2020# | sudo -S  dotnet add package NLog.MailKit --version 3.2.0
                    echo cma2020# | sudo -S  dotnet add package System.Data.SqlClient --version 4.8.3
                    echo cma2020# | sudo -S  dotnet add package Microsoft.AspNetCore.Mvc.Razor.RuntimeCompilation --version 3.1.6
                    echo cma2020# | sudo -S  dotnet add package Microsoft.AspNetCore.Mvc.NewtonsoftJson --version 3.1.6   
                    echo cma2020# | sudo -S  dotnet add package IdentityServer4.AccessTokenValidation --version 2.7.0
                    echo cma2020# | sudo -S  dotnet add package Microsoft.AspNetCore.Authentication.OpenIdConnect --version 3.1.9

                fi
                cd "$ROOTDIRECTORY"/Client
                echo cma2020# | sudo -S  dotnet build
                echo cma2020# | sudo -S  dotnet publish -o "$ROOTDIRECTORY"/Publish/Client
                echo cma2020# | sudo -S  mkdir "$ROOTDIRECTORY"/Publish/Client/wwwroot/uploads
                echo cma2020# | sudo -S  cp /home/ubuntu/Automaton/AutomatonClient/wwwroot/BackupFiles/Multilingual/AdminUploads/*.* "$ROOTDIRECTORY"/Publish/Client/wwwroot/uploads


echo "Setting up the Publish Evnrionment"
cd /home/ubuntu/Automaton/AutomatonClient/wwwroot/PublishedFiles
echo cma2020# | sudo -S  chown -R ubuntu Multilingual
cd "$ROOTDIRECTORY"
echo cma2020# | sudo -S  rm -f /etc/nginx/sites-enabled/sandbox62
echo cma2020# | sudo -S  rm -f /etc/supervisor/conf.d/Multilingual*.conf                
echo cma2020# | sudo -S  cp "$ROOTDIRECTORY"/PublishRequisites/*.conf /etc/supervisor/conf.d/
echo cma2020# | sudo -S  cp "$ROOTDIRECTORY"/PublishRequisites/sandbox62 /etc/nginx/sites-enabled/
echo cma2020# | sudo -S  supervisorctl reread
echo cma2020# | sudo -S  supervisorctl update
echo cma2020# | sudo -S  supervisorctl restart MultilingualWebApi
echo cma2020# | sudo -S  supervisorctl restart MultilingualClient
echo cma2020# | sudo -S  supervisorctl restart MultilingualAdmin 
echo cma2020# | sudo -S  service nginx reload
curl -v --header "Connection: keep-alive" "http://localhost:5011/ContactUs/sentPublishedNotification?projectid=6b2b6f73-b88b-4b86-847c-25a5d121e2ed"

