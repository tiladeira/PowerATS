FROM mcr.microsoft.com/dotnet/aspnet:8.0-nanoserver-1809 AS base
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0-nanoserver-1809 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["PowerATS.API/PowerATS.API.csproj", "PowerATS.API/"]
COPY ["PowerATS.Infra.Data/PowerATS.Infra.Data.csproj", "PowerATS.Infra.Data/"]
COPY ["PowerATS.Domain/PowerATS.Domain.csproj", "PowerATS.Domain/"]
COPY ["PowerATS.Infra.IoC/PowerATS.Infra.IoC.csproj", "PowerATS.Infra.IoC/"]
RUN dotnet restore "./PowerATS.API/./PowerATS.API.csproj"
COPY . .
WORKDIR "/src/PowerATS.API"
RUN dotnet build "./PowerATS.API.csproj" -c %BUILD_CONFIGURATION% -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./PowerATS.API.csproj" -c %BUILD_CONFIGURATION% -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "PowerATS.API.dll"]