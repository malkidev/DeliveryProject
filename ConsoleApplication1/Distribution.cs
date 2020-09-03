using ConsoleApplication1;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
  public class Distribution
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }
        public  DateTime date { get; set; }
        public bool isDone { get; set; }

        private ICollection<Client> clientList;
        public virtual ICollection<Client> ClientList
        {
            get { return clientList; }
            set { clientList = value; }
        }
       
        public Distribution(int id, DateTime date, bool isDone, List<Client> clientList)
        {

            this.ID = id;
            this.date = date;
            this.isDone = isDone;
            this.clientList = clientList;
        }
        public Distribution()
        {
            clientList = new List<Client>();
            date = new DateTime();
        }
    }
}
