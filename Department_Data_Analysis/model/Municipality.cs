using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Department_Data_Analysis.model
{
    class Municipality
    {
        public string Name { get; set; }
        public int Code { get; set; }
        public string Type { get; set; }
        public Department Department { get; set; } //The department which this municipality belongs to

        public Municipality(string Name, int Code, string Type, Department Department)
        {
            this.Name = Name;
            this.Code = Code;
            this.Type = Type;
            this.Department = Department;
        }
    }
}
