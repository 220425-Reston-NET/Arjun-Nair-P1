from mcr.microsoft.com/dotnet/sdk:6.0 as build

workdir /app

copy *.sln ./
copy StoreApi/*.csproj StoreApi/
copy StoreBL/*.csproj StoreBL/
copy StoreDL/*.csproj StoreDL/
copy StoreModel/*.csproj StoreModel/
copy StoreTest/*.csproj StoreTest/

copy . ./

run dotnet build

run dotnet publish -c Release -o publish

# Then commment out everything above and run the below

from mcr.microsoft.com/dotnet/aspnet:6.0 as runtime

workdir /app
copy --from=build /app/publish ./

cmd ["dotnet", "StoreApi.dll"]

expose 80
# Change 80 to 5000

# Look below

# from mcr.microsoft.com/dotnet/aspnet:6.0 as runtime

# workdir /app

# entrypoint ["dotnet", "StoreApi.dll"]

# expose 5000

# env ASPNETCORE_URLS=https://+:5000
# Run this in console
# docker build -t [YourName]/[Your App Name]:[Current version] .

# Run this in console
# docker run -d -p 5000:80 -t [PUT Image name here]



