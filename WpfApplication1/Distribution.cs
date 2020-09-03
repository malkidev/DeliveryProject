using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1
{
    class Distribution
    {
        DateTime date { get; set; }
        bool isDone { get; set; }
        public  List<DeliveryMen> clientList { get; set; }
        public Distribution()
        {
            clientList = new List<DeliveryMen>();
            
        }
    }
}
