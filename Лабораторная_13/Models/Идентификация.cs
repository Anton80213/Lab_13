using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Лабораторная_13.Models
{
    public class Идентификация
    {
        [Key]
        public string Логин { get; set; }
        public string Пароль { get; set; }
    }
}