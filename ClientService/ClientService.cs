using ClientServiceBase;
using GPSTracker.DAL.Entities;
using GPSTracker.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientServiceImplementation
{
    public class ClientService : IClientService
    {
        IRepository Repo;
        public ClientService(IRepository repo)
        {
            Repo = repo;
        }
        public async Task CreateIndividualClient(IndividualClient individualClient, User user)
        {
            await Repo.Save(individualClient);
            Client client = new Client { IndividualClient = individualClient };
            await Repo.Save(client);
            user.Client = client;
            await Repo.Update(user);
        }

        public async Task CreateLegalClient(LegalClient legalClient, User user)
        {
            await Repo.Save(legalClient);
            Client client = new Client { LegalClient = legalClient };
            await Repo.Save(client);
            user.Client = client;
            await Repo.Update(user);
        }

        public async Task DeleteClient(int id)
        {
            var client = await Repo.Get<Client>(id);
            await Repo.Remove(client);
            if (client.IndividualClient != null)
            {
                await Repo.Remove(client.IndividualClient);
            }
            else await Repo.Remove(client.LegalClient);
        }

        public async Task DeleteIndividualClient(int id)
        {
            var individualClient = await Repo.Get<IndividualClient>(id);
            await Repo.Remove(individualClient);

            var client = (await Repo.GetBy<Client>(x => x.IndividualClientId == individualClient.Id)).FirstOrDefault();
            await Repo.Remove(client);
        }

        public async Task DeleteLegalClient(int id)
        {
            var legalClient = await Repo.Get<IndividualClient>(id);
            await Repo.Remove(legalClient);

            var client = (await Repo.GetBy<Client>(x => x.LegalClientId == legalClient.Id)).FirstOrDefault();
            await Repo.Remove(client);
        }

        public async Task<IEnumerable<Client>> GetClients()
        {
            return await Repo.GetAll<Client>();
        }

        public async Task<IndividualClient> GetIndividualClient(int id)
        {
            return await Repo.Get<IndividualClient>(id);
        }

        public async Task<IEnumerable<IndividualClient>> GetIndividualClients()
        {
            return await Repo.GetAll<IndividualClient>();
        }

        public async Task<LegalClient> GetLegalClient(int id)
        {
            return await Repo.Get<LegalClient>(id);
        }

        public async Task<IEnumerable<LegalClient>> GetLegalClients()
        {
            return await Repo.GetAll<LegalClient>();
        }
        public async Task UpdateIndividualClient(IndividualClient individualClient)
        {
            await Repo.Update(individualClient);
        }

        public async Task UpdateLegalClient(LegalClient legalClient)
        {
            await Repo.Update(legalClient);
        }
    }
}
