FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["HW213/HW213.csproj", "HW213/"]
RUN dotnet restore "HW213/HW213.csproj"
COPY . .
WORKDIR "/src/HW213"
RUN dotnet build "HW213.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "HW213.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "HW213.dll"]
