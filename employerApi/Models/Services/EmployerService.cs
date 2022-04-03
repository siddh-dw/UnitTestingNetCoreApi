using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using unitTesting.models.Services;

namespace unitTesting.Models.Services
{
    public class EmployerService : IEmployerServices
    {
    private List<Employer> _employers = new List<Employer>()
    {
       new Employer(){Id=1, FirtName="Juan", LastName="Ito"},
       new Employer(){Id=2, FirtName ="Jos", LastName="Ito"}
    };
        public IEnumerable<Employer> Get()=>_employers;

        public Employer? Get(int id) => _employers.FirstOrDefault(x => x.Id == id);
    }
}