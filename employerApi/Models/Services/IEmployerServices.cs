using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using unitTesting.Models;

namespace unitTesting.models.Services
{
    public interface IEmployerServices
    {
        public IEnumerable<Employer> Get();
        public Employer? Get(int id);
    }
}