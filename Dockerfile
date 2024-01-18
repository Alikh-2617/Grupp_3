FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build-env

WORKDIR /app

ADD ../Grupp_3/bin/Debug/net7.0/ .


CMD [ "dotnet", "application.dll" ]