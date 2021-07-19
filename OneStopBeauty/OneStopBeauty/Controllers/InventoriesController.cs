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
using OneStopBeauty.ViewModels;

namespace OneStopBeauty.Controllers
{
    public class InventoriesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public InventoriesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Inventories
        public async Task<IActionResult> Index()
        {
            var inventoryContext = _context.Inventories.OrderBy(i => i.Product_Name);
            var sessionClicks = HttpContext.Session.Get<List<Inventory>>("UserProductClicks");
            if (sessionClicks != null)
            {
                ViewBag.UserProductClicks = sessionClicks;
            }


            return View(await inventoryContext.ToListAsync());
        }

        // GET: Inventories/Details/5
        public async Task<IActionResult> Details(int? id)
        {

            //access a session variable and store in a local variable 
            var lastProduct = HttpContext.Session.Get<Inventory>("LastProductViewed");
            if (id == null)
            {
                return NotFound();
            }

            var inventory = await _context.Inventories
                .FirstOrDefaultAsync(m => m.InventoryID == id);
            if (inventory == null)
            {
                return NotFound();
            }

            //check the session variable 
            if (lastProduct != null && lastProduct.InventoryID == inventory.InventoryID)
            {
                //dsplay through viewBag 
                ViewBag.Message = "You Just Clicked on the Same Product Again";
            }
            else
            {
                ViewBag.Message = "You Clicked on a New Product";
            }


            //set the session variable of the last product viewed
            HttpContext.Session.Set<Inventory>("LastProductViewed", inventory);
            AddClickedInventoryToSession(inventory);
            return View(inventory);
        }

        // GET: Inventories/Create
        [Authorize(Roles = "Admin")]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Inventories/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize(Roles = "Admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("InventoryID,Product_Name,Unit_Price,Purpose")] Inventory inventory)
        {
            if (ModelState.IsValid)
            {
                _context.Add(inventory);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(inventory);
        }

        // GET: Inventories/Edit/5
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var inventory = await _context.Inventories.FindAsync(id);
            if (inventory == null)
            {
                return NotFound();
            }
            return View(inventory);
        }

        // POST: Inventories/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize(Roles = "Admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("InventoryID,Product_Name,Unit_Price,Purpose")] Inventory inventory)
        {
            if (id != inventory.InventoryID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(inventory);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!InventoryExists(inventory.InventoryID))
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
            return View(inventory);
        }

        // GET: Inventories/Delete/5
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var inventory = await _context.Inventories
                .FirstOrDefaultAsync(m => m.InventoryID == id);
            if (inventory == null)
            {
                return NotFound();
            }

            return View(inventory);
        }

        // POST: Inventories/Delete/5
        [Authorize(Roles = "Admin")]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var inventory = await _context.Inventories.FindAsync(id);
            _context.Inventories.Remove(inventory);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool InventoryExists(int id)
        {
            return _context.Inventories.Any(e => e.InventoryID == id);
        }


        // GET: Inventories/Search
        public async Task<IActionResult> Search()
        {

            var model = new InventorySearchViewModel();

            return View(model);
        }


        // Post: Inventories/Search
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Search(InventorySearchViewModel model)
        {
            var results = _context.Inventories.Where(i =>
            i.Product_Name.ToLower().Contains(model.Inventory.Product_Name.ToLower()
            )).ToList();

            if (results.Count <= 1)
            {
                model.SearchError = "No product found with the search criteria provided";
                if (results.Count == 1)
                {
                    return RedirectToAction("Details", "Inventories", new
                    {
                        id = results[0].InventoryID
                    });
                }
            }
            model.ResultList = results;
            return View(model);
        }

        //manage suppliers (for ItemsOrdered model) 
        [Authorize(Roles = "Admin")]
        public IActionResult ManageSuppliers (int? id)
        {
            if (id == null) // if the id is valid
            {
                return RedirectToAction("Index");
            }

            //set the value of viewBag.InventoryID as used in the ManagedSuppliers View
            ViewBag.InventoryID = id;

            // find the suppliers for this inventory item 
            // var inventorySupplier = _context.ItemsOrdered.Where(io => io.InventoryID == id).ToList();
            var inventorySupplier = _context.ItemsOrdered
                .Include(io=>io.Supplier)
                .Include(io=>io.Inventory)
                .Where(io => io.InventoryID == id).ToList();
            //check to see if the list of suppliers is empty- if so, end to "AddToItemsOrdered" Method
            if (inventorySupplier.Count < 1)
            {
                return RedirectToAction("AddSupplier", new { id = id });
            }

            // return displaying a list of suppliers
            return View(inventorySupplier); // suppliers (items ordered) sent to view

        }

