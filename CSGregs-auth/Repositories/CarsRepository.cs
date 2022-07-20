using System.Collections.Generic;
using System.Data;
using System.Linq;
using CSGregs.Models;
using Dapper;

namespace CSGregsAuth.Repositories
{
    public class CarsRepository
    {
        private readonly IDbConnection _db;

        public CarsRepository(IDbConnection db)
        {
            _db = db;
        }

        internal List<Car> Get()
        {
            string sql = "SELECT * FROM cars";
            return _db.Query<Car>(sql).ToList();
        }

        internal Car Create(Car carData)
        {
            string sql = @"
            INSERT INTO cars
            (id, make, model, imgUrl, year, price, description, color)
            VALUES
            (@Id, @Make, @Model, @ImgUrl, @Year, @Price, @Description, @Color);
            SELECT LAST_INSERT_ID();
            ";

            int id = _db.ExecuteScalar<int>(sql, carData);
            carData.Id = id;
            return carData;

        }
    }
}