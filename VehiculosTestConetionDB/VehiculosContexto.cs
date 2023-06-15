using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehiculosTestConetionDB.Models;

namespace VehiculosTestConetionDB
{
    public class VehiculosContexto : DbContext
    {
        //Con cada DbSet creamos una tabla y nos aseguramos que cada objeto coche resida en una fila
        public DbSet<Coche> Coches { get; set; }
        public DbSet<Avion> Aviones { get; set; }
        public DbSet<Yate> Yates { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=FORMACIO1\SQLEXPRESS03;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False; Database=VehiculosDB");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

         
        }

        //Comandos para inicializar la Migracion una vez se ha creado o modificado las clases y por lo tanto
        //Se habran modificado las tablas: Comando:::
        //EntityFrameworkCore\Add-Migration (Migration'sName)
        //Después de esto el comando para actualizar la Database es:
        //EntityFrameworkCore\Update-DataBase
    }
}
