using BE;
using System.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Data.Entity.Migrations;

namespace DAL
{
    public class DALimp
    {
        DALContext data = new DALContext();

        public DALimp() { }

        public async Task AddClient(Client Client1)
        {
            using (var db = new DALContext())
            {
                bool isexisting = false;
                foreach (var item in db.ClientList)
                {
                    if (item.ID == Client1.ID)
                        isexisting = true;
                }
                if (Client1 == null && isexisting == true)
                    throw new Exception("the client that you want to add is empty or already existing");
                bool problem = true;
                if ((Client1.telephone.Substring(0, 1) == "0" || Client1.telephone.Substring(0, 1) == "+" || Client1.telephone.Substring(0, 1) == "*") && (Client1.telephone.Length == 10 || Client1.telephone.Length == 13 || Client1.telephone.Length == 5))
                    problem = false;
                if (problem)
                    throw new Exception("You can't add a client without an valid phone number");

                if (Client1.mail.Contains("@") == false)
                    throw new Exception("You can't add a client without an valid email address");


                db.ClientList.Add(Client1);
                await db.SaveChangesAsync();
            }

        }
        public async Task updateClient(Client Client1)
        {
            using (var db = new DALContext())
            {


                if (Client1 == null)
                    throw new Exception("the client that you want to update is empty ");
                bool problem = true;
                if ((Client1.telephone.Substring(0, 1) == "0" || Client1.telephone.Substring(0, 1) == "+" || Client1.telephone.Substring(0, 1) == "*") && (Client1.telephone.Length == 10 || Client1.telephone.Length == 13 || Client1.telephone.Length == 5))
                    problem = false;
                if (problem)
                    throw new Exception("You can't update a client without an valid phone number");

                if (Client1.mail.Contains("@") == false)
                    throw new Exception("You can't update a client without an valid email address");

                bool flag = false;
                foreach (var item in db.ClientList)
                {

                    if (item.ID == Client1.ID)
                    {
                        flag = true;
                    }
                }
                if (flag)
                {
                    db.ClientList.AddOrUpdate(Client1);
                    await db.SaveChangesAsync();
                }

            }
        }
        public async Task removeClient(Client client1)
        {
            if (client1 == null)
                throw new Exception("the client that you want to remove doesn't exist ");
            else
            {
                using (var db = new DALContext())
                {
                    Client a = db.ClientList.Find(client1.ID);
                    db.Entry(a).State = EntityState.Deleted;
                    await db.SaveChangesAsync();
                }
            }
        }

        public void Assignation(Distribution mydist, DeliveryMen mydel)
        {
            using (var db = new DALContext())
            {
                Distribution dist = db.DistributionList.FirstOrDefault(distribution => distribution.ID == mydist.ID);
                if (dist == null)
                {
                    throw new ArgumentNullException("Doesn't exist");
                }

                DeliveryMen del = db.DeliveryMenList.FirstOrDefault(deliverym => deliverym.ID == mydel.ID);
                if (del == null)
                {
                    throw new ArgumentNullException("Doesn't exist");
                }

                del.DistributionList.Add(dist);

                db.SaveChanges();
            }

        }
        public void Assignation2(Client mycl,Distribution mydist)
        {
            using (var db = new DALContext())
            {
                Client client = db.ClientList.FirstOrDefault(clien => clien.ID == mycl.ID);
                if (client == null)
                {
                    throw new ArgumentNullException("Doesn't exist");
                }

                Distribution del = db.DistributionList.FirstOrDefault(dist => dist.ID == mydist.ID);
                if (del == null)
                {
                    throw new ArgumentNullException("Doesn't exist");
                }

                del.ClientList.Add(client);

                db.SaveChanges();
            }

        }

