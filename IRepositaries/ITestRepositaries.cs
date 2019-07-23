using SportsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsApp.IRepositaries
{
    public interface ITestRepositaries
    {
        IQueryable<Test> GetAllTests();
        Test GetTestByID(int? id);
        void InsertTest(Test test);
        void UpdateTest(Test test);
        void DeleteTest(int id);
        Task Save();
    }
}
