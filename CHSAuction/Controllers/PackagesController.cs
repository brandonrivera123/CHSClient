﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CHSAuction.Models;

namespace CHSAuction.Controllers
{
    public class PackagesController : Controller
    {
        private readonly EventBasedAuctionSoftwareContext _context;

        public PackagesController(EventBasedAuctionSoftwareContext context)
        {
            _context = context;
        }

        // GET: Packages
        public async Task<IActionResult> Index()
        {
            var packages = await _context.Packages.Include(p => p.Event).Include(p => p.Transaction).ToListAsync();
            var editPackage = new EditPackageVM { Packages = packages};

            ViewData["EventId"] = new SelectList(_context.Events, "EventId", "EventName");
            ViewData["TransactionId"] = new SelectList(_context.Transactions, "TransactionId", "TransactionId");
            return View(editPackage);
        }

        // GET: Packages/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var packages = await _context.Packages
                .Include(p => p.Event)
                .Include(p => p.Transaction)
                .FirstOrDefaultAsync(m => m.PackageId == id);
            if (packages == null)
            {
                return NotFound();
            }

            var items = await _context.Items
                .Include(i => i.Guest)
                .Include(i => i.Package)
                .ToListAsync();

            if (items == null)
            {
                return NotFound();
            }

            var packageItems = new PackageDetailsVM
            {
                Packages = packages,
                Items = items
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
            ViewData["PackageId"] = new SelectList(_context.Packages, "PackageId", "PackageName");
            ViewData["CategoryId"] = new SelectList(_context.Categories, "CategoryId", "CategoryName", packageItems.CategoryId);

            return View(packageItems);
        }


        // GET: Packages/Create
        public IActionResult Create()
        {
            ViewData["EventId"] = new SelectList(_context.Events, "EventId", "EventName");
            ViewData["TransactionId"] = new SelectList(_context.Transactions, "TransactionId", "TransactionId");
            return View();
        }

        // POST: Packages/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PackageId,PackageName,PackageDescription,PackageStartBid,PackageBidIncrement,PackageFinalPrice,EventId,TransactionId")] Packages packages)
        {
            if (ModelState.IsValid)
            {
                _context.Add(packages);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["EventId"] = new SelectList(_context.Events, "EventId", "EventName", packages.EventId);
            ViewData["TransactionId"] = new SelectList(_context.Transactions, "TransactionId", "TransactionId", packages.TransactionId);
            return View(packages);
        }

        // GET: Packages/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var packages = await _context.Packages.FindAsync(id);
            if (packages == null)
            {
                return NotFound();
            }
            ViewData["EventId"] = new SelectList(_context.Events, "EventId", "EventName", packages.EventId);
            ViewData["TransactionId"] = new SelectList(_context.Transactions, "TransactionId", "TransactionId", packages.TransactionId);
            return View(packages);
        }

        // POST: Packages/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PackageId,PackageName,PackageDescription,PackageStartBid,PackageBidIncrement,PackageFinalPrice,EventId,TransactionId")] Packages packages)
        {
            if (id != packages.PackageId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(packages);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PackagesExists(packages.PackageId))
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
            ViewData["EventId"] = new SelectList(_context.Events, "EventId", "EventName", packages.EventId);
            ViewData["TransactionId"] = new SelectList(_context.Transactions, "TransactionId", "TransactionId", packages.TransactionId);
            return View(packages);
        }

        // GET: Packages/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var packages = await _context.Packages
                .Include(p => p.Event)
                .Include(p => p.Transaction)
                .FirstOrDefaultAsync(m => m.PackageId == id);
            if (packages == null)
            {
                return NotFound();
            }

            return View(packages);
        }

        // POST: Packages/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            try
            {
                var packages = await _context.Packages.FindAsync(id);
                _context.Packages.Remove(packages);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            } catch (Exception ex)
            {
                return RedirectToAction(nameof(Index));
            }
        }

        // POST: Packages/Details
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Details(int packageId, int itemId)
        {
            var item = _context.Items.FirstOrDefault(i => i.ItemId == itemId);

            if (item == null)
                return NotFound();

            item.PackageId = packageId;

            if (ModelState.IsValid)
            {
                _context.Update(item);
                await _context.SaveChangesAsync();
            }

            return RedirectToAction("Details", "Packages", packageId);
        }

        private bool PackagesExists(int id)
        {
            return _context.Packages.Any(e => e.PackageId == id);
        }
    }
}
