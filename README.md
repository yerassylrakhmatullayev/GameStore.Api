# Game Store API

## Starting SQL Server
'''powershell
$sa_password = "[SA PASSWORD HERE]"
docker run -e "ACCEPT_EULA=Y" -e "MSSQL_SA_PASSWORD=$sa_password" -e "MSSQL_PID=Express" -p 1433:1433 -v sqlvolume: -d mcr.microsoft.com/mssql/server:2019-latest
'''
## Setting the connection string to secret manager
'''powershell
$sa_password = "[SA PASSWORD HERE]"
dotnet user-secrets set "ConnectionStrings:GameStoreContext" "Server=localdb; Database=GameStore; User Id=sa; Password=$sa_password; TrustServerCertificate=True"
'''
