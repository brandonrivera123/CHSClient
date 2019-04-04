using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CHSAuction.Models;
using MimeKit;

using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using MailKit.Net.Smtp;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CHSAuction.Controllers
{
    public class HomeController : Controller
    {
        private readonly EventBasedAuctionSoftwareContext _context;

        public HomeController(EventBasedAuctionSoftwareContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Events.ToListAsync());
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult MessageSent(int transId, int Total, string guestFirst, string guestLast, string email )
        {

            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("Brandon", "brandonviolin@gmail.com"));
            message.To.Add(new MailboxAddress("Guest", email));
            message.Subject = "Test Transaction";

            string packages = "";

            foreach(var package in _context.Packages.Where(p => p.TransactionId == transId))
            {
                packages += "<br><br>" + package.PackageName + ":";
                foreach(var item in _context.Items.Where(m => m.PackageId == package.PackageId))
                {
                    packages += "<br> - " + item.ItemName;
                }
                packages += "<br>Package Price: " + package.PackageFinalPrice + "<hr />";
            }

            message.Body = new TextPart("html")
            {
                Text = "First Name:" + guestFirst + "<br>Last Name:" + guestLast + "<br>Total Price:" + Total + "<br>Packages: " + packages
            };

            using (var client = new SmtpClient())
            {
                client.Connect("smtp.gmail.com", 587, false);
                client.Authenticate("brandonviolin@gmail.com", "bubbajoe1");
                client.Send(message);
                client.Disconnect(true);
            }

            return View();
        }

        public IActionResult Register()
        {
            ViewData["Message"] = "Check In";

            return View();
        }

        public IActionResult Payments()
        {
            ViewData["Message"] = "Payment";

            return View();
        }

        public IActionResult NewItem()
        {
            ViewData["Message"] = "NewItem";

            return View();
        }

        public IActionResult Event()
        {
            ViewData["Message"] = "Event";

            return View();
        }

        public IActionResult EventItems()
        {
            ViewData["Message"] = "Event Items";

            return View();
        }

		public IActionResult CheckIn()
        {
            ViewData["Message"] = "Check In";

            return View();
		}
        public IActionResult Invoice()
        {
            return View();
        }

        public IActionResult TicketSales()
        {
            return View();
        }

        public IActionResult ItemLog()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
