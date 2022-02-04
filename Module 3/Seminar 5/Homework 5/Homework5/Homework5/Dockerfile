FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Homework5/Homework5.csproj", "Homework5/"]
RUN dotnet restore "Homework5/Homework5.csproj"
COPY . .
WORKDIR "/src/Homework5"
RUN dotnet build "Homework5.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Homework5.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Homework5.dll"]
