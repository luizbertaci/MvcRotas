using MvcRotas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcRotas.Controllers
{
    public class HomeController : Controller
    {

        private readonly IEnumerable<Noticia> todasAsNoticias;


        public HomeController()
        {
            todasAsNoticias = new Noticia().TodasAsNoticias().OrderByDescending(x => x.Data);

        }

        public ActionResult Index()
        {
            var ultimaNoticia = todasAsNoticias.Take(3);
            var todasAsCategorias = todasAsNoticias.Select(x => x.Categoria).Distinct().ToList();
            ViewBag.Categorias = todasAsCategorias;

            return View(ultimaNoticia);
        }

        public ActionResult TodasAsNoticias()
        {
            return View(todasAsNoticias);
        }

        public ActionResult MostraNoticia(int noticiaId, string titulo, string categoria)
        {
            return View(todasAsNoticias.FirstOrDefault(x => x.NoticiaId == noticiaId));
        }

        public ActionResult MostraCategoria(string categoria)
        {
            var categoriaEspecifica = todasAsNoticias.Where(x => x.Categoria.ToLower() == categoria.ToLower()).ToList();
            ViewBag.Categoria = categoria;
            return View(categoriaEspecifica);
        }

    }
}
