FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["HW36/HW36.csproj", "HW36/"]
RUN dotnet restore "HW36/HW36.csproj"
COPY . .
WORKDIR "/src/HW36"
RUN dotnet build "HW36.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "HW36.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "HW36.dll"]
