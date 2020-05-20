FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS dotnet-build-env
WORKDIR /src
COPY . .
RUN dotnet restore "MultimediaConverter/MultimediaConverter.Docker.csproj"
WORKDIR "/src/MultimediaConverter"
RUN dotnet publish -c Release -o /app/build


FROM mcr.microsoft.com/dotnet/core/aspnet:3.1 as run-env
WORKDIR /App
COPY --from=dotnet-build-env /app/build .
ENTRYPOINT ["dotnet", "MultimediaConverter.Docker.dll"]