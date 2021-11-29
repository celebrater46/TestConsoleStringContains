FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["TestConsoleStringContains/TestConsoleStringContains.csproj", "TestConsoleStringContains/"]
RUN dotnet restore "TestConsoleStringContains/TestConsoleStringContains.csproj"
COPY . .
WORKDIR "/src/TestConsoleStringContains"
RUN dotnet build "TestConsoleStringContains.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "TestConsoleStringContains.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "TestConsoleStringContains.dll"]