        [Authorize(Roles = "Admin")]
        public IActionResult DropSupplier (int? id) //allow for the dropping of ItemOrdered with the given supplier
        {
            if (id== null) //check for a valid id 
            {
                return RedirectToAction("Index");
            }

            //else get into to dispaly on confirmation to delete page
            var itemsOrdered = _context.ItemsOrdered
                .Include(io => io.Supplier)
                .Include(io => io.Inventory)
                .SingleOrDefault(io => io.ItemOrderedID == id);
            //return to view page for display
            return View(itemsOrdered);
        }

        //post method for DropSupplier
        [Authorize(Roles = "Admin")]
        [HttpPost, ActionName("DropSupplier")]
        public IActionResult DropSupplierConfirmed (int id)
        {
            var itemOrdered = _context.ItemsOrdered.SingleOrDefault(io => io.ItemOrderedID == id);

            //indicate what item to remove 
            _context.ItemsOrdered.Remove(itemOrdered);
            //commit the changes to the database
            _context.SaveChanges();

            return RedirectToAction("ManageSuppliers", new { id = itemOrdered.InventoryID });

        }

        [Authorize(Roles = "Admin")]
        public IActionResult AddSupplier(int? id)
        {
            //need to query for a list of available suppliers (2 step linq process) 
            //1- create an exepction list- those course sections the student is enrolled in

            var inventoryItemsOrdered = _context.ItemsOrdered
                .Include(io => io.Supplier)
                .Include(io => io.Inventory)
               .Where(io => io.InventoryID == id).ToList();

            //2- get a list of all courses except those in the exception list
            var supplierList = _context.Suppliers
                .Except(inventoryItemsOrdered.Select(io => io.Supplier))
                .ToList();

            //create the list of the model - need a list of StudentAddSectionViewModels that is expected
            //by the view
            List<AddSupplierViewModel> model = new List<AddSupplierViewModel>();

            //loop trough the list of course sections that was returned by the query 
            //and add to the list of the viewmodel,  setting selected property to false
            foreach (var supplier in supplierList)
            {
                //create a new object of the view model 
                AddSupplierViewModel selectionItem = new AddSupplierViewModel();

                //set the properties 
                selectionItem.Supplier = supplier;
                selectionItem.Selected = false;

                //add item to the list 
                model.Add(selectionItem);
            }

            //set the value for ViewBag.SectionID for use in the view
            ViewBag.InventoryID = id;

            //return the view passing the model 
            return View(model);

        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public IActionResult AddSupplier(int id, List<AddSupplierViewModel> SupplierToAdd)
        {
            //loop through the list of view models to see if the selected property was checked
            //if it was add this course section 
            foreach (var supplier in SupplierToAdd)
            {
                if (supplier.Selected)
                {
                    //if checkedBox is checked 
                    //create a new object of the RosterItes model 
                    ItemOrdered supplierToAdd = new ItemOrdered();

                    //set the properties for the RosterItem 
                    supplierToAdd.InventoryID = id;
                    supplierToAdd.SupplierID = supplier.Supplier.SupplierID;

                    //add the supplier to the items ordered
                    _context.ItemsOrdered.Add(supplierToAdd);
                }
            }

            //update the database (outside of the loop) 
            _context.SaveChanges();

            //post-redirect-get patters 
            return RedirectToAction("ManageSuppliers", new { id = id });
        }

        [Authorize(Roles = "Admin")]
        private void AddClickedInventoryToSession(Inventory product)
        {
            var sessionClicks = HttpContext.Session.Get<List<Inventory>>("UserProductClicks");
            if (sessionClicks == null)
            {
                sessionClicks = new List<Inventory>();
            }

            var productInSession = sessionClicks.FirstOrDefault(s => s.InventoryID == product.InventoryID);

            if (productInSession == null)
            {
                sessionClicks.Add(product);
                HttpContext.Session.Set<List<Inventory>>("UserProductClicks", sessionClicks);
                var UserProductClicks = sessionClicks;
            }
        }
    }
}
