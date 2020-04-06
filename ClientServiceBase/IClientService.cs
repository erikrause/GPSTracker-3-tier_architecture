using GPSTracker.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientServiceBase
{
    public interface IClientService
    {
        Task CreateIndividualClient(IndividualClient individualClient, User user);

        Task CreateLegalClient(LegalClient legalClient, User user);

        Task DeleteClient(int id);

        Task<IndividualClient> GetIndividualClient(int id);

        Task<LegalClient> GetLegalClient(int id);

        Task<IEnumerable<IndividualClient>> GetIndividualClients();
        Task<IEnumerable<LegalClient>> GetLegalClients();
        Task UpdateIndividualClient(IndividualClient individualClient);
        Task UpdateLegalClient(LegalClient legalClient);
        Task DeleteIndividualClient(int id);
        Task DeleteLegalClient(int id);


        // prob
        Task<IEnumerable<Client>> GetClients();
    }
}
