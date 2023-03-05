using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MilcanX.Class.DTO
{
    public class Employee
    {
        public string EmployeeID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Title { get; set; }
        public string TitleOfCourtesy { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime HireDate { get; set; }
        public string Address { get; set; } //adress sınıfı olacak??
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string USA { get; set; }
        public string Country { get; set; }     
        public string HomePhone { get; set; }
        public string Extension { get; set; }
        public string Photo { get; set; }        
        public string Notes { get; set; }
        public string ReportsTo { get; set; }
        public string PhotoPath { get; set; }
    }
}
