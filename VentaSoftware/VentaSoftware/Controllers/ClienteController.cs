﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VentaSoftware.Models;

namespace VentaSoftware.Controllers
{
    public class ClienteController : Controller
    {
        private VentaSoftwareContext context = new VentaSoftwareContext();
        // GET: Cliente
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CrearCliente()
        {
            Cliente nuevoCliente = new Cliente();
            nuevoCliente.Estado = true;
            return View("CrearCliente", nuevoCliente);
        }

        [HttpPost]
        public ActionResult CrearCliente(Cliente cliente)
        {
            if (!ModelState.IsValid)
            {
                return View("CrearCliente", cliente);
            }
            //genera codigo de cliente
            Random r = new Random();
            cliente.Cod_cliente = r.Next(1000,9999);

            context.Clientes.Add(cliente);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult BuscarClientexID(int id)
        {
            Cliente cliente = context.Clientes.Find(id);
            return View("datosCliente",cliente);
        }
    }
}