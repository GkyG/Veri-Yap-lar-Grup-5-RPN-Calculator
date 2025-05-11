FROM mcr.microsoft.com/dotnet/runtime:6.0-windowsservercore-ltsc2022
WORKDIR /app
COPY ./bin/Release/net9.0-windows/ ./
CMD ["RPN CALCULATOR Grup 5.exe"]