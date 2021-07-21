#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["UI/CentroClinico.UI.MVC/CentroClinico.UI.MVC.csproj", "UI/CentroClinico.UI.MVC/"]
COPY ["Domain/CentroClinico.Domain/CentroClinico.Domain.csproj", "Domain/CentroClinico.Domain/"]
COPY ["Infra/CentroClinico.Infra.Data/CentroClinico.Infra.Data.csproj", "Infra/CentroClinico.Infra.Data/"]
RUN dotnet restore "UI/CentroClinico.UI.MVC/CentroClinico.UI.MVC.csproj"
COPY . .
WORKDIR "/src/UI/CentroClinico.UI.MVC"
RUN dotnet build "CentroClinico.UI.MVC.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "CentroClinico.UI.MVC.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CentroClinico.UI.MVC.dll"]
