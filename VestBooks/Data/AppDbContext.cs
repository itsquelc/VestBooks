using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using VestBooks.Models;


namespace VestBooks.Data;

    public class AppDbContext  : IdentityDbContext<Usuario>
     {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Faculdade> Categorias { get; set; }
        public DbSet<Livro> Livros { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
    
        AppDbSeed seed = new (builder);
        
        #region  Renomear Tabelas do Identity
        builder.Entity<IdentityUser>().ToTable("usuario");
        builder.Entity<IdentityUserRole<string>>().ToTable("usuario_perfil");
        builder.Entity<IdentityUserLogin<string>>().ToTable("usuario_login");
        builder.Entity<IdentityUserClaim<string>>().ToTable("usuario_regra");
        builder.Entity<IdentityUserToken<string>>().ToTable("usuario_token");
        builder.Entity<IdentityRole>().ToTable("perfil");
        builder.Entity<IdentityRoleClaim<string>>().ToTable("perfil_regra");
        #endregion
    }

}