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
    public class ItemsController : Controller
    {
        private readonly EventBasedAuctionSoftwareContext _context;

        public ItemsController(EventBasedAuctionSoftwareContext context)
        {
            _context = context;
        }

        // GET: Items
        public async Task<IActionResult> Index()
        {
            var items = _context.Items.Include(i => i.Guest).Include(i => i.Package);

            var itemsPackages = new ItemPackagesVM { items = items};

            var guests =
                _context.Guests
                    .Select(n => new
                    {
                        GuestId = n.GuestId,
                        GuestFullName = string.Format("{0} - {1}", n.GuestFullName, n.GuestEmail)
                    })
                    .ToList();

            ViewData["CategoryId"] = new SelectList(_context.Categories, "CategoryId", "CategoryName");
            ViewData["GuestId"] = new SelectList(guests, "GuestId", "GuestFullName");
            ViewData["PackageId"] = new SelectList(_context.Packages, "PackageId", "PackageName");
            return View(itemsPackages);
        }

        // GET: Items/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var items = await _context.Items
                .Include(i => i.Guest)
                .Include(i => i.Package)
                .FirstOrDefaultAsync(m => m.ItemId == id);
            if (items == null)
            {
                return NotFound();
            }

            return View(items);
        }

        // GET: Items/Create
        public IActionResult Create()
        {
            ViewData["CategoryId"] = new SelectList(_context.Categories, "CategoryId", "CategoryName");
            ViewData["GuestId"] = new SelectList(_context.Guests, "GuestId", "GuestFullName");
            ViewData["PackageId"] = new SelectList(_context.Packages, "PackageId", "PackageName");
            return View();
        }

        // POST: Items/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ItemId,ItemName,ItemDescription,CategoryId,ItemImage,ItemValue,PackageId,GuestId")] Items items)
        {
            if (ModelState.IsValid)
            {
                _context.Add(items);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoryId"] = new SelectList(_context.Categories, "CategoryId", "CategoryName", items.CategoryId);
            ViewData["GuestId"] = new SelectList(_context.Guests, "GuestId", "GuestFullName", items.GuestId);
            ViewData["PackageId"] = new SelectList(_context.Packages, "PackageId", "PackageName", items.PackageId);
            return View(items);
        }

        // GET: Items/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var items = await _context.Items.FindAsync(id);
            if (items == null)
            {
                return NotFound();
            }
            ViewData["CategoryId"] = new SelectList(_context.Categories, "CategoryId", "CategoryName", items.CategoryId);
            ViewData["GuestId"] = new SelectList(_context.Guests, "GuestId", "GuestFullName", items.GuestId);
            ViewData["PackageId"] = new SelectList(_context.Packages, "PackageId", "PackageName", items.PackageId);
            return View(items);
        }

        // POST: Items/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ItemId,ItemName,ItemDescription,CategoryId,ItemImage,ItemValue,PackageId,GuestId")] Items items)
        {
            if (id != items.ItemId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(items);
                    await _context.SaveChangesAsync();
                    //ViewData["itemId"] = id;
                    //return View("TEST", items);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ItemsExists(items.ItemId))
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
            ViewData["CategoryId"] = new SelectList(_context.Categories, "CategoryId", "CategoryName", items.CategoryId);
            ViewData["GuestId"] = new SelectList(_context.Guests, "GuestId", "GuestFullName", items.GuestId);
            ViewData["PackageId"] = new SelectList(_context.Packages, "PackageId", "PackageName", items.PackageId);
            return View(items);
        }

        // GET: Items/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var items = await _context.Items
                .Include(i => i.Category)
                .Include(i => i.Guest)
                .Include(i => i.Package)
                .FirstOrDefaultAsync(m => m.ItemId == id);
            if (items == null)
            {
                return NotFound();
            }

            return View(items);
        }

        // POST: Items/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            try
            {
                var items = await _context.Items.FindAsync(id);
                _context.Items.Remove(items);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            } catch (Exception ex)
            {
                return RedirectToAction(nameof(Index));
            }
        }

        private bool ItemsExists(int id)
        {
            return _context.Items.Any(e => e.ItemId == id);
        }
    }
}
