FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Project2/Project2.csproj", "Project2/"]
RUN dotnet restore "Project2/Project2.csproj"
COPY . .
WORKDIR "/src/Project2"
RUN dotnet build "Project2.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Project2.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Project2.dll"]
