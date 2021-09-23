FROM mcr.microsoft.com/dotnet/sdk:5.0 as build-env
WORKDIR /app

# copy csproject file and restore as distinct layers
COPY *.csproj ./
RUN dotnet restore

# copy everything else and build the project
COPY . ./
RUN dotnet build -c Release -o out

# build the runtime image
FROM mcr.microsoft.com/dotnet/aspnet:5.0
WORKDIR /app
COPY --from=build-env /app/out .
ENTRYPOINT [ "dotnet", "DrinkAPI.dll" ]




