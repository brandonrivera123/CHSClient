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

        public IActionResult MessageSent(int transId, int Total, string guestName, string email )
        {

            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("CHS", "chsemail@chs.com"));
            message.To.Add(new MailboxAddress(guestName, email));
            message.Subject = "Children's Home Society - Gift Acknowledgement";

            var today = DateTime.Now.ToString("MMMM dd, yyyy");
            var guest = _context.Guests.Where(g => g.GuestFullName == guestName && g.GuestEmail == email).FirstOrDefault();
            var transaction = _context.Transactions.Where(t => t.TransactionId == transId).FirstOrDefault();
            var transEvent = _context.Events.Where(e => e.EventId == transaction.EventId).FirstOrDefault();
            var eventDate = transEvent.EventStart.ToString("MMMM dd, yyyy");

            string body = "Thank you for reshaping the future for children in Florida." +
                            "<br><br>" + 
                            "Your gift to Children's Home Society of Florida will help another child realize their full potential." +
                            "<br><br>" + 
                            "It's pretty amazing." +
                            "<br><br>" + 
                            "Because of your generosity, CHS can solve problems before they turn into crises. As we focus on helping kids " + 
                            "and families succeed - we're addressing core issues that lead to extreme violence, abuse, juvenile crime, drop-" + 
                            "out rates and poverty." +
                            "<br><br>" + 
                            "Your investment in solutions - not safety nets - will change the life trajectories for thousands of children and " + 
                            "families. We don't make these happy endings possible. You do. So thank <i>you</i>." +
                            "<br><br>" + 
                            "In the coming months, you can expect to hear more stories of empowerment, growth and success, as well as how " + 
                            "we're putting your generous gift to work." +
                            "<br><br>" + 
                            "Thank you again for building bridges to succes for children. We've been doing good for over 115 years and " + 
                            "we're glad you're a part of it, too." +
                            "<br><br>" + 
                            "Gratefully yours, " + 
                            "<br>" + 
                            "Don Du Chateau" + 
                            "<br>" + 
                            "Chief Development Office";

            message.Body = new TextPart("html")
            {
                Text = today + "<br><br>" +
                        guest.GuestFullName + "<br>" +
                        guest.GuestAddress + "<br>" +
                        guest.GuestCity + ", " + guest.GuestState + " " + guest.GuestZip + "<br><br>" +
                        "Dear " + guest.GuestFullName + "," + "<br><br>" + 
                        body + "<br>" + 
                        "<hr>" + 
                        "<b>OFFICIAL ACKNOWLEDGEMENT</b>" +
                        "<br>" + 
                        "<b>Date of Gift: " + eventDate + "</b>" +
                        "<br>" +
                        "<b>Gift Amount: $" + Total + "</b>" + "<br>" + 
                        "<hr>" + 
                        "<br>" + 
                        "<small>CHILDREN'S HOME SOCIETY OF FLORIDA, REGISTRATION #CH180, IS REGISTERED WITH THE STATE UNDER THE SOLICITATION OF " + 
                        "CONTRIBUTIONS ACT. A COPY OF THE OFFICIAL REGISTRATION AND FINANCIAL INFORMATION MAY BE OBTAINED FROM THE DIVISION OF " + 
                        "CONSUMER SERVICES BY CALLING TOLL-FREE (800-435-7352) WITHIN THE STATE OR BY VISITING <u>WWW.800HELPFLA.COM</u>. " + 
                        "REGISTRATION DOES NOT IMPLY ENDORSEMENT, APPROVAL OR RECOMMENDATION BY THE STATE."
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
