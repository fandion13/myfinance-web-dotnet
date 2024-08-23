using Microsoft.EntityFrameworkCore;
using myfinance_web_dotnet_domain.Entities;

namespace myfinance_web_dotnet_infra;

public class MyFinanceDBContext : DbContext
{
    // Camada utilizada para conexão com o DB
    public DbSet<PlanoConta> PlanoConta { get; set; }
    public DbSet<Transacao> Transacao { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
       optionsBuilder.UseSqlServer(@"Server=FILIPE;Database=myfinance;Trusted_Connection=True;Encrypt=False;TrustServerCertificate=False;");
    }
}
