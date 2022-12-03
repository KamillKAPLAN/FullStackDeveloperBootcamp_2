using BogusFakeAPI.Models;

namespace BogusFakeAPI.Repository
{
    public interface IIncidentRepository
    {
        IEnumerable<Incident> GetAllIncident();
    }
}
