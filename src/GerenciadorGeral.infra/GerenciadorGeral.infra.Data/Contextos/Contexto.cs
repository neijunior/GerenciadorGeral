using GerenciadorGeral.domain.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

namespace GerenciadorGeral.infra.Data.Contextos
{
  public class Contexto : DbContext
  {
    public DbSet<Fornecedor> Fornecedor { get; set; }
    public DbSet<Marca> Marca { get; set; }
    public DbSet<Menu> Menu { get; set; }
    public DbSet<SKU> SKU { get; set; }
    public DbSet<UnidadeMedida> UnidadeMedida { get; set; }
    
    //public DbSet<Compra> Compra { get; set; }
    
    public IDbContextTransaction Transaction { get; private set; }
    public Contexto(DbContextOptions<Contexto> options) : base(options)
    {
      if (Database.GetPendingMigrations().Count() > 0)
        Database.Migrate();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {

    }

    public IDbContextTransaction InitTransaction()
    {
      if (Transaction == null) Transaction = this.Database.BeginTransaction();
      return Transaction;
    }

    private void RollBack()
    {
      if (Transaction != null) Transaction.Rollback();
    }

    private void Save()
    {
      try
      {
        ChangeTracker.DetectChanges();
        SaveChanges();
      }
      catch (Exception ex)
      {
        RollBack();
        throw new Exception(ex.Message);
      }
    }

    private void Commit()
    {
      if (Transaction != null)
      {
        Transaction.Commit();
        Transaction.Dispose();
        Transaction = null;
      }
    }

    public void SendChanges()
    {
      Save();
      Commit();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      base.OnModelCreating(modelBuilder);
      modelBuilder.HasDefaultSchema("dbo");
      foreach (var property in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetProperties().Where(p => new[] { typeof(string), typeof(decimal) }.Contains(p.ClrType))))
      {
        if (property.ClrType == typeof(string))
          property.SetColumnType("varchar(200)");
        else if (property.ClrType == typeof(decimal))
          property.SetColumnType("decimal(16,2)");

        //switch (property.ClrType)
        //{
        //  case  typeof(string):

        //    break;
        //  case typeof(decimal):

        //    break;
        //  default:
        //    break;
        //}
      }

      modelBuilder.ApplyConfigurationsFromAssembly(typeof(Contexto).Assembly);

      modelBuilder.PopularTabela();
    }
  }
}
