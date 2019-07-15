using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SportsApp.Models;

namespace SportsApp.Controllers
{
    public class TestDetailsController : Controller
    {
        private readonly SportsAppContext _context;

        public TestDetailsController(SportsAppContext context)
        {
            _context = context;
        }

        // GET: TestDetails
        public async Task<IActionResult> Index(int? id)
        {
            var testItem = await _context.Test.SingleOrDefaultAsync(m => m.TestId == id);

            ViewData["testid"] = id;
            ViewData["TestDate"] = testItem.Date.ToShortDateString();
            ViewData["TestType"] = testItem.TestType;

            var result = from t in _context.Test
                         join tr in _context.TestDetails
                         on t.TestId equals tr.TestId
                         where tr.TestId.Equals(id)
                         orderby tr.Distance descending
                         select new TestDetails
                         {
                             AthleteId = tr.AthleteId,
                             AthleteName = tr.AthleteName,
                             Distance = tr.Distance,
                             MyProperty = tr.MyProperty,
                             TestId = tr.TestId,
                            
                         };
           
                         
            var tmp = await result.ToListAsync();
           
          
            return View(tmp);
           
        }

       // GET: TestDetails/Create
        public IActionResult Create(int? id)
        {
            ViewData["id"] = id;
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AthleteName,Distance")] TestDetails testDetails,int id)
        {
            testDetails.TestId = id;

            if (ModelState.IsValid)
            {

                testDetails.MyProperty = this.checkFitness(testDetails.Distance);

                _context.Add(testDetails);
                await _context.SaveChangesAsync();
 
                return RedirectToAction("Index", "TestDetails", new { id = testDetails.TestId });


            }

            return View(testDetails);
        }

        // GET: TestDetails/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var testDetails = await _context.TestDetails.FindAsync(id);
            if (testDetails == null)
            {
                return NotFound();
            }
            return View(testDetails);
        }

    
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("AthleteId,AthleteName,TestId,Distance,MyProperty")] TestDetails testDetails)
        {
            if (id != testDetails.AthleteId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    testDetails.MyProperty = this.checkFitness(testDetails.Distance);
                    _context.Update(testDetails);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TestDetailsExists(testDetails.AthleteId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index", "TestDetails", new { id = testDetails.TestId });
            }
            return View(testDetails);
        }

        // GET: TestDetails/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var testDetails = await _context.TestDetails
                .FirstOrDefaultAsync(m => m.AthleteId == id);
            if (testDetails == null)
            {
                return NotFound();
            }

            return View(testDetails);
        }

        // POST: TestDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var testDetails = await _context.TestDetails.FindAsync(id);
            _context.TestDetails.Remove(testDetails);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "TestDetails", new { id = testDetails.TestId });
        }

        private bool TestDetailsExists(int id)
        {
            return _context.TestDetails.Any(e => e.AthleteId == id);
        }

        string checkFitness(decimal Distance)
        {
            string Fitness;

            if (Distance <= 1000)
            {
                Fitness = "Bellow Average";
            }
            else if (Distance > 1000 && Distance <= 2000)
            {
                Fitness = "Average";
            }
            else if (Distance > 2000 && Distance <= 3500)
            {
                Fitness = "Good";
            }
            else
            {
                Fitness = "Very Good";
            }
            return Fitness;
        }
    }
}
