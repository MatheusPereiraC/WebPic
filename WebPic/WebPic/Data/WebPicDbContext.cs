using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebPic.Models;

namespace WebPic.Data
{
    public class WebPicDbContext : DbContext
    {
        public WebPicDbContext (DbContextOptions<WebPicDbContext> options)
            : base(options)
        {
        }

        public DbSet<Usuario> Usuarios { get; set; }
    }
}
