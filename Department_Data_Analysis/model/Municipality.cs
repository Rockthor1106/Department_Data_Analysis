using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Department_Data_Analysis.model
{
    class Municipality
    {
        private string Name;
        private int Code;
        private string type;

        public Municipality(string Name, int Code, string type)
        {
            this.Name = Name;
            this.Code = Code;
            this.type = type;
        }
    }
}
