using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2M1.DB
{
    public class Products_list
    {
        [Key]
        public int ProductsListId { get; set; }
        public int ArticleId { get; set; }
        public Product Product { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; }
        public int ProductCount { get; set; }
    }
}

//Лист товаров Products list
// артикул
// id заказа
// кол-во