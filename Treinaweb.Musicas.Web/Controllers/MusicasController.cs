using AutoMapper;
using RepositorioMusicasEntity;
using RepositoriosComum;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Treinaweb.Musicas.Acesso.Entity.Context;
using Treinaweb.Musicas.Dominio;
using Treinaweb.Musicas.Web.ViewModels.Musica;

namespace Treinaweb.Musicas.Web.Controllers
{
    public class MusicasController : Controller
    {
        private IRepositorioGenerico<Musica, long> repositorioMusicas = new MusicasRepositorio(new MusicasDbContext());

        // GET: Musicas
        public ActionResult Index()
        {
            return View(Mapper.Map<List<Musica>, List<MusicaExibicaoViewModel>>(repositorioMusicas.Selecionar()));
        }

        // GET: Musicas/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Musica musica = repositorioMusicas.SelecionarId(id.Value);
            if (musica == null)
            {
                return HttpNotFound();
            }
            return View(Mapper.Map<Musica, MusicaExibicaoViewModel>(musica));
        }

        // GET: Musicas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Musicas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Nome,IdAlbum")] MusicaViewmodel viewmodel)
        {
            if (ModelState.IsValid)
            {
                Musica musica = Mapper.Map<MusicaViewmodel, Musica>(viewmodel);
                repositorioMusicas.Inserir(musica);
                return RedirectToAction("Index");
            }

            return View(viewmodel);
        }

        // GET: Musicas/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Musica musica = repositorioMusicas.SelecionarId(id.Value);
            if (musica == null)
            {
                return HttpNotFound();
            }
            return View(Mapper.Map<Musica, MusicaViewmodel>(musica));
        }

        // POST: Musicas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Nome,IdAlbum")] MusicaViewmodel viewmodel)
        {
            if (ModelState.IsValid)
            {
                Musica musica = Mapper.Map<MusicaViewmodel, Musica>(viewmodel);
                repositorioMusicas.Alterar(musica);
                return RedirectToAction("Index");
            }
            return View(viewmodel);
        }

        // GET: Musicas/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Musica musica = repositorioMusicas.SelecionarId(id.Value);
            if (musica == null)
            {
                return HttpNotFound();
            }
            return View(Mapper.Map<Musica, MusicaExibicaoViewModel>(musica));
        }

        // POST: Musicas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            repositorioMusicas.ExcluirId(id);
            return RedirectToAction("Index");
        }

        
    }
}
