using System.Collections.Generic;
using CSGregs.Models;

namespace CSGregs.db
{
  public static class FakeDb
  {
    public static List<Car> Cars { get; set; } = new List<Car>(){
            new Car("TestMake", "TestModel", "thiscatdoesnotexist.com", 1970, 550, "this is a description of a test car", "#a03563")
        };
    public static List<House> Houses { get; set; } = new List<House>(){
            new House(7, 4, 1, "thiscatdoesnotexist.com", 1969, 380, "this is a description of a test house")
        };

    // public static List<Job> Jobs { get; set; } = new List<Job>(){
            
    //     };


  }
}