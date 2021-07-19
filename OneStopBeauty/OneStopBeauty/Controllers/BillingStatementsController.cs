//Create by Austin Sanders-05/05/2021
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OneStopBeauty.Data;
using OneStopBeauty.Models;
using Microsoft.AspNetCore.Authorization;

namespace OneStopBeauty.Controllers
{
    [Authorize(Roles="Admin")]
    public class BillingStatementsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BillingStatementsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: BillingStatements
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.BillingStatements.Include(b => b.Customer).Include(b => b.Employee);
            return View(await applicationDbContext.ToListAsync());
        }

        //Partial post method for the Items Sold View 
        [HttpPost]
        public IActionResult getItemsSold(int id)
        {
            var itemsSold = _context.ItemsSold
                .Include(i => i.BillingStatement)
                .Include(i => i.Inventory)
                .Include(i => i.Services)
                .Include(i => i.Location)
                .Where(i => i.BillingStatementID == id).ToList();

            //returns the partial view
            return PartialView("_DetailsItemsSold", itemsSold);
        }



        // GET: BillingStatements/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var billingStatement = await _context.BillingStatements
                .Include(b => b.Customer)
                .Include(b => b.Employee)
                .FirstOrDefaultAsync(m => m.BillingStatementID == id);
            if (billingStatement == null)
            {
                return NotFound();
            }

            return View(billingStatement);
        }

        // GET: BillingStatements/Create
        public IActionResult Create()
        {
            //    ViewData["CustomerID"] = new SelectList(_context.Customers, "ID", "FirstName");
            //    ViewData["EmployeeID"] = new SelectList(_context.Employees, "ID", "FirstName");

            //pull customer from DB context 
            var customerList = _context.Customers.ToList();
            //list of select list items
            var customerSelectListNames = new List<SelectListItem>();
            //loop through customer list and add to the list 
            foreach (var item in customerList)
            {
                // create new customer
                SelectListItem listItemToAdd = new SelectListItem();
                //set text property
                listItemToAdd.Text = item.LastName + ", " + item.FirstName;
                //set value property 
                listItemToAdd.Value = item.ID.ToString();
                //add to the collection
                customerSelectListNames.Add(listItemToAdd);
                

        }
            ViewBag.customerList = customerSelectListNames;


            //pull employee from DB context 
            var employeeList = _context.Employees.ToList();
            //list of select list items
            var employeeSelectListNames = new List<SelectListItem>();
            //loop through customer list and add to the list 
            foreach (var item in employeeList)
            {
                // create new customer
                SelectListItem listItemToAdd = new SelectListItem();
                //set text property
                listItemToAdd.Text = item.LastName + ", " + item.FirstName;
                //set value property 
                listItemToAdd.Value = item.ID.ToString();
                //add to the collection
                employeeSelectListNames.Add(listItemToAdd);


            }
            ViewBag.employeeList = employeeSelectListNames;

            return View();



    }

        // POST: BillingStatements/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("BillingStatementID,CustomerID,EmployeeID,Invoice_Date,Total_Price,Taxes")] BillingStatement billingStatement)
        {
            if (ModelState.IsValid)
            {
                _context.Add(billingStatement);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
           // ViewData["CustomerID"] = new SelectList(_context.Customers, "ID", "ID", billingStatement.CustomerID);
           // ViewData["EmployeeID"] = new SelectList(_context.Employees, "ID", "ID", billingStatement.EmployeeID);

            //update for invalid input data
            var customerList = _context.Customers.ToList();
            //list of select list items
            var customerSelectListNames = new List<SelectListItem>();
            //loop through customer list and add to the list 
            foreach (var item in customerList)
            {
                // create new customer
                SelectListItem listItemToAdd = new SelectListItem();
                //set text property
                listItemToAdd.Text = item.LastName + ", " + item.FirstName;
                //set value property 
                listItemToAdd.Value = item.ID.ToString();
                if (item.ID == billingStatement.CustomerID)
                {
                    //this is the item that has been previously seletected by the user
                    listItemToAdd.Selected = true; //flag this as the selected item in the list
                    //close if 
                }

                //add to the collection
                customerSelectListNames.Add(listItemToAdd);
            } // close for each


            ViewBag.customerList = customerSelectListNames;

            //update for invalid input data
            var employeeList = _context.Customers.ToList();
            //list of select list items
            var employeeSelectListNames = new List<SelectListItem>();
            //loop through customer list and add to the list 
            foreach (var item in employeeList)
            {
                // create new customer
                SelectListItem listItemToAdd = new SelectListItem();
                //set text property
                listItemToAdd.Text = item.LastName + ", " + item.FirstName;
                //set value property 
                listItemToAdd.Value = item.ID.ToString();
                if (item.ID == billingStatement.EmployeeID)
                {
                    //this is the item that has been previously seletected by the user
                    listItemToAdd.Selected = true; //flag this as the selected item in the list
                    //close if 
                }

                //add to the collection
                employeeSelectListNames.Add(listItemToAdd);
            } // close for each


            ViewBag.customerList = customerSelectListNames;
            ViewBag.employeeList = employeeSelectListNames;

            return View(billingStatement);
        }

        // GET: BillingStatements/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var billingStatement = await _context.BillingStatements.FindAsync(id);
            if (billingStatement == null)
            {
                return NotFound();
            }

            //pull customer from DB context 
            var customerList = _context.Customers.ToList();
            //list of select list items
            var customerSelectListNames = new List<SelectListItem>();
            //loop through customer list and add to the list 
            foreach (var item in customerList)
            {
                // edit customer
                SelectListItem listItemToAdd = new SelectListItem();
                //set text property
                listItemToAdd.Text = item.LastName + ", " + item.FirstName;
                //set value property 
                listItemToAdd.Value = item.ID.ToString();
                //add to the collection
                customerSelectListNames.Add(listItemToAdd);


            }
            ViewBag.customerList = customerSelectListNames;


            //pull employee from DB context 
            var employeeList = _context.Employees.ToList();
            //list of select list items
            var employeeSelectListNames = new List<SelectListItem>();
            //loop through customer list and add to the list 
            foreach (var item in employeeList)
            {
                // edit employee
                SelectListItem listItemToAdd = new SelectListItem();
                //set text property
                listItemToAdd.Text = item.LastName + ", " + item.FirstName;
                //set value property 
                listItemToAdd.Value = item.ID.ToString();
                //add to the collection
                employeeSelectListNames.Add(listItemToAdd);


            }
            ViewBag.employeeList = employeeSelectListNames;

            //ViewData["CustomerID"] = new SelectList(_context.Customers, "ID", "ID", billingStatement.CustomerID);
            //ViewData["EmployeeID"] = new SelectList(_context.Employees, "ID", "ID", billingStatement.EmployeeID);
            return View(billingStatement);
        }

        // POST: BillingStatements/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("BillingStatementID,CustomerID,EmployeeID,Invoice_Date,Total_Price,Taxes")] BillingStatement billingStatement)
        {
            if (id != billingStatement.BillingStatementID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(billingStatement);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BillingStatementExists(billingStatement.BillingStatementID))
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
            ViewData["CustomerID"] = new SelectList(_context.Customers, "ID", "ID", billingStatement.CustomerID);
            ViewData["EmployeeID"] = new SelectList(_context.Employees, "ID", "ID", billingStatement.EmployeeID);
            return View(billingStatement);
        }

        // GET: BillingStatements/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var billingStatement = await _context.BillingStatements
                .Include(b => b.Customer)
                .Include(b => b.Employee)
                .FirstOrDefaultAsync(m => m.BillingStatementID == id);
            if (billingStatement == null)
            {
                return NotFound();
            }

            return View(billingStatement);
        }

        // POST: BillingStatements/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var billingStatement = await _context.BillingStatements.FindAsync(id);
            _context.BillingStatements.Remove(billingStatement);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BillingStatementExists(int id)
        {
            return _context.BillingStatements.Any(e => e.BillingStatementID == id);
        }
    }
}
