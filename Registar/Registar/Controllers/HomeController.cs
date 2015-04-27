using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Registar.BusinessLayer;
using Registar.Models;
using Registar.BusinessLayer.Contracts;
using Registar.DataLayer.Factory;
using Registar.DataLayer;

namespace Registar.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            //call BL
            //BikeSearchCommand _command = new BikeSearchCommand();            
            //BikeSearchResult _result = CommandInvoker.InvokeCommand<BikeSearchCommand, BikeSearchResult>(_command);
            //Console.WriteLine(_result.ToString());
            


            BikeSearchCommand command = new BikeSearchCommand();
            BikeSearchResult _result = CommandInvoker.InvokeCommand<BikeSearchCommand, BikeSearchResult>(command);
                     
            return View(_result.Result);
        }

        /// <summary>
        /// Ne go koristam ovoj metod
        /// </summary>
        /// <returns></returns>
        public ActionResult Index2()
        {
            //List<BikeModel> _result = new List<BikeModel>();
            //_result.Add(new BikeModel() { Colour = "red", Model = "R1", Producer = "Specialized", RegNumber = "007" });
            //_result.Add(new BikeModel() { Colour = "red", Model = "R1", Producer = "Specialized", RegNumber = "007" });
            //_result.Add(new BikeModel() { Colour = "red", Model = "R1", Producer = "Specialized", RegNumber = "007" });
            //_result.Add(new BikeModel() { Colour = "red", Model = "R1", Producer = "Specialized", RegNumber = "007" });
            ////
            //this.ViewBag.SomeNewProperty = "theValue";
            //this.ViewData["SomeNewProperty"] = "theValue";
            ////
            //return View("Index",_result);
            return View();
        }

    }
}
