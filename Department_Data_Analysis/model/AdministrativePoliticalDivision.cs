using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Department_Data_Analysis.model
{
    class AdministrativePoliticalDivision
    {
        public List<Department> departmentList { get; set; }
        public List<Municipality> municipalityList { get; set;  }

        public AdministrativePoliticalDivision(Department department, Municipality municipality)
        {
            departmentList.Add(department);
            municipalityList.Add(municipality);
        }
    }
}
