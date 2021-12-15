using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Filmes.Models;

namespace Filmes.Controllers{
    public class FlixssaController:Controller{
        private readonly FilmeContext context;

        public FlixssaController(FilmeContext dbContext)
        {
            context = dbContext;
        }

        // GET: /Main/
        public IActionResult Main()
        {
            List<Filme> Filmes = context.Filmes.ToList();

            return View(Filmes);
        }

    public IActionResult Add()
        {
            AddFilmeVm AddFilmeVm = new AddFilmeVm();
            return View(AddFilmeVm);
        }

        [HttpPost]
        public IActionResult Add(AddFilmeVm AddFilmeVm)
        {
            if (ModelState.IsValid)
            {
                // Add the new Filme to my existing Filmes
                Filme newFilme = new Filme
                {
                    Titulo = AddFilmeVm.Titulo,
                    Lancamento = AddFilmeVm.Lancamento,
                    Type = AddFilmeVm.Type
                };

                context.Filmes.Add(newFilme);
                context.SaveChanges();

                return Redirect("/Filme");
            }

            return View(AddFilmeVm);
        }

        public IActionResult Remove()
        {
            ViewBag.title = "Remove Filmes";
            ViewBag.Filmes = context.Filmes.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult Remove(int[] FilmeIds)
        {
            foreach (int FilmeId in FilmeIds)
            {
                Filme theFilme = context.Filmes.Single(f=> f.FilmeId == FilmeId);
                context.Filmes.Remove(theFilme);
            }

            context.SaveChanges();

            return Redirect("/filmes");
                }
        
        }
    }
