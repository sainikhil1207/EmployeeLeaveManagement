FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build

WORKDIR /src

COPY . .

RUN dotnet restore EmployeeLeaveManagement.csproj

RUN dotnet publish EmployeeLeaveManagement.csproj -c Release -o /app/publish

FROM mcr.microsoft.com/dotnet/aspnet:10.0

WORKDIR /app

COPY --from=build /app/publish .

EXPOSE 5136

ENV ASPNETCORE_URLS=http://+:5136

ENTRYPOINT ["dotnet", "EmployeeLeaveManagement.dll"]