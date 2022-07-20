namespace CSGregs.Models
{
    public class Car
    {
        
         public int Id { get; set; }
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