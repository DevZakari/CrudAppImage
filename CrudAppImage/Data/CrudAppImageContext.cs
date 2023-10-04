using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CrudAppImage.Model;

namespace CrudAppImage.Data
{
    public class CrudAppImageContext : DbContext
    {
        public CrudAppImageContext (DbContextOptions<CrudAppImageContext> options)
            : base(options)
        {
        }

        public DbSet<CrudAppImage.Model.Etudiant> Etudiant { get; set; }
    }
}
