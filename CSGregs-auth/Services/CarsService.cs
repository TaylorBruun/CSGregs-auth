using System;
using System.Collections.Generic;
using CSGregs.db;
using CSGregs.Models;

namespace CSGregs.Services

{
    public class CarsService
    {
        internal List<Car> Get()
        {
            return FakeDb.Cars;
        }

        internal Car Get(string id)
        {
            Car found = FakeDb.Cars.Find(car => car.Id == id);
            if (found == null)
            {
                throw new Exception("Invalid Id");
            }
            return found;
        }

        internal Car Create(Car carData)
        {
            FakeDb.Cars.Add(carData);
            return carData;
        }

        internal Car Edit(Car carData)
        {
            Car original = Get(carData.Id);
            original.Make = carData.Make ?? original.Make;
            original.Model = carData.Model ?? original.Model;
            original.ImgUrl = carData.ImgUrl ?? original.ImgUrl;
            if (carData.Year != 0)
            {
                original.Year = carData.Year;
            } 
            if (carData.Price != 0)
            {
                original.Price = carData.Price;
            }
            original.Description = carData.Description ?? original.Description;
            original.Color = carData.Color ?? original.Color;
            return original;
        }

        internal Car Delete(string id)
        {
            Car found = Get(id);
            FakeDb.Cars.Remove(found);
            return found;
        }
    }
}