
using System;
using System.ComponentModel.DataAnnotations;

namespace CSGregs.Models
{
    public class Car
    {
        public Car(string make, string model, string imgUrl, int year, int price, string description, string color)
        {
            Id = Guid.NewGuid().ToString(); 
            Make = make;
            Model = model;
            ImgUrl = imgUrl;
            Year = year;
            Price = price;
            Description = description;
            Color = color;

        }
         public string Id { get; set; }
         public string Make { get; set; }
         public string Model { get; set; }
         public string ImgUrl { get; set; }
        //  NOTE flagging these as required is an option, it looks like this
        //  [Required]
         public int Year { get; set; }
         public int Price { get; set; }
         public string Description { get; set; }
         public string Color { get; set; }
    }
}