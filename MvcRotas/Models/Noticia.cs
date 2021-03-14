using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace MvcRotas.Models
{
    public class Noticia
    {
        public int NoticiaId { get; set; }
        public string Titulo { get; set; }
        public string Conteudo { get; set; }
        public string Categoria { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Data { get; set; }


        public IEnumerable<Noticia> TodasAsNoticias()
        {


            var retorno = new Collection<Noticia>
            {
               new Noticia { NoticiaId=1, Categoria ="Esportes",Titulo="Brasil e paraguai", Conteudo ="Primeiro tempo ficou 1 a 1 ", Data = new DateTime (2014,5,3)},
               new Noticia { NoticiaId=2, Categoria ="Esportes33",Titulo="Brasil3 e paraguai3", Conteudo ="Primeiro tempo ficou 3 a 2 ", Data = new DateTime (2014,6,4)},
               new Noticia { NoticiaId=3, Categoria ="Esportes7",Titulo="Brasil7 e paraguai7", Conteudo ="Primeiro tempo ficou 7 a 7 ", Data = new DateTime (2014,7,7)}
             };
            return retorno;
        }



    }
}

