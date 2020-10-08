using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeManagement.Models;
using EmployeeManagement.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement.Controllers
{
    public class SimulatorController : Controller
    {
        private readonly IVentilRepository _ventilRepository;
        public SimulatorController(IVentilRepository ventilRepository)
        {
            _ventilRepository = ventilRepository;
        }
        public ViewResult ShowVentil()
        {
            var model = _ventilRepository.GetAllVentil();
            return View(model);
        }
        public ViewResult VentilDetails(int? id)
        {
            SimulatorVentilDetailsViewModel simulatorVentilDetailsViewModel = new SimulatorVentilDetailsViewModel()
            {
                Ventil = _ventilRepository.GetVentil(id ?? 1),
                PageTitle = "Ventil Details"
            };
            return View(simulatorVentilDetailsViewModel);
        }
    }
}
