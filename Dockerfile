# Use the .NET 6 SDK image
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /source

# Copy NuGet configuration
COPY NuGet.Config ./

# Copy and restore dependencies
COPY *.csproj ./
RUN dotnet restore

# Copy the rest of the application code
COPY . ./
RUN dotnet build --no-restore -c Release

# Publish the application
RUN dotnet publish --no-restore -c Release -o /app

# Use a runtime image
FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS runtime
WORKDIR /app
COPY --from=build /app .
EXPOSE 80
ENTRYPOINT ["dotnet", "CatGeneticsBackend3.dll"]
