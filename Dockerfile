FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-bionic  AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-bionic  AS build
WORKDIR /src
COPY ["Softplan.CalculaJuros.Api/Softplan.CalculaJuros.Api.csproj", "Softplan.CalculaJuros.Api/"]
COPY ["Softplan.CalculaJuros.AppServices/Softplan.CalculaJuros.AppServices.csproj", "Softplan.CalculaJuros.AppServices/"]
COPY ["Softplan.CalculaJuros.CrossCutting/Softplan.CalculaJuros.CrossCutting.csproj", "Softplan.CalculaJuros.CrossCutting/"]
COPY ["Softplan.CalculaJuros.Domain/Softplan.CalculaJuros.Domain.csproj", "Softplan.CalculaJuros.Domain/"]
COPY ["Softplan.CalculaJuros.Services/Softplan.CalculaJuros.Services.csproj", "Softplan.CalculaJuros.Services/"]
COPY ["Softplan.CalculaJuros.Tests/Softplan.CalculaJuros.Tests.csproj", "Softplan.CalculaJuros.Tests/"]
COPY ["Softplan.CalculaJuros.Utils/Softplan.CalculaJuros.Utils.csproj", "Softplan.CalculaJuros.Utils/"]
RUN dotnet restore "Softplan.CalculaJuros.Api/Softplan.CalculaJuros.Api.csproj"
COPY . .
WORKDIR "/src/Softplan.CalculaJuros.Api"
RUN dotnet build "Softplan.CalculaJuros.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Softplan.CalculaJuros.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Softplan.CalculaJuros.Api.dll"]