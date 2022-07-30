using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Лабораторная_13.Models
{
    public class ПортфолиоModel
    { 
        public IEnumerable<Портфолио> Портфолио { get; set; }
        [Key]
        public SelectList Дата { get; set; }
        public SelectList Вид { get; set; }
    }
}