using System.ComponentModel.DataAnnotations;

namespace shoestore.Models
{
  public class Shoe
  {
    public string Brand { get; set; }

    public float Size { get; set; }

    public int Quantity { get; set; }

    public float Price { get; set; }

    // DONT NEED A CONSTRUCTOR!

    // public Shoe(string brand, float size, int quantity, float price)
    // {
    //   Brand = brand;
    //   Size = size;
    //   Quantity = quantity;
    //   Price = price;
    // }
  }
}
