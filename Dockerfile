FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["TranslationClient/TranslationClient.csproj", "TranslationClient/"]
RUN dotnet restore "TranslationClient/TranslationClient.csproj"
COPY . .
WORKDIR "/src/TranslationClient"
RUN dotnet build "TranslationClient.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "TranslationClient.csproj" -c Release -o /app/publish

FROM nginx:alpine AS final
WORKDIR /usr/share/nginx/html
COPY --from=publish /app/publish/wwwroot .
COPY nginx.conf /etc/nginx/nginx.conf