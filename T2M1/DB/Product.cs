using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2M1.DB
{
    public class Product
    {
        [Key]
        public int ArticleId { get; set; }
        public string ProductName { get; set; }
        public string ProductCategory { get; set; } //Можно вынести
        public float ProductCost { get; set; }
        public string PictPath { get; set; }
        public string UnitOfMeasurement { get; set; }
        public DateTime DateOfManufacture {  get; set; }
        public DateTime ExpirationDate {  get; set; }
        public string Firma {  get; set; } //можно вынести
        public string CountryOfOrigin { get; set; } //Можно вынести
    }
}

//Товар Product
// артикул
// имя
// категория
// цена
// картинка(не обязательно)
// еденица измерения
// дата изготовления
// срок годности
// фирма
// страна производителя
