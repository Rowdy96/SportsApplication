using SportsApp.IRepositaries;
using SportsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsApp.Repositaries
{
    public class UnitOfWork : IUnitOfWork
    {
        private SportsAppContext _context;
        private ITestDetailsRepo _testDetailsRepo;
        private ITestRepositaries _testRepositaries;

        public UnitOfWork(SportsAppContext context)
        {
            _context = context;
        }

        public ITestDetailsRepo testDetailsRepo
        {
            get
            {
                _testDetailsRepo = new TestDetailsRepo(_context);
                return _testDetailsRepo;
            }
        }

        public ITestRepositaries testRepositaries
        {
            get
            {
                _testRepositaries = new TestRepositaries(_context);
                return _testRepositaries;
            }
        }

        public async Task save()
        {
           await _context.SaveChangesAsync();
        }
    }
}
