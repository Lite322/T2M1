using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2M1.DB
{
    public class Employee
    {
        [Key]
        public int EmployeeGUID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string? Fathername { get; set; }
        public DateTime Birthday { get; set; }
        public string PhoneNumber { get; set; }
        public int AddressId { get; set; }
        public Address Address { get; set; }
    }
}

//Сотрудник Employee
// guid
// фио(отчество не обязательно)
// др
// телефон
// адрес
