FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["XmlTransformation.Console/XmlTransformation.Console.csproj", "XmlTransformation.Console/"]
RUN dotnet restore "XmlTransformation.Console/XmlTransformation.Console.csproj"
COPY . .
WORKDIR "/src/XmlTransformation.Console"
RUN dotnet build "XmlTransformation.Console.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "XmlTransformation.Console.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "XmlTransformation.Console.dll"]
