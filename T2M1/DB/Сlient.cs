using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2M1.DB
{
    public class Сlient : Buyer
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string? Fathername { get; set; }
        public string PhoneNumber { get; set; }
        public string Mail {  get; set; }
    }
}

//Клиент: покупатель Сlient
// фио(отчество не обязательно)
// телефон
// почта