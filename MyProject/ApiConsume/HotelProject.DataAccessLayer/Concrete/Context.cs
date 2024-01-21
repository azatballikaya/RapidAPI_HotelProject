﻿using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAccessLayer.Concrete
{
    public class Context:IdentityDbContext<AppUser,AppRole,int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-NOPPPVL\\SQLEXPRESS;Database=ApiDb;Trusted_Connection=True;TrustServerCertificate=true;");
        }
        DbSet<Room> Rooms { get; set; }
        DbSet<Service> Services { get; set; }
        DbSet<Staff> Staffs { get; set; }
        DbSet<Subscribe> Subscribes { get; set; }
        DbSet<Testimonial> Testimonials { get; set; }
        DbSet<About> AboutUs { get; set; }
       
    }
}
