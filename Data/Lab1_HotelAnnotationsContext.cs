#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Lab1_HotelAnnotations.Models;

namespace Lab1_HotelAnnotations.Data
{
    public class Lab1_HotelAnnotationsContext : DbContext
    {
        public Lab1_HotelAnnotationsContext (DbContextOptions<Lab1_HotelAnnotationsContext> options)
            : base(options)
        {
        }

        public DbSet<Lab1_HotelAnnotations.Models.Client> Client { get; set; }
        public DbSet<Lab1_HotelAnnotations.Models.Room> Room { get; set; }
    }
}
