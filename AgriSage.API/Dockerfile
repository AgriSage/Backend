# Utiliza la imagen base de .NET SDK para construir la aplicación
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /source

# Copia los archivos del proyecto y restaura las dependencias
COPY AgriSage.API/*.csproj .
RUN dotnet restore

# Copia el resto de los archivos y construye la aplicación
COPY AgriSage.API/. .
RUN dotnet publish -c Release -o /app

# Utiliza la imagen base de .NET Runtime para ejecutar la aplicación
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app
COPY --from=build /app .

# Establece la variable de entorno para ASP.NET Core
ENV ASPNETCORE_URLS=http://+:80
ENV ASPNETCORE_ENVIRONMENT=Production

# Exponer el puerto
EXPOSE 80

# Comando para ejecutar la aplicación
ENTRYPOINT ["dotnet", "AgriSage.API.dll"]
