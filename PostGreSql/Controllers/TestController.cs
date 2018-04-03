using PostGreSql.Models.Context;
using PostGreSql.Models.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PostGreSql.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()

        {
            try
            {
                //System.Net.IPHostEntry host = new System.Net.IPHostEntry();
                //host = System.Net.Dns.GetHostEntry(Request.ServerVariables["REMOTE_HOST"]);


                //Response.Write(host.HostName);
                SampleDbContext dbContext = new SampleDbContext();
                var theResult = dbContext.Company.ToList().Select(t => new company()
                {
                    id = t.id,
                    name = t.name,
                    address = t.address,
                    age = t.age,
                    salary = t.salary,
                    gender = t.gender
                }).ToList();

                return Json(theResult, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {

                throw;
            }
           
        }

        [HttpGet]
        public ActionResult AddCompany()
        {

            return View();
        }
        [HttpPost]
        public ActionResult AddCompany(company model)
        {
            SampleDbContext db = new SampleDbContext();
            //model.gender = 'M';
            //int id =db.Company.ToList().Count+2;
           // model.id = id;
            model.salary = 5000;
            db.Company.Add(model);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}