using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SportsApp.IRepositaries;
using SportsApp.Models;

namespace SportsApp.Controllers
{
    public class TestDetailsController : Controller
    {
        private IUnitOfWork _unitOfWork;
        public TestDetailsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: TestDetails
        public async Task<IActionResult> Index(int? id)
        {
            var testItem = await _unitOfWork.testRepositaries.GetAllTests().SingleOrDefaultAsync(m => m.TestId == id);
            ViewData["testid"] = id;
            ViewData["TestDate"] = testItem.Date.ToShortDateString();
            ViewData["TestType"] = testItem.TestType;

            var tmp = await _unitOfWork.testDetailsRepo.GetAllTestDetails(id).ToListAsync();
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
                await _unitOfWork.testDetailsRepo.InsertTest(testDetails);
                await _unitOfWork.testDetailsRepo.Save();
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

            var testDetails = await _unitOfWork.testDetailsRepo.GetTest(id);
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

                    _unitOfWork.testDetailsRepo.UpdateTest(testDetails);
                    await _unitOfWork.save();
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

            var testDetails = await _unitOfWork.testDetailsRepo.GetTest(id);
                
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
            TestDetails details = await _unitOfWork.testDetailsRepo.GetTest(id);
            int testId = details.TestId;
             _unitOfWork.testDetailsRepo.DeleteTest(id);
             await _unitOfWork.save();
            return RedirectToAction("Index", "TestDetails", new { id = testId});
        }

        private bool TestDetailsExists(int id)
        {
            if(_unitOfWork.testDetailsRepo.GetTest(id) != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
