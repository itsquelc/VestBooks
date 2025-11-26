using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using VestBooks.Models;


namespace VestBooks.Data;

public class AppDbContext : IdentityDbContext<Usuario>
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Faculdade> Faculdades { get; set; }
    public DbSet<Pergunta> Perguntas { get; set; }
    public DbSet<PerguntaAlternativa> PerguntaAlternativas { get; set; }
    public DbSet<FaculdadeLivro> FaculdadeLivros { get; set; }
    public DbSet<Autor> Autores { get; set; }
    public DbSet<Livro> Livros { get; set; }
    public DbSet<Usuario> Usuarios { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        AppDbSeed seed = new(builder);

        #region  Renomear Tabelas do Identity
        builder.Entity<IdentityUser>().ToTable("usuario");
        builder.Entity<IdentityUserRole<string>>().ToTable("usuario_perfil");
        builder.Entity<IdentityUserLogin<string>>().ToTable("usuario_login");
        builder.Entity<IdentityUserClaim<string>>().ToTable("usuario_regra");
        builder.Entity<IdentityUserToken<string>>().ToTable("usuario_token");
        builder.Entity<IdentityRole>().ToTable("perfil");
        builder.Entity<IdentityRoleClaim<string>>().ToTable("perfil_regra");
        #endregion

        // Configurar a chave composta para FaculdadeLivro (opcional, dependendo do seu caso)
        // Configurar a tabela FaculdadeLivro
        builder.Entity<FaculdadeLivro>(entity =>
        {
            // Relação com Faculdade
            entity.HasOne(fl => fl.Faculdade)
                  .WithMany(f => f.Livros)
                  .HasForeignKey(fl => fl.FaculdadeId)
                  .OnDelete(DeleteBehavior.Cascade);

            // Relação com Livro
            entity.HasOne(fl => fl.Livro)
                  .WithMany(l => l.Faculdades)
                  .HasForeignKey(fl => fl.LivroId)
                  .OnDelete(DeleteBehavior.Cascade);
        });

        // Configurar a tabela Livro
        builder.Entity<Livro>(entity =>
        {
            entity.ToTable("livro");

            entity.HasKey(l => l.LivroId);

            // Relação com Autor
            entity.HasOne(l => l.Autor)
                  .WithMany(a => a.Livros)
                  .HasForeignKey(l => l.AutorId)
                  .OnDelete(DeleteBehavior.Restrict);

            // Relação com Faculdades (via FaculdadeLivro)
            entity.HasMany(l => l.Faculdades)
                  .WithOne(fl => fl.Livro)
                  .HasForeignKey(fl => fl.LivroId);
        });

    }

}