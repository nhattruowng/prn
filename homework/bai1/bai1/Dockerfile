FROM mcr.microsoft.com/dotnet/runtime:8.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["bai1/bai1.csproj", "bai1/"]
RUN dotnet restore "bai1/bai1.csproj"
COPY . .
WORKDIR "/src/bai1"
RUN dotnet build "bai1.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "bai1.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "bai1.dll"]
