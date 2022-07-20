using System.Collections.Generic;

using CSGregs.Models;
using CSGregsAuth.Repositories;

namespace CSGregs.Services

{
    public class CarsService
    {

        private readonly CarsRepository _repo;


        public CarsService(CarsRepository repo)
        {
            _repo = repo;
        }

        internal List<Car> Get()
        {
            return _repo.Get();
        }

        // internal Car Get(string id)
        // {
        //     Car found = FakeDb.Cars.Find(car => car.Id == id);
        //     if (found == null)
        //     {
        //         throw new Exception("Invalid Id");
        //     }
        //     return found;
        // }

        internal Car Create(Car carData)
        {
            return _repo.Create(carData);
        }

        // internal Car Edit(Car carData)
        // {
        //     Car original = Get(carData.Id);
        //     original.Make = carData.Make ?? original.Make;
        //     original.Model = carData.Model ?? original.Model;
        //     original.ImgUrl = carData.ImgUrl ?? original.ImgUrl;
        //     if (carData.Year != 0)
        //     {
        //         original.Year = carData.Year;
        //     }
        //     if (carData.Price != 0)
        //     {
        //         original.Price = carData.Price;
        //     }
        //     original.Description = carData.Description ?? original.Description;
        //     original.Color = carData.Color ?? original.Color;
        //     return original;
        // }

        // internal Car Delete(string id)
        // {
        //     Car found = Get(id);
        //     FakeDb.Cars.Remove(found);
        //     return found;
        // }
    }
}