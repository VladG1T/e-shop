FROM microsoft/dotnet:2.1-aspnetcore-runtime-nanoserver-sac2016

WORKDIR /app

COPY . .

CMD ASPNETCORE_URLS=http://*:$PORT dotnet EShop.dll