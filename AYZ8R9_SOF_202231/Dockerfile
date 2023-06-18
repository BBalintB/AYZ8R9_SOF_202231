#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["AYZ8R9_SOF_202231/AYZ8R9_SOF_202231.csproj", "AYZ8R9_SOF_202231/"]
COPY ["AYZ8R9_SOF_202231.Model/AYZ8R9_SOF_202231.Model.csproj", "AYZ8R9_SOF_202231.Model/"]
RUN dotnet restore "AYZ8R9_SOF_202231/AYZ8R9_SOF_202231.csproj"
COPY . .
WORKDIR "/src/AYZ8R9_SOF_202231"
RUN dotnet build "AYZ8R9_SOF_202231.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "AYZ8R9_SOF_202231.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "AYZ8R9_SOF_202231.dll"]