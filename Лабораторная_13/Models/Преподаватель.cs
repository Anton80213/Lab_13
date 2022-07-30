using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Лабораторная_13.Models
{
    public class Преподаватель
    {
        [Key]
        public string ФИО_преподавателя { get; set; }
        public string Название_дисциплины { get; set; }
        public string Название_кафедры { get; set; }
    }
}