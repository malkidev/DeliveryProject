using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
   public class DeliveryMen
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }
        public string name { get; set; }
        public string mail { get; set; }
        public string telephone { get; set; }

        private ICollection<Distribution> distributionList;
        public virtual ICollection<Distribution> DistributionList
        {
            get { return distributionList; }
            set { distributionList = value; }
        }


        public DeliveryMen(int id, string name, string mail, string telephone, List<Distribution> distributionList1)
        {
            this.ID = id;
            this.name = name;
            this.mail = mail;
            this.telephone = telephone;
            this.distributionList = distributionList1;
            
        }
        public DeliveryMen()
        {
            DistributionList = new List<Distribution>();

        }


    }
}
