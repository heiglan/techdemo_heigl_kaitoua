# Step 1: Build the application
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["techdemo-heigl-kaitoua.csproj", "./"]
RUN dotnet restore "techdemo-heigl-kaitoua.csproj"
COPY . .
RUN dotnet build "techdemo-heigl-kaitoua.csproj" -c Release -o /app/build

# Step 2: Run tests
FROM build AS test
RUN dotnet test "UnitTests/UnitTests.csproj" --no-build -c Release

# Step 3: Publish the application
FROM build AS publish
RUN dotnet publish "techdemo-heigl-kaitoua.csproj" -c Release -o /app/publish

# Step 4: Run the application
FROM nginx:alpine AS final
WORKDIR /usr/share/nginx/html

# Entfernen Sie die Standard-Nginx-Website
RUN rm -rf ./*
COPY --from=publish /app/publish/wwwroot .
ENTRYPOINT ["nginx", "-g", "daemon off;"]
