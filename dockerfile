FROM mcr.microsoft.com/dotnet/aspnet:10.0

WORKDIR /app

COPY ./bin/Release/net10.0/publish .

EXPOSE 80

ENV ASPNETCORE_URLS=http://+:80

ENTRYPOINT ["dotnet", "LoadBalancerTest.dll"]