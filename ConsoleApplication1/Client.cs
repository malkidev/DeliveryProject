using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public enum kindOfNeed { Food, Drugs, Both }
    public  class Client
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }
        public string name { get; set; }
        public string mail { get; set; }
        public string telephone { get; set; }
        public string address { get; set; }
      
         public kindOfNeed mykind { get; set; }
        public Client(string name, string mail, string telephone, string address2,int ID2,kindOfNeed mykind1)
        {
            this.name = name;
            this.mail = mail;
            this.telephone = telephone;
            address = address2;
            ID = ID2;
            mykind = mykind1;

           
        }
        public Client()
        {
            this.name = "default";
            this.mail = "default";
            this.telephone = "default";
            address = "default";
            ID =0;
            mykind = 0;
        }


    }
}
 