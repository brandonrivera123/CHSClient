using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CHSAuction.Models;

namespace CHSAuction.Controllers
{
    public class TransactionsController : Controller
    {
        private readonly EventBasedAuctionSoftwareContext _context;

        public TransactionsController(EventBasedAuctionSoftwareContext context)
        {
            _context = context;
        }

        // GET: Transactions
        public async Task<IActionResult> Index()
        {
            var Transactions = await _context.Transactions.Include(t => t.Guest).Include(e => e.Event).ToListAsync();
            var Tickets = await _context.Tickets.Include(t => t.Event).Include(t => t.Guest).Include(t => t.Transaction).ToListAsync();
            var Packages = await _context.Packages.Include(p => p.Event).Include(p => p.Transaction).ToListAsync();

            var EditTransactionVM = new EditTransactionVM
            {
                Transactions = Transactions,
                Tickets = Tickets,
                Packages = Packages
            };

            var guests =
                _context.Guests
                    .Select(n => new
                    {
                        GuestId = n.GuestId,
                        GuestFullName = string.Format("{0} - {1}", n.GuestFullName, n.GuestEmail)
                    })
                    .ToList();

            ViewData["GuestId"] = new SelectList(guests, "GuestId", "GuestFullName");
            ViewData["EventId"] = new SelectList(_context.Events, "EventId", "EventName");

            return View(EditTransactionVM);
        }

        // GET: Transactions/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var transactions = await _context.Transactions
                .Include(t => t.Guest)
                .FirstOrDefaultAsync(m => m.TransactionId == id);
            if (transactions == null)
            {
                return NotFound();
            }

            return View(transactions);
        }

        // GET: Transactions/Create
        public IActionResult Create()
        {
            ViewData["GuestId"] = new SelectList(_context.Guests, "GuestId", "GuestFullName");
            return View();
        }

        // POST: Transactions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TransactionId,TransactionTotalPrice,TransactionAmountPaid,GuestId,EventId,TransactionSent,TransactionPaid")] Transactions transactions)
        {
            if (ModelState.IsValid)
            {
                _context.Add(transactions);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["GuestId"] = new SelectList(_context.Guests, "GuestId", "GuestFullName", transactions.GuestId);
            ViewData["EventId"] = new SelectList(_context.Events, "EventId", "EventName", transactions.EventId);
            return View(transactions);
        }

        // GET: Transactions/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var transactions = await _context.Transactions.FindAsync(id);
            if (transactions == null)
            {
                return NotFound();
            }
            ViewData["GuestId"] = new SelectList(_context.Guests, "GuestId", "GuestFullName", transactions.GuestId);
            return View(transactions);
        }

        // POST: Transactions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TransactionId,TransactionTotalPrice,TransactionAmountPaid,GuestId,EventId,TransactionSent,TransactionPaid")] Transactions transactions)
        {
            if (id != transactions.TransactionId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(transactions);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TransactionsExists(transactions.TransactionId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["GuestId"] = new SelectList(_context.Guests, "GuestId", "GuestFullName", transactions.GuestId);
            return View(transactions);
        }

        // GET: Transactions/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var transactions = await _context.Transactions
                .Include(t => t.Guest)
                .FirstOrDefaultAsync(m => m.TransactionId == id);
            if (transactions == null)
            {
                return NotFound();
            }

            return View(transactions);
        }

        // POST: Transactions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            try
            {
                var transactions = await _context.Transactions.FindAsync(id);
                _context.Transactions.Remove(transactions);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            } catch
            {
                return RedirectToAction(nameof(Index));
            }
        }

        // POST: Transactions/Index
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index(int transactionId, int ticketId)
        {
            var ticket = _context.Tickets.FirstOrDefault(i => i.TicketId == ticketId);

            if (ticket == null)
                return NotFound();

            ticket.TransactionId = transactionId;

            if (ModelState.IsValid)
            {
                _context.Update(ticket);
                await _context.SaveChangesAsync();
            }

            return RedirectToAction("Index", "Transactions");
        }

        // POST: Transactions/Details
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Details(int transactionId, int packageId)
        {
            var package = _context.Packages.FirstOrDefault(i => i.PackageId == packageId);

            if (package == null)
                return NotFound();

            package.TransactionId = transactionId;

            if (ModelState.IsValid)
            {
                _context.Update(package);
                await _context.SaveChangesAsync();
            }

            return RedirectToAction("Index", "Transactions");
        }

        private bool TransactionsExists(int id)
        {
            return _context.Transactions.Any(e => e.TransactionId == id);
        }
    }
}
