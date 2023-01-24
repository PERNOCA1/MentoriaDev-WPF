using MentoriaDevSti3.Data.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MentoriaDevSti3.Data.Context
{
    public class MentoriaDevSTI3Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;port=3306;user=root;password=Cjkl4268;database=mentoria_dev;")
                .EnableSensitiveDataLogging()
                .EnableDetailedErrors()
                .LogTo(x => Debug.WriteLine(x));

            base.OnConfiguring(optionsBuilder);
        }

        public virtual DbSet<Cliente> Clientes { get; set; }

        public virtual DbSet<ItemPedido> ItensPedidos { get; set; }
        public virtual DbSet<Pedido> Pedidos { get; set; }
        public virtual DbSet<Produto> Produtos { get; set; }
    }
}
