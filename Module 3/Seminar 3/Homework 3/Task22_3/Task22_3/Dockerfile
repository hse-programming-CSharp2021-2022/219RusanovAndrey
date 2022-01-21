FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Task22_3/Task22_3.csproj", "Task22_3/"]
RUN dotnet restore "Task22_3/Task22_3.csproj"
COPY . .
WORKDIR "/src/Task22_3"
RUN dotnet build "Task22_3.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Task22_3.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Task22_3.dll"]
