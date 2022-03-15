FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["HW11/HW11.csproj", "HW11/"]
RUN dotnet restore "HW11/HW11.csproj"
COPY . .
WORKDIR "/src/HW11"
RUN dotnet build "HW11.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "HW11.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "HW11.dll"]