        public async Task AddDeliveryMen(DeliveryMen DeliveryMen1)
        {
            using (var db = new DALContext())
            {
                //    bool isexisting = false;
                //    foreach (var item in db.DeliveryMenList)
                //    {
                //        if (item.ID == DeliveryMen1.ID)
                //            isexisting = true;
                //    }
                //    if (DeliveryMen1 == null && isexisting == true)
                //        throw new Exception("the DeliveryMen that you want to add is empty or already existing");
                //    bool problem = true;
                //    if ((DeliveryMen1.telephone.Substring(0, 1) == "0" || DeliveryMen1.telephone.Substring(0, 1) == "+" || DeliveryMen1.telephone.Substring(0, 1) == "*") && (DeliveryMen1.telephone.Length == 10 || DeliveryMen1.telephone.Length == 13 || DeliveryMen1.telephone.Length == 5))
                //        problem = false;
                //    if (problem)
                //        throw new Exception("You can't add a DeliveryMen without an valid phone number");

                //    if (DeliveryMen1.mail.Contains("@") == false)
                //        throw new Exception("You can't add a DeliveryMen without an valid email address");

                Distribution[] newlist = new Distribution[DeliveryMen1.DistributionList.Count];
           
                DeliveryMen1.DistributionList.CopyTo(newlist,0);
                foreach (var item in newlist)
                { DeliveryMen1.DistributionList.Remove(item); }
                db.DeliveryMenList.Add(DeliveryMen1);
                await db.SaveChangesAsync();

                for (int i = 0; i < newlist.Length; i++)
                {
                    Assignation(newlist[i], DeliveryMen1);
                }            

                await db.SaveChangesAsync();

                           }
        }
        public async Task UpdateDeliveryMen(DeliveryMen DeliveryMen1)
        {
            
            using (var db = new DALContext())
            {
                bool flag = false;
                foreach (var item in db.DeliveryMenList)
                {
                    if (item.ID == DeliveryMen1.ID)
                    {
                        flag = true;
                    }
                }
                if (DeliveryMen1 == null)
                    throw new Exception("the DeliveryMen that you want to update is null");
                bool problem = true;
                if ((DeliveryMen1.telephone.Substring(0, 1) == "0" || DeliveryMen1.telephone.Substring(0, 1) == "+" || DeliveryMen1.telephone.Substring(0, 1) == "*") && (DeliveryMen1.telephone.Length == 10 || DeliveryMen1.telephone.Length == 13 || DeliveryMen1.telephone.Length == 5))
                    problem = false;
                if (problem)
                    throw new Exception("You can't update a DeliveryMen without an valid phone number");

                if (DeliveryMen1.mail.Contains("@") == false)
                    throw new Exception("You can't update a DeliveryMen without an valid email address");




                if (flag)
                {
                    await removeDeliveryMen(DeliveryMen1);
                    await AddDeliveryMen(DeliveryMen1);

                }


            }
    }
        public async Task removeDeliveryMen(DeliveryMen delivery1)
        {
            if (delivery1.DistributionList.Count != 0)
                throw new Exception("this delivery men is already assigned");

            if (delivery1 == null)
                throw new Exception("the delivery men that you want to add doesn't exist ");
            else
            {
                using (var db = new DALContext())
                {
                    DeliveryMen a = await db.DeliveryMenList.FindAsync(delivery1.ID);
                    db.Entry(a).State = EntityState.Deleted;
                    await db.SaveChangesAsync();
                }
            }
        }

        public async Task AddDistribution(Distribution Distribution1)
        {
            using (var db = new DALContext())
            {
                bool isexisting = false;
                foreach (var item in db.DistributionList)
                {
                    if (item.ID == Distribution1.ID)
                        isexisting = true;
                }
                if (Distribution1 == null && isexisting == true)
                    throw new Exception("the DeliveryMen that you want to add is empty or already existing");
              
              
                Client[] newlist = new Client[Distribution1.ClientList.Count];

                Distribution1.ClientList.CopyTo(newlist, 0);
                foreach (var item in newlist)
                    Distribution1.ClientList.Remove(item);
                db.DistributionList.Add(Distribution1);
                await db.SaveChangesAsync();

                for (int i = 0; i < newlist.Length; i++)
                {
                    Assignation2(newlist[i], Distribution1);
                }

                await db.SaveChangesAsync();

            }
        }
        public async Task UpdateDistribution(Distribution Distribution1)
        {

            using (var db = new DALContext())
            {
                bool flag = false;
                foreach (var item in db.DistributionList)
                {
                    if (item.ID == Distribution1.ID)
                    {
                        flag = true;
                    }
                }
                if (Distribution1 == null)
                    throw new Exception("the DeliveryMen that you want to update is null");
                if (flag)
                {
                    await removeDistribution(Distribution1);
                    await AddDistribution(Distribution1);

                }


            }
        }
        public async Task removeDistribution(Distribution Distribution1)
        {
            if (Distribution1.ClientList.Count != 0)
                throw new Exception("this distribution is already assigned");
            if (Distribution1 == null)
                throw new Exception("the distribution does'nt exist ");
            else
            {
                using (var db = new DALContext())
                {
                    Distribution a = await db.DistributionList.FindAsync(Distribution1.ID);
                    db.Entry(a).State = EntityState.Deleted;
                    await db.SaveChangesAsync();
                }
            }
        }

        public ObservableCollection<Client> GetAllClients(Func<Client, bool> filter = null)
        {
            using (var db = new DALContext())
            {
                var list = new ObservableCollection<Client>(db.ClientList
                    .Distinct()
                    .AsNoTracking());
        

                return new ObservableCollection<Client>(list);
            }
        }
        public ObservableCollection<DeliveryMen> GetAllDeliveryMen(Func<DeliveryMen, bool> filter = null)
        {
            using (var db = new DALContext())
            {
                var list = new ObservableCollection<DeliveryMen>(db.DeliveryMenList
                    .Distinct()
                    .AsNoTracking());

                return new ObservableCollection<DeliveryMen>(list);
            }
        }
        public ObservableCollection<Distribution> GetAllDistribution(Func<Distribution, bool> filter = null)
        {
            using (var db = new DALContext())
            {
                var list = new ObservableCollection<Distribution>(db.DistributionList
                    .Distinct()
                    .AsNoTracking());         
                return new ObservableCollection<Distribution>(list);
            }
        }
        public DeliveryMen GetDEL(int id)
        {
            using (var db = new DALContext())
            {
                var list = new ObservableCollection<DeliveryMen>(db.DeliveryMenList
                    .Distinct()
                    .Where(m=>m.ID==id)
                    .AsNoTracking());         
                return list.FirstOrDefault();
            }
        }
    }
}
