using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Лабораторная_13.Models;

namespace Лабораторная_13.Controllers
{
    public class HomeController : Controller
    {
        Личный_кабинет db = new Личный_кабинет();

        public string Home()
        {
            var d = (from x in db.Успеваемости select new { a = x.Семестр, b = x.Название_дисциплины, c = x.Оценка }).ToList();
            return JsonConvert.SerializeObject(d);
        }
        public string Home2()
        {
            var e = (from x in db.Портфолио select new { a = x.Дата, b = x.Вид, c = x.Описание }).ToList();
            return JsonConvert.SerializeObject(e);
        }
        public string Home3()
        {
            var f = (from x in db.Преподаватели select new { a = x.ФИО_преподавателя, b = x.Название_дисциплины, c = x.Название_кафедры }).ToList();
            return JsonConvert.SerializeObject(f);
        }

        public ActionResult Index()
        {
            Идентификация model = new Идентификация();
            return View(model);
        }

        public ActionResult Успеваемость()
        {
            return View();
        }
        public ActionResult Портфолио()
        {
            return View();
        }
        public ActionResult Преподаватели()
        {
            return View();
        }
        [HttpGet]
        public ActionResult ПортфолиоФильтр(string date, string kind)
        {
            IQueryable<Портфолио> портфолио = db.Портфолио;
            if (!String.IsNullOrEmpty(date))
            {
                портфолио = портфолио.Where(p => p.Дата == date);
            }
            if (!String.IsNullOrEmpty(kind) && !kind.Equals("Все"))
            {
                портфолио = портфолио.Where(p => p.Вид == kind);
            }
            
            // устанавливаем начальный элемент, который позволит выбрать всех
            портфолио.ToList().Insert(0, new Портфолио { Вид = "Все", Дата = ""});

            ПортфолиоModel plvm = new ПортфолиоModel
            {
                Портфолио = портфолио.ToList(),
                Дата = new SelectList(date),
                Вид = new SelectList(kind)
            };
            return View(plvm);
        }
    }
}