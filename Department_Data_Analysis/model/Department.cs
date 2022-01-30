using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Department_Data_Analysis.model
{
    class Department
    {
        public string Name { get; set; }
        public int Code { get; set; }
        public List<string> Municipalities { get; set; }

        public Department(string Name, int Code, List<string> Municipalities) 
        {
            this.Name = Name;  
            this.Code = Code;
            this.Municipalities = Municipalities;

        }
    }
}
