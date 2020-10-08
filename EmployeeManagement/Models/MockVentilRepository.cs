using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public class MockVentilRepository : IVentilRepository
    {
        private List<Ventil> _ventilList;

        public MockVentilRepository()
        {
            _ventilList = new List<Ventil>()
            {
                new Ventil() {Id = 1, Name = "V1", IsActive = true},
                new Ventil() {Id = 2, Name = "V2", IsActive = false},
                new Ventil() {Id = 3, Name = "V3", IsActive = true}
            };
        }

        public IEnumerable<Ventil> GetAllVentil()
        {
            return _ventilList;
        }

        public Ventil GetVentil(int id)
        {
            return _ventilList.FirstOrDefault(v => v.Id == id);
        }
    }
}
