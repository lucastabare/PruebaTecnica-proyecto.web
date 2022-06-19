using PruebaTecnica.proyecto.Models;
using PruebaTecnica.proyecto.web.BUSINESS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PruebaTecnica_proyecto.Controllers
{
    public class RegistroEmpresaController : Controller
    {
        private modelList model;
        
        private BUPais bupais;

        public ActionResult RegistroEmpresa()
        {
            return View();
        }
    }
}
