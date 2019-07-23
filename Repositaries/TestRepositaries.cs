using SportsApp.IRepositaries;
using SportsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsApp.Repositaries
{
    public class TestRepositaries : ITestRepositaries
    {

        private  SportsAppContext _context;

        

        public TestRepositaries(SportsAppContext context)
        {
            this._context = context;
        }


        public IQueryable<Test> GetAllTests()
        {
            foreach (var db in _context.Test)
            {
                db.NumOfParticipants = getNumOfParticipants(db.TestId);
            }

            var Tests = from t in _context.Test orderby t.Date descending select t;
            return Tests;
        }

        public  Test GetTestByID(int? id)
        {
            return  _context.Test.Find(id);
        }

        public void InsertTest(Test test)
        {
            _context.Add(test);
            
        }

        public void UpdateTest(Test test)
        {
            _context.Update(test);
           
        }

        public void DeleteTest(int id)
        {
            Test test = _context.Test.FirstOrDefault(m => m.TestId == id);
            _context.Test.Remove(test);
           
        }

        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }

        int getNumOfParticipants(int id)
        {
            int numOfParticipants = (from t in _context.Test
                                     join tr in _context.TestDetails
                                     on t.TestId equals tr.TestId
                                     where tr.TestId.Equals(id)
                                     select tr.AthleteName).Count();

            return numOfParticipants;
        }

    }
}
