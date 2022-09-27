#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["CLIENT APP/CLIENT APP.csproj", "CLIENT APP/"]
RUN dotnet restore "CLIENT APP/CLIENT APP.csproj"
COPY . .
WORKDIR "/src/CLIENT APP"
RUN dotnet build "CLIENT APP.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "CLIENT APP.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CLIENT APP.dll"]