/* Daniel Garson 
 * CIS 237
 * Due: 4/27/18
 */

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using cis237assignment6.Models;

namespace cis237assignment6.Controllers
{   
    //this authorize is used so nobody can get to the beverages unless logged in
    [Authorize]
    public class BeveragesController : Controller
    {
        private beveragesContext db = new beveragesContext();

       

        public ActionResult Index()
        {

            //Setup a variable to hold the Beverages
            DbSet<Beverage> BeveragesToFilter = db.Beverages;

            //Setup strings to hold the data that might be in the session.
            //If there is nothing in the session we can still use these variables
           //as a default value.

            string filterDescription = "";
            string filterMin = "";
            string filterMax = "";
            string filterPack = "";

            //Define a min and max prices
            int min = 0;
            int max = 10000;


            //Check to see if there is a value in the session, and if there is, assign it
           //to the variable that we setup to hold the value

            if (!String.IsNullOrWhiteSpace((string)Session["session_Description"]))
            {
                filterDescription = (string)Session["session_Description"];
            }
            if (!String.IsNullOrWhiteSpace((string)Session["session_min"]))
            {
                filterMin = (string)Session["session_min"];
                min = Int32.Parse(filterMin);
            }
            if (!String.IsNullOrWhiteSpace((string)Session["session_max"]))
            {
                filterMax = (string)Session["session_max"];
                max = Int32.Parse(filterMax);
            }

            if (!String.IsNullOrWhiteSpace((string)Session["session_pack"]))
            {
                filterPack = (string)Session["session_pack"];
            }

            //Do the filter on the BeveragesToFilter. 
            // default values for each of the filterparameters, Description, min price, max price, and Pack,
            IEnumerable<Beverage> filtered = BeveragesToFilter.Where(bev => bev.pack.Contains(filterPack) && bev.price  
                                                                                         >= min && bev.price <= max &&
                                                                                  bev.name.Contains(filterDescription) );
                                                                    

            //Converts dataset to a list.
            IEnumerable <Beverage> filteredList = filtered.ToList();

            //Place the string representation of the values that are in the session into
            //the viewbag so that they can be retrieved and displayed on the view
            ViewBag.filterName = filterDescription;
            ViewBag.filterMin = filterMin;
            ViewBag.filterMax = filterMax;
            ViewBag.filterPack = filterPack;

            //Return the view with the filtered selection of Beverages.
            return View(filteredList);




        }
        // GET: Beverages/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Beverage beverage = db.Beverages.Find(id);
            if (beverage == null)
            {
                return HttpNotFound();
            }
            return View(beverage);
        }

        // GET: Beverages/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Beverages/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,name,pack,price,active")] Beverage beverage)
        {
            if (ModelState.IsValid)
            {
                db.Beverages.Add(beverage);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(beverage);
        }

        // GET: Beverages/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Beverage beverage = db.Beverages.Find(id);
            if (beverage == null)
            {
                return HttpNotFound();
            }
            return View(beverage);
        }

        // POST: Beverages/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,name,pack,price,active")] Beverage beverage)
        {
            if (ModelState.IsValid)
            {
                db.Entry(beverage).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(beverage);
        }

        // GET: Beverages/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Beverage beverage = db.Beverages.Find(id);
            if (beverage == null)
            {
                return HttpNotFound();
            }
            return View(beverage);
        }

        // POST: Beverages/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Beverage beverage = db.Beverages.Find(id);
            db.Beverages.Remove(beverage);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        
       
        //  method as POST reaches from a form submit
        [HttpPost]

        // validate the antiForgeryToken since its included it in the form.
        [ValidateAntiForgeryToken]
        public ActionResult Filter()
        {
            // form data  sent out of the request object

            //description
            string Description = Request.Form.Get("Description");

            //minimum price
            string min = Request.Form.Get("min");

            //maximum price
            string max = Request.Form.Get("max");

            //pack
            string pack = Request.Form.Get("pack");

            //puts form data into the session so that other methods can have access to it.
            Session["session_Description"] = Description;
            Session["session_min"] = min;
            Session["session_max"] = max;
            Session["session_pack"] = pack;

            //Redirect to the index page
            return RedirectToAction("Index");
        }
       

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
