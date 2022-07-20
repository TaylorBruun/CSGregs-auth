// using System;
// using System.Collections.Generic;

// using CSGregs.Models;

// namespace CSGregs.Services

// {
//     public class HousesService
//     {
//         internal List<House> Get()
//         {
//             return FakeDb.Houses;
//         }

//         internal House Get(string id)
//         {
//             House found = FakeDb.Houses.Find(house => house.Id == id);
//             if (found == null)
//             {
//                 throw new Exception("Invalid Id");
//             }
//             return found;
//         }

//         internal House Create(House houseData)
//         {
//             FakeDb.Houses.Add(houseData);
//             return houseData;
//         }

//         internal House Edit(House houseData)
//         {
//             House original = Get(houseData.Id);
            
//             if (houseData.Bedrooms != 0)
//             {
//                 original.Bedrooms = houseData.Bedrooms;
//             } 
//             if (houseData.Bathrooms != 0)
//             {
//                 original.Bathrooms = houseData.Bathrooms;
//             } 
//             if (houseData.Levels != 0)
//             {
//                 original.Levels = houseData.Levels;
//             } 
//             original.ImgUrl = houseData.ImgUrl ?? original.ImgUrl;

//             if (houseData.Year != 0)
//             {
//                 original.Year = houseData.Year;
//             } 
//             if (houseData.Price != 0)
//             {
//                 original.Price = houseData.Price;
//             }
//             original.Description = houseData.Description ?? original.Description;
//             return original;
//         }

//         internal House Delete(string id)
//         {
//             House found = Get(id);
//             FakeDb.Houses.Remove(found);
//             return found;
//         }
//     }
// }