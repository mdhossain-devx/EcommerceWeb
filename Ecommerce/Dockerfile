# See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

# ──────────────────────────────
# Base image for runtime
# ──────────────────────────────
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

# ──────────────────────────────
# Build stage
# ──────────────────────────────
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src

# Copy only necessary project files
COPY ["EcommerceWeb/EcommerceWeb.csproj", "EcommerceWeb/"]
COPY ["Ecommerce.DataAccess/Ecommerce.DataAccess.csproj", "Ecommerce.DataAccess/"]
COPY ["Ecommerce.Models/Ecommerce.Models.csproj", "Ecommerce.Models/"]
COPY ["Ecommerce.Utility/Ecommerce.Utility.csproj", "Ecommerce.Utility/"]

# Restore dependencies
RUN dotnet restore "EcommerceWeb/EcommerceWeb.csproj"

# Copy source files explicitly (not `COPY . .`)
COPY EcommerceWeb/ EcommerceWeb/
COPY Ecommerce.DataAccess/ Ecommerce.DataAccess/
COPY Ecommerce.Models/ Ecommerce.Models/
COPY Ecommerce.Utility/ Ecommerce.Utility/

WORKDIR "/src/EcommerceWeb"
RUN dotnet build "EcommerceWeb.csproj" -c $BUILD_CONFIGURATION -o /app/build

# ──────────────────────────────
# Publish stage
# ──────────────────────────────
FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "EcommerceWeb.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

# ──────────────────────────────
# Final runtime image (non-root user)
# ──────────────────────────────
FROM base AS final
WORKDIR /app

# Create and switch to a non-root user
RUN adduser --disabled-password --gecos '' appuser && chown -R appuser /app
USER appuser

# Copy published output and SQLite DB
COPY --from=publish /app/publish .
COPY EcommerceWeb/app.db ./app.db

ENTRYPOINT ["dotnet", "EcommerceWeb.dll"]
