FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Task3_1/Task3_1.csproj", "Task3_1/"]
RUN dotnet restore "Task3_1/Task3_1.csproj"
COPY . .
WORKDIR "/src/Task3_1"
RUN dotnet build "Task3_1.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Task3_1.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Task3_1.dll"]
