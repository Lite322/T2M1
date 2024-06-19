using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2M1.DB
{
    public class Address
    {
        [Key]
        public int Addressid {  get; set; }
        public string City {  get; set; } //Можно вынести
        public string Street { get; set; } //Можно вынести
        public int HouseNumber { get; set; } //Можно вынести
        public int FlatNumber {  get; set; }
    }
}
