﻿using Microsoft.AspNetCore.Mvc;
using MvcCoreClienteWCF.Services;

namespace MvcCoreClienteWCF.Controllers
{
    public class MetodosVariosController : Controller
    {
        private ServicesMetodosVarios service;

        public MetodosVariosController(ServicesMetodosVarios service)
        {
            this.service = service;
        }

        public IActionResult TablaMultiplicar()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> TablaMultiplicar(int numero)
        {
            int[] datos = await this.service.GetTablasMultiplicarAsync(numero);
            return View(datos);
        }
    }
}
