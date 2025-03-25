
using System.Collections.Generic; 
using System.Linq;

using System.Threading.Tasks;

namespace appRH.Models

{


    public class Employee
    {


         public string EmployeeName { get; set; }
    
         public string Departement { get; set; }
    
         public bool isActive { get; set; }
        public string JobTitle { get; set; }
        public DateTime BirthDate { get; set; }
        public string EmailAddress { get; set; }
    } 
}