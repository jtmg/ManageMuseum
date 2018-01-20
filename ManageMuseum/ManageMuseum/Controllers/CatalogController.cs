using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ManageMuseum.Models;


namespace ManageMuseum.Controllers
{
    public class CatalogController : Controller
    {
        private OurContectDb db = new OurContectDb();
        // GET: Catalog
        public ActionResult ListArtPieces()
        {
            var query = db.ArtPieces.Include(V => V.ArtPieceState).ToList();
            ViewBag.Data = query;
            return View();
        }

        public ActionResult InsertArtPiece()
        {
            return View();
        }

        public ActionResult RemovePiece()
        {
            return View();
        }

        public ActionResult AttachPiece()
        {
            return Content("Insert art pieces to the event");
        }
    }
}