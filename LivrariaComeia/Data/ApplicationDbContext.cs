using LivrariaComeia.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace LivrariaComeia.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            Database.Migrate();
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Categoria>().HasMany(categoria => categoria.Livros).WithOne(livros => livros.Categoria);
            builder.Entity<Livro>().HasOne(livro => livro.Categoria).WithMany(categoria => categoria.Livros);
        }

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Livro> Livros { get; set; }

    }
}
