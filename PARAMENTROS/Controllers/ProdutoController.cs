using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PARAMENTROS.Controllers
{
    public class ProdutoController : Controller
    {
        // GET: Produto
        public ActionResult Buscar(int prd)
        {
            string retorno = string.Empty;
            string linkretorno = string.Empty;
            switch(prd)
            {
                case 1:
                retorno = "Globo.com";
                    linkretorno = "https://www.globo.com/";
                    break;
                case 2:
                    retorno = "R7.com";
                    linkretorno = "https://www.r7.com/";
                    break;

                case 5:
                    retorno = "iphone";
                    break;
                default:
                    retorno = "Nokia";
                    break;
            }

            ViewBag.Produto = retorno;
            ViewBag.Link = linkretorno;
            return View();
        }
    }
}