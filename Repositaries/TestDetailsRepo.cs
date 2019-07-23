using Microsoft.EntityFrameworkCore;
using SportsApp.IRepositaries;
using SportsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsApp.Repositaries
{
    public class TestDetailsRepo : ITestDetailsRepo
    {
        private SportsAppContext _context;

        public object ViewData { get; private set; }

        public TestDetailsRepo(SportsAppContext context)
        {
            this._context = context;
        }

        public IQueryable<TestDetails> GetAllTestDetails(int? id)
        {
           

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


            var tmp =  result;
            return tmp;

        }

        public async Task<TestDetails> GetTest(int? id)
        {
            var testDetails =await _context.TestDetails.FindAsync(id);
            return testDetails;
        }

        public async Task InsertTest(TestDetails testDetails)
        {
             testDetails.MyProperty = checkFitness(testDetails.Distance);
             await _context.AddAsync(testDetails);
           
        }

        
        public void UpdateTest(TestDetails testDetails)
        {
            testDetails.MyProperty = checkFitness(testDetails.Distance);
            _context.Update(testDetails);
        }

        public void DeleteTest(int id)
        {
            TestDetails testDetails = _context.TestDetails.Find(id);
            _context.TestDetails.Remove(testDetails);
        }

        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }

        public string checkFitness(decimal Distance)
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
