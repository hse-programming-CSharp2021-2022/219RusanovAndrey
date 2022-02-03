FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Task6_4/Task6_4.csproj", "Task6_4/"]
RUN dotnet restore "Task6_4/Task6_4.csproj"
COPY . .
WORKDIR "/src/Task6_4"
RUN dotnet build "Task6_4.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Task6_4.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Task6_4.dll"]
