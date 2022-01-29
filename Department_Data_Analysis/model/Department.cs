using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Department_Data_Analysis.model
{
    class Department
    {
        public string Code { get; set; }
        public List<int> MunicipalitiesCode { get; set; }
        public string Name { get; set; }
        public List<string> Municipalities { get; set; }
        public List<string> MunicipalitiesType { get; set; }

        public Department(string Code, List<int> MunicipalitiesCode, string Name, List<string> Municipalities, List<string> MunicipalitiesType) 
        {
            this.Code = Code;
            this.MunicipalitiesCode = MunicipalitiesCode;
            this.Name = Name;
            this.Municipalities = Municipalities;
            this.MunicipalitiesType = MunicipalitiesType;
        }
    }
}
