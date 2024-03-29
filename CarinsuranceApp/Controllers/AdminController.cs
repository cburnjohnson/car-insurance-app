﻿using CarinsuranceApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarinsuranceApp.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            using (CarInsuranceEntities db = new CarInsuranceEntities())
            {
                var quoteinfo = db.QuoteInfoes;
                var quotes = new List<QuoteInfo>();
                foreach (var quote in quoteinfo)
                {
                    var quoteInfo = new QuoteInfo();
                    quoteInfo.Id = quote.Id;
                    quoteInfo.FirstName = quote.FirstName;
                    quoteInfo.LastName = quote.LastName;
                    quoteInfo.EmailAddress = quote.EmailAddress;
                    quoteInfo.Quote = quote.Quote;
                    quotes.Add(quoteInfo);
                }

                return View(quotes);
            }
                
        }
    }
}