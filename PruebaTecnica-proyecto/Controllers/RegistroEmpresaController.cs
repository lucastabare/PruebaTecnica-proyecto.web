using PruebaTecnica.Proyecto.web.BUSINESS;
using PruebaTecnica_proyecto.Models;
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

        public RegistroEmpresaController()
        {
            model = new modelList();
            bupais = new BUPais();
        }
        public ActionResult RegistroEmpresa()
        {
            string token = "";

            model.listPais = bupais.ListaPaises(token);
            return View(model);
        }
    }
}
