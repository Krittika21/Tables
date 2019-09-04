using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ZomatoTables.Models;

namespace ZomatoTables.Controllers
{
    public class EachRestaurantsController : Controller
    {
        private readonly ZomatoTablesContext _context;

        public EachRestaurantsController(ZomatoTablesContext context)
        {
            _context = context;
        }

        // GET: EachRestaurants
        public async Task<IActionResult> Index()
        {
            return View(await _context.EachRestaurant.ToListAsync());
        }

        // GET: EachRestaurants/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var eachRestaurant = await _context.EachRestaurant
                .FirstOrDefaultAsync(m => m.ID == id);
            if (eachRestaurant == null)
            {
                return NotFound();
            }

            return View(eachRestaurant);
        }

        // GET: EachRestaurants/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: EachRestaurants/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Name")] EachRestaurant eachRestaurant)
        {
            if (ModelState.IsValid)
            {
                _context.Add(eachRestaurant);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(eachRestaurant);
        }

        // GET: EachRestaurants/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var eachRestaurant = await _context.EachRestaurant.FindAsync(id);
            if (eachRestaurant == null)
            {
                return NotFound();
            }
            return View(eachRestaurant);
        }

        // POST: EachRestaurants/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Name")] EachRestaurant eachRestaurant)
        {
            if (id != eachRestaurant.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(eachRestaurant);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EachRestaurantExists(eachRestaurant.ID))
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
            return View(eachRestaurant);
        }

        // GET: EachRestaurants/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var eachRestaurant = await _context.EachRestaurant
                .FirstOrDefaultAsync(m => m.ID == id);
            if (eachRestaurant == null)
            {
                return NotFound();
            }

            return View(eachRestaurant);
        }

        // POST: EachRestaurants/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var eachRestaurant = await _context.EachRestaurant.FindAsync(id);
            _context.EachRestaurant.Remove(eachRestaurant);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EachRestaurantExists(int id)
        {
            return _context.EachRestaurant.Any(e => e.ID == id);
        }
    }
}
