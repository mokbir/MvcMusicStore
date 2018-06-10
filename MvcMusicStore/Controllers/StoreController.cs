using MvcMusicStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace MvcMusicStore.Controllers
{
    public partial class StoreController : Controller
    {
        MvcMusicStoreDB storeDB = new MvcMusicStoreDB();
        // GET: Store
        public virtual ActionResult Index()
        {
            var genres = storeDB.Genres.ToList();

            return View(genres);
        }
        // Browse
        public virtual ActionResult Browse(string genre)
        {
            if (String.IsNullOrEmpty(genre))
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var genreModel = storeDB.Genres.Include("Album")
                .Single(g => g.Name == genre);

            return View(genreModel);
        }
    }



}