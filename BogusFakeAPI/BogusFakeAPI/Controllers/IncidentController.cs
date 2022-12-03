using BogusFakeAPI.Models;
using BogusFakeAPI.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BogusFakeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IncidentController : ControllerBase
    {
        private IIncidentRepository _incidentRepository;

        public IncidentController(IIncidentRepository incidentRepository)
        {
            _incidentRepository = incidentRepository;
        }

        [HttpGet]
        public List<Incident> GetFakeProducts()
        {
            return _incidentRepository.GetAllIncident().ToList();
        }
    }
}
