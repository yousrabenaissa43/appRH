
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

using System.Threading.Tasks;

namespace appRH.Models

{


    public class Employee
    {

        public string Id { get; set; }
        [Required(ErrorMessage ="Name is missing")]
        [StringLength(6,MinimumLength =3, ErrorMessage = "Invalid Name")]
         public string EmployeeName { get; set; }
        [Required(ErrorMessage = "Departement is missing")]
        public string Departement { get; set; }
    
         public bool isActive { get; set; }

        [Required(ErrorMessage = "Job title is missing")]
        [DataType(DataType.Text)]
        public string JobTitle { get; set; }

        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }

        [DataType(DataType.EmailAddress)]
        public string EmailAddress { get; set; }
    } 
}