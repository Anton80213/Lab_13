using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Лабораторная_13.Models
{
    public class Портфолио
    {
        [Key]
        public string Дата { get; set; }
        public string Вид { get; set; }
        public string Описание { get; set; }
    }
}