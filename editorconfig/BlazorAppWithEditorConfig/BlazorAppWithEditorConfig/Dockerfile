FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["BlazorAppWithEditorConfig/BlazorAppWithEditorConfig.csproj", "BlazorAppWithEditorConfig/"]
RUN dotnet restore "BlazorAppWithEditorConfig/BlazorAppWithEditorConfig.csproj"
COPY . .
WORKDIR "/src/BlazorAppWithEditorConfig"
RUN dotnet build "BlazorAppWithEditorConfig.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "BlazorAppWithEditorConfig.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "BlazorAppWithEditorConfig.dll"]
