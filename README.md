# dotnet-api-envoy

…or create a new repository on the command line

echo "# dotnet-api-envoy" >> README.md

git init

git add README.md

git commit -m "first commit"

git branch -M main

git remote add origin https://github.com/danhdeng/dotnet-api-envoy.git

git push -u origin main

…or push an existing repository from the command line

git remote add origin https://github.com/danhdeng/dotnet-api-envoy.git

git branch -M main

git push -u origin main

# use powershelll to create https cert

dotnet dev-certs https -ep $env:USERPROFILE\.aspnet\https\FoodAPI.pfx -p P@55w0rd
dotnet dev-certs https --trust

dotnet dev-certs https -ep $env:USERPROFILE\.aspnet\https\DrinkAPI.pfx -p P@55w0rd
dotnet dev-certs https --trust

# set user-secrets for each web api

dotnet user-secrets set "Kestrel:Certificates:Development:Password" "P@55w0rd"

# check the user-secrets in the local folder

C:\Users\Dan\AppData\Roaming\Microsoft\UserSecrets

# envoy proxy reference

https://www.envoyproxy.io/

# build envoygateway image
docker build -t envoygateway .

# create the docker container with envoygateway image

docker run -p 9901:9901  -p 10000:1000 danhuideng/envoygateway