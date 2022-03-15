FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["HW312/HW312.csproj", "HW312/"]
RUN dotnet restore "HW312/HW312.csproj"
COPY . .
WORKDIR "/src/HW312"
RUN dotnet build "HW312.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "HW312.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "HW312.dll"]
