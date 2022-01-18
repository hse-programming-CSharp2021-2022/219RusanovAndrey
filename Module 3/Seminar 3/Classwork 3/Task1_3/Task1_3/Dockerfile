FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Task1_3/Task1_3.csproj", "Task1_3/"]
RUN dotnet restore "Task1_3/Task1_3.csproj"
COPY . .
WORKDIR "/src/Task1_3"
RUN dotnet build "Task1_3.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Task1_3.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Task1_3.dll"]
