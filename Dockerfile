FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["OrchardSite/OrchardSite.csproj", "OrchardSite/"]
RUN dotnet restore "OrchardSite/OrchardSite.csproj"
COPY . .
WORKDIR "/src/OrchardSite"
RUN dotnet build "OrchardSite.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "OrchardSite.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "OrchardSite.dll"]