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



## 1. A�ama: Yap� a�amas�
## .NET Core SDK g�r�nt�s�n� kullanarak derleme yap�yoruz.
#FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
#
## �al��ma klas�r�n� ayarl�yoruz.
#WORKDIR /app
#
## Proje dosyalar�n� kopyal�yoruz.
#COPY *.csproj ./
#RUN dotnet restore
#
## T�m kaynak kodlar�n� kopyal�yoruz.
#COPY . ./
#
## Uygulamay� yay�n (publish) modunda derliyoruz.
#RUN dotnet publish -c Release -o out
#
## 2. A�ama: �al��t�rma a�amas�
## .NET Core runtime g�r�nt�s�n� kullanarak uygulamay� �al��t�r�yoruz.
#FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
#
## �al��ma klas�r�n� ayarl�yoruz.
#WORKDIR /app
#
## Yay�nlanm�� dosyalar� kopyal�yoruz.
#COPY --from=build /app/out ./
#
## Uygulamay� �al��t�racak komutu tan�ml�yoruz.
#ENTRYPOINT ["dotnet", "SeninProjeAdi.dll"]
