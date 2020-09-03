using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1
{
    class DeliveryMen
    {
        public string name { get; set; }
        public string mail { get; set; }
        public string telephone { get; set; }
        public List<Distribution> distributionList;
        public DeliveryMen()
        {
            distributionList = new List<Distribution>();

        }


    }
}
