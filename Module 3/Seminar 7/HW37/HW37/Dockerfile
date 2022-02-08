FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["HW37/HW37.csproj", "HW37/"]
RUN dotnet restore "HW37/HW37.csproj"
COPY . .
WORKDIR "/src/HW37"
RUN dotnet build "HW37.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "HW37.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "HW37.dll"]
