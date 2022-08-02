using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GestorCliente.Models;
using GestorCliente.Models.ViewModels;
namespace GestorCliente.Controllers
{
    public class GestorClienteController : Controller
    {
        // GET: GestorCliente
        public ActionResult Index()
        {
            List<GestorClienteVM> lst;
            using (DBGestorClientesEntities db = new DBGestorClientesEntities()) 
            {
                lst = (from d in db.Cliente
                       select new GestorClienteVM
                       {
                           Id = d.Id,
                           Nombre = d.Nombre,
                           Direccion1 = d.Direccion1,
                           Direccion2 = d.Direccion2,
                           Direccion3 = d.Direccion3
                       }).ToList();
            }

                return View(lst);
        }
    }
}