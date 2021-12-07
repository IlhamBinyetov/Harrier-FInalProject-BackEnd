﻿using HarrierFinalProject.Data.Models;
using HarrierFinalProject.Data.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HarrierFinalProject.Data.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime DateOfProduct { get; set; }
        public string MotorPower { get; set; }
        public int HorsePower { get; set; }

        public string Mileage { get; set; }
        public decimal Price { get; set; }
        public int DoorCount { get; set; }
        public int CarSituationId { get; set; }




        public int CarColorId { get; set; }
        public CarColor CarColor { get; set; }
        public int BrandId { get; set; }
        public Brand Brand { get; set; }
        public int ModelId { get; set; }
        public Model Model { get; set; }
        public int FuelTypeId { get; set; }
        public FuelType FuelType { get; set; }
        public int TransmissionId { get; set; }
        public Transmission Transmission { get; set; }
        public int GearboxId { get; set; }
        public Gearbox Gearbox { get; set; }
        public int CityId { get; set; }
        public City City { get; set; }
        public int CarTypeId { get; set; }
        public CarType CarType { get; set; }
        public List<CarImage> CarImages { get; set; }
        public List<CarFeature> CarFeatures { get; set; }
        public int CarStatusId { get; set; }
        public CarStatus CarStatus { get; set; }
        public ICollection<Basket> Baskets { get; set; }
        

       
        public List<Comment> Comments { get; set; }

        


    }
}
