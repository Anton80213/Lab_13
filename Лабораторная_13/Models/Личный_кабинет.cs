using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Лабораторная_13.Models
{
    public class Личный_кабинет: DbContext
    {
        public DbSet<Идентификация> Идентификации { get; set; }
        public DbSet<Успеваемость> Успеваемости { get; set; }
        public DbSet<Портфолио> Портфолио { get; set; }
        public DbSet<Преподаватель> Преподаватели { get; set; }
        public DbSet<ПортфолиоModel> ПортфолиоModels { get; set; }
    }
}