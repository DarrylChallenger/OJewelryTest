using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OJewelryTest.Models;

namespace OJewelryTest.Controllers
{
    public class HomeController : Controller
    {

        public HomeController()
        {
        }

        public ActionResult Index()
        {
            var dataContext = new AddClientDC();
            /*
            var newClient = (from client in dataContext.Clients
                          join company in dataContext.Companies on client.Id equals company.Id
                          join collection in dataContext.Collections on company.Id equals collection.Id

                          select new NewClientModel (
                              client.Name,
                              client.Phone,
                              client.Email,
                              company.Name,
                              collection.Name
                          )).ToList();
            */
            /*
            var newClient = dataContext.Clients.Join(dataContext.Collections, cli => cli.Id, coll => coll.Id,
                (cli, coll) => new NewClientModel
                {
                    ClientName = cli.Name,
                    ClientPhone = cli.Phone,
                    ClientEmail = cli.Email,
                    CompanyName = "CoName",
                    CollectionName = coll.Name,
                    CompanyId = coll.CompanyId
                })/*.Join(dataContext.Companies, nc => nc.CompanyId, co => co.Id, (nc, co) => new NewClientModel
                { 
                    ClientName = nc.ClientName,
                    ClientPhone = nc.ClientPhone,
                    ClientEmail = nc.ClientEmail,
                    CompanyName = co.Name,
                    CollectionName = nc.CollectionName,
                    CompanyId = -1
                }).ToList()/*.Select(n => new NewClientModel(
                    n.ClientName,
                    n.ClientPhone,
                    n.ClientEmail, 
                    n.CompanyName, 
                    n.CollectionName,
                    n.CompanyId)).ToList()
            */;
            var newClient = dataContext.Clients.Join(dataContext.Companies, cli => cli.Id, com => com.Id,
                (cli, com) => new
                {
                    ClientName = cli.Name,
                    ClientPhone = cli.Phone,
                    ClientEmail = cli.Email,
                    CompanyName = com.Name
                }).ToList().Select(n => new NewClientModel( 
                    n.ClientName,
                    n.ClientPhone,
                    n.ClientEmail,
                    n.CompanyName
                )).ToList();    
            return View(newClient);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult AddCompany()
        {
            return View();
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult AddCompany(FormCollection form)
        {
            return View();
        }

        public ActionResult NewClient()
        {
            return View();
        }
    }
}
