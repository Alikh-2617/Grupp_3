# Byggsteg
FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build-env
WORKDIR /app
ADD ../Grupp_3/bin/Debug/net7.0/ .
RUN dotnet restore
RUN dotnet publish -c Release -o out

# Publiceringssteg
FROM mcr.microsoft.com/dotnet/aspnet:7.0
WORKDIR /app
COPY --from=build-env /app/out .
CMD ["dotnet", "application.dll"]
