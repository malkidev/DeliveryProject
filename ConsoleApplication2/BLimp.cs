using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;
namespace ConsoleApplication2
{
    class BLimp
    {
        DALimp testdal;
        public async Task AddClient(Client client1)
        {
            await testdal.AddClient(client1);
        }

        public async Task UpdateClient(Client client1)
        {
            await testdal.updateClient(client1);
        }

        public async Task RemoveClient(Client client1)
        {
            await testdal.removeClient(client1);
        }
        public async Task AddDistribution(Distribution Distribution1)
        {
            await testdal.AddDistribution(Distribution1);
        }

        public async Task UpdateDistribution(Distribution Distribution1)
        {
            await testdal.UpdateDistribution(Distribution1);
        }

        public async Task RemoveDistribution(Distribution Distribution1)
        {
            await testdal.removeDistribution(Distribution1);
        }

        public async Task AddDeliveryMen(DeliveryMen DeliveryMen1)
        {
            await testdal.AddDeliveryMen(DeliveryMen1);
        }

        public async Task UpdateShop(DeliveryMen DeliveryMen1)
        {
            await testdal.UpdateDeliveryMen(DeliveryMen1);
        }

        public async Task RemoveDeliveryMen(DeliveryMen DeliveryMen1)
        {
            await testdal.removeDeliveryMen(DeliveryMen1);
        }
    }
}

