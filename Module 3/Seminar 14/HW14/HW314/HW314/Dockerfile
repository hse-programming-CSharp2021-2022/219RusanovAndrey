FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["HW314/HW314.csproj", "HW314/"]
RUN dotnet restore "HW314/HW314.csproj"
COPY . .
WORKDIR "/src/HW314"
RUN dotnet build "HW314.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "HW314.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "HW314.dll"]
