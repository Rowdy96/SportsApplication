using SportsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsApp.IRepositaries
{
    public interface ITestDetailsRepo
    {
        IQueryable<TestDetails> GetAllTestDetails(int? id);
        Task<TestDetails> GetTest(int? id);
        Task InsertTest(TestDetails test);
        void UpdateTest(TestDetails test);
        void DeleteTest(int id);
        Task Save();
        string checkFitness(decimal Distance);
       
    }
}
