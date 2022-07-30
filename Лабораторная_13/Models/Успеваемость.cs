using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Лабораторная_13.Models
{
    public class Успеваемость
    {
        [Key]
        public int Семестр { get; set; }
        public string Название_дисциплины { get; set; }
        public int Оценка { get; set; }
    }
}