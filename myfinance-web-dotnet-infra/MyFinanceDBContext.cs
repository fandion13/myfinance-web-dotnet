using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using myfinance_web_dotnet_domain.Entities;

namespace myfinance_web_dotnet_infra;

public class MyFinanceDBContext : DbContext
{
    private readonly IConfiguration _configuration;

    // Camada utilizada para conexão com o DB
    public DbSet<PlanoConta> PlanoConta { get; set; }
    public DbSet<Transacao> Transacao { get; set; }

    public MyFinanceDBContext(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // Para utilizar a connection string do bd que está no appsettings
        var connectionString = _configuration.GetConnectionString("Database");
        optionsBuilder.UseSqlServer(connectionString);

        // Conexão local confiável hard coded
        //optionsBuilder.UseSqlServer(@"Server=FILIPE;Database=myfinance;Trusted_Connection=True;Encrypt=False;TrustServerCertificate=False;");

        // Conexão de db virtual hard coded
        // optionsBuilder.UseSqlServer(@"Server=meuservidorsqlserver.database.windows.net;Database=myfinance;User Id=user;Password=myPassword");
    }
}
