FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["HW315/HW315.csproj", "HW315/"]
RUN dotnet restore "HW315/HW315.csproj"
COPY . .
WORKDIR "/src/HW315"
RUN dotnet build "HW315.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "HW315.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "HW315.dll"]
