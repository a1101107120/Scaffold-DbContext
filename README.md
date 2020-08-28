Scaffold-DbContext

MSSQL匯出使用套件: 

1.Microsoft.EntityFrameworkCore.Design

2.Microsoft.EntityFrameworkCore.SqlServer

3.Microsoft.EntityFrameworkCore.Tools

指令(Ex):

Scaffold-DbContext "Server=localhost;Database=NICKTEST;User Id=sa;Password=xxxxx" Microsoft.EntityFrameworkCore.SqlServer -OutputDir PostgreSqlModels -Context DBContext 

-------------------------

PostgreSQL匯出使用套件:

1.Npgsql

2.Npgsql.EntityFrameworkCore.PostgreSQL

3.Npgsql.EntityFrameworkCore.PostgreSQL.Design

指令(Ex):

Scaffold-DbContext "Host=localhost; Port=5432 ;Database=NICKTEST;Username=postgres;Password=xxxxx" Npgsql.EntityFrameworkCore.PostgreSQL -OutputDir PostgreSqlModels -Context DBContext -force
