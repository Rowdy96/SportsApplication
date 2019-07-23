using SportsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsApp.IRepositaries
{
    public interface IUnitOfWork
    {
        ITestDetailsRepo testDetailsRepo { get; }
        ITestRepositaries testRepositaries { get; }
        Task save();
    }
}
