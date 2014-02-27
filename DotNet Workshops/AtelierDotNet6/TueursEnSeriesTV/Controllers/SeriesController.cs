using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TueursEnSeries.Models;

namespace TueursEnSeries.Controllers
{
    public class SeriesController : Controller
    {
        //
        // GET: /Series/
        public ActionResult Index()
        {
            return View();
        }
        //
        // GET: /Series/Search/SerieTitle
        public ActionResult Search(string q)
        {
            SerieList list = new SerieList();

            list.AppendSearch(HttpUtility.UrlEncode(q), true);
            ViewData["series"] = list.All;

            return View();
        }

        public static Serie FromId(string id)
        {
            
            System.Xml.Linq.XElement url=System.Xml.Linq.XElement.Load("http://thetvdb.com/api/E46868F703653AE2/series/"+id+"/all/fr.xml");
            Serie s = new Serie(url, false);
            //s.Episodes;
            return s;
        }
            
    }
}
