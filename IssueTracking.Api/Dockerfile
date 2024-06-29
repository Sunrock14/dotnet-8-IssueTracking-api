#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["IssueTracking.Api/IssueTracking.Api.csproj", "IssueTracking.Api/"]
RUN dotnet restore "./IssueTracking.Api/IssueTracking.Api.csproj"
COPY . .
WORKDIR "/src/IssueTracking.Api"
RUN dotnet build "./IssueTracking.Api.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./IssueTracking.Api.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "IssueTracking.Api.dll"]



## 1. Aþama: Yapý aþamasý
## .NET Core SDK görüntüsünü kullanarak derleme yapýyoruz.
#FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
#
## Çalýþma klasörünü ayarlýyoruz.
#WORKDIR /app
#
## Proje dosyalarýný kopyalýyoruz.
#COPY *.csproj ./
#RUN dotnet restore
#
## Tüm kaynak kodlarýný kopyalýyoruz.
#COPY . ./
#
## Uygulamayý yayýn (publish) modunda derliyoruz.
#RUN dotnet publish -c Release -o out
#
## 2. Aþama: Çalýþtýrma aþamasý
## .NET Core runtime görüntüsünü kullanarak uygulamayý çalýþtýrýyoruz.
#FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
#
## Çalýþma klasörünü ayarlýyoruz.
#WORKDIR /app
#
## Yayýnlanmýþ dosyalarý kopyalýyoruz.
#COPY --from=build /app/out ./
#
## Uygulamayý çalýþtýracak komutu tanýmlýyoruz.
#ENTRYPOINT ["dotnet", "SeninProjeAdi.dll"]
