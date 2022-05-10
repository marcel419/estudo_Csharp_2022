﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevCars.API.Entidades
{
    public class Car
    {
        public Car(int id, string vinCode, string brand, string model, int year, decimal price, string color, DateTime productionDate)
        {
            Id = id;
            VinCode = vinCode;
            Brand = brand;
            Model = model;
            Year = year;
            Price = price;
            Color = color;
            ProductionDate = productionDate;

            Status = CarStatusEnum.Available;
            RegisteredAt = DateTime.Now;
        }

        public int Id { get; set; }
        public string VinCode { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }
        public string Color { get; set; }
        public DateTime ProductionDate { get; set; }

        public CarStatusEnum Status { get; set; }
        public DateTime RegisteredAt { get; set; }
    }
}
