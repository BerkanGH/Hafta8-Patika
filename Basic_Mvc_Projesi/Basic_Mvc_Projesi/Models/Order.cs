﻿namespace Basic_Mvc_Projesi.Models
{
    public class Order
    {
        public int Id { get; set; }           // Siparişin  kimliği
        public string ProductName { get; set; } // Ürünün adı
        public decimal Price { get; set; }     // Ürünün fiyatı
        public int Quantity { get; set; }      // Sipariş edilen ürün miktarı
    }
}