//Create by Austin Sanders-05/05/2021
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OneStopBeauty.Data;
using OneStopBeauty.Models;

namespace OneStopBeauty.Controllers
{
    [Authorize(Roles = "Admin")]
    public class ItemsSoldController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ItemsSoldController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ItemsSold
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.ItemsSold.Include(i => i.BillingStatement).Include(i => i.Inventory).Include(i => i.Location).Include(i => i.Services);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: ItemsSold/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var itemSold = await _context.ItemsSold
                .Include(i => i.BillingStatement)
                .Include(i => i.Inventory)
                .Include(i => i.Location)
                .Include(i => i.Services)
                .FirstOrDefaultAsync(m => m.ItemSoldID == id);
            if (itemSold == null)
            {
                return NotFound();
            }

            return View(itemSold);
        }

        // GET: ItemsSold/Create
        public IActionResult Create()
        {
            ViewData["BillingStatementID"] = new SelectList(_context.BillingStatements, "BillingStatementID", "BillingStatementID"); //Might need to include a billling statement number in the model
            ViewData["InventoryID"] = new SelectList(_context.Inventories, "InventoryID", "Product_Name");
            ViewData["LocationID"] = new SelectList(_context.Location, "LocationID", "LocationID"); // May also need to include a location_num here as well
            ViewData["ServiceID"] = new SelectList(_context.Services, "ServiceID", "Service_Rendered");
            return View();
        }

        // POST: ItemsSold/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ItemSoldID,BillingStatementID,InventoryID,ServiceID,LocationID, Online, Shipped_Date_Sold_Item,Arrived_Date_Sold_Item,Ext_Price,Quantity,Discount")] ItemSold itemSold)
        {
            if (ModelState.IsValid)
            {
                _context.Add(itemSold);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["BillingStatementID"] = new SelectList(_context.BillingStatements, "BillingStatementID", "BillingStatementID", itemSold.BillingStatementID);
            ViewData["InventoryID"] = new SelectList(_context.Inventories, "InventoryID", "InventoryID", itemSold.InventoryID);
            ViewData["LocationID"] = new SelectList(_context.Location, "LocationID", "LocationID", itemSold.LocationID);
            ViewData["ServiceID"] = new SelectList(_context.Services, "ServiceID", "ServiceID", itemSold.ServiceID);
            return View(itemSold);
        }

        // GET: ItemsSold/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var itemSold = await _context.ItemsSold.FindAsync(id);
            if (itemSold == null)
            {
                return NotFound();
            }
            ViewData["BillingStatementID"] = new SelectList(_context.BillingStatements, "BillingStatementID", "BillingStatementID", itemSold.BillingStatementID);
            ViewData["InventoryID"] = new SelectList(_context.Inventories, "InventoryID", "InventoryID", itemSold.InventoryID);
            ViewData["LocationID"] = new SelectList(_context.Location, "LocationID", "LocationID", itemSold.LocationID);
            ViewData["ServiceID"] = new SelectList(_context.Services, "ServiceID", "ServiceID", itemSold.ServiceID);
            return View(itemSold);
        }

        // POST: ItemsSold/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ItemSoldID,BillingStatementID,InventoryID,ServiceID,LocationID, Online, Shipped_Date_Sold_Item,Arrived_Date_Sold_Item,Ext_Price,Quantity,Discount")] ItemSold itemSold)
        {
            if (id != itemSold.ItemSoldID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(itemSold);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ItemSoldExists(itemSold.ItemSoldID))
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
            ViewData["BillingStatementID"] = new SelectList(_context.BillingStatements, "BillingStatementID", "BillingStatementID", itemSold.BillingStatementID);
            ViewData["InventoryID"] = new SelectList(_context.Inventories, "InventoryID", "InventoryID", itemSold.InventoryID);
            ViewData["LocationID"] = new SelectList(_context.Location, "LocationID", "LocationID", itemSold.LocationID);
            ViewData["ServiceID"] = new SelectList(_context.Services, "ServiceID", "ServiceID", itemSold.ServiceID);
            return View(itemSold);
        }

        // GET: ItemsSold/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var itemSold = await _context.ItemsSold
                .Include(i => i.BillingStatement)
                .Include(i => i.Inventory)
                .Include(i => i.Location)
                .Include(i => i.Services)
                .FirstOrDefaultAsync(m => m.ItemSoldID == id);
            if (itemSold == null)
            {
                return NotFound();
            }

            return View(itemSold);
        }

        // POST: ItemsSold/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var itemSold = await _context.ItemsSold.FindAsync(id);
            _context.ItemsSold.Remove(itemSold);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ItemSoldExists(int id)
        {
            return _context.ItemsSold.Any(e => e.ItemSoldID == id);
        }
    }
}
