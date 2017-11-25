﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Mascota.Models;

namespace Mascota.Controllers
{
    public class HomeController : Controller
    {
        List<Mascota.Models.Mascota>  listado =  new List<Mascota.Models.Mascota>();

        public HomeController() {
            listado
                .Add(new Models.Mascota() { codigo = 1, nombre="Jack", propietario="Ivan Peters", edad=10, raza="Kiltro" });
            listado
                .Add(new Models.Mascota() { codigo = 2, nombre = "Boby", propietario = "Juan Peters", edad = 1, raza = "Tiburon" });

        }
        public IActionResult Formulario() { 
         
            return View(new Mascota.Models.Mascota());
        }
        public IActionResult Listado()
        { 
            return View(    listado );
        }
        public IActionResult Ficha(int codigo, string nombre, string raza, string propietario, int edad)
        {
            Mascota.Models.Mascota nueva = new Models.Mascota()
            {
                codigo = codigo,
                nombre = nombre,
                raza = raza,
                propietario = propietario,
                edad = edad
            };

            return View( nueva );

        }
    }
}
