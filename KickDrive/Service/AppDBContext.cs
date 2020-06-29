using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Models;

namespace Service
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {
        }
        public DbSet<Vehiculo> Vehiculos { get; set; }
        public DbSet<Conductor> Conductors { get; set; }
        public DbSet<Supervisor> Supervisors { get; set; }
        public DbSet<ProcesoRevision> ProcesoRevisions { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
