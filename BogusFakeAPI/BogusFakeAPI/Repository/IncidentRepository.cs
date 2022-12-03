using Bogus;
using BogusFakeAPI.Models;

namespace BogusFakeAPI.Repository
{
    public class IncidentRepository : IIncidentRepository
    {
        public IEnumerable<Incident> GetAllIncident()
        {
            return FakeData().Generate(10);
        }

        private Faker<Incident> FakeData()
        {
            var fakeContact = new Faker<Contact>()
                .RuleFor(i => i.Id, i => Guid.NewGuid())
                .RuleFor(i => i.FirstName, i => i.Name.FirstName())
                .RuleFor(i => i.LastName, i => i.Name.LastName())
                .RuleFor(i => i.EmailAddress, (f, u) => f.Internet.Email(u.FirstName, u.LastName))
                .RuleFor(i => i.PhoneNumber, i => i.Phone.PhoneNumber());

            var fakeIncident = new Faker<Incident>()
                .RuleFor(i => i.Id, i => Guid.NewGuid())
                .RuleFor(i => i.Description, i => i.Lorem.Paragraph(3))
                .RuleFor(i => i.ReportedOn, i => i.Date.Between(new DateTime(2000, 01, 01), new DateTime(2020, 12, 30)))
                .RuleFor(i => i.ReportedBy, i => fakeContact.Generate());

            return fakeIncident;
        }
    }
}
