using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GestorCliente.Models.ViewModels
{
    public class GestorClienteVM
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Direccion1 { get; set; }
        public string Direccion2 { get; set; }
        public string Direccion3 { get; set; }
    }
}