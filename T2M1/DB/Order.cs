using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2M1.DB
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        public int BuyerId { get; set; }
        public Buyer Buyer { get; set; }
        public int EmployeeGUID { get; set; }
        public Employee Employee { get; set; }
        public string Status { get; set; } //Можно вынести
        public int ProductListId { get; set; }
        public Products_list Products { get; set; }
        public DateTime DataSell {  get; set; }
        public string Oplata { get; set; } //Можно вынести
    }
}

//Заказ Order
// id
// id покупателя
// guid сотрудника
// статус
// лист товаров
// дата продажи 
// способ оплаты 