using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SportsApp.IRepositaries;
using SportsApp.Models;
using SportsApp.Repositaries;

namespace SportsApp.Controllers
{
    public class TestsController : Controller
    {
        private IUnitOfWork _unitOfWork;
        public TestsController(IUnitOfWork unitOfWork)
        {
           
            _unitOfWork = unitOfWork;
        }
       
        // GET: Tests
        public IActionResult Index()
        {
            var Tests = _unitOfWork.testRepositaries.GetAllTests();
            return View(Tests);
        }

       
        // GET: Tests/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public  async Task<IActionResult> Create([Bind("TestId,Date,TestType")] Test test)
        {
            if (ModelState.IsValid)
            {
                 _unitOfWork.testRepositaries.InsertTest(test);
                await _unitOfWork.save();
                return RedirectToAction(nameof(Index));
            }
            return View(test);
        }
        
       
        public  IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var test =  _unitOfWork.testRepositaries.GetTestByID(id);
            if (test == null)
            {
                return NotFound();
            }
            return View(test);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("TestId,Date,NumOfParticipants,TestType")] Test test)
        {
            if (id != test.TestId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                     _unitOfWork.testRepositaries.UpdateTest(test);
                     _unitOfWork.save();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TestExists(test.TestId))
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
            return View(test);
        }

        // GET: Tests/Delete/5
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var test = _unitOfWork.testRepositaries.GetTestByID(id);
            if (test == null)
            {
                return NotFound();
            }

            return View(test);
        }

        // POST: Tests/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {

            _unitOfWork.testRepositaries.DeleteTest(id);
            _unitOfWork.save();
            return RedirectToAction(nameof(Index));
        }

        private bool TestExists(int id)
        {
            if(_unitOfWork.testRepositaries.GetTestByID(id) != null)
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
