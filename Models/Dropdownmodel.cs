using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webappPolutionIndex.model
{
    public class Dropdownmodel
    {
        
            public List<places> Placelist { get; set; }
           // public List<Customer_list> custlist { get; set; }
           
        

        public class places
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }

        public class Customer_list
        {
            public int custId { get; set; }
            public string custName { get; set; }
        }
    }

}
