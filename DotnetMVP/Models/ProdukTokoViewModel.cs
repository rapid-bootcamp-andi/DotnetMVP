namespace DotnetMVP.Models;
public class ProdukTokoViewModel
{
    public int Id { get; set; }
    public String Name { get; set; }
    public String Category { get; set; }
    public int Value { get; set; }
    public int Price { get; set; }

    public ProdukTokoViewModel()
    {
    }

    public ProdukTokoViewModel(int id, string name, string category, int value, int price)
    {
        Id = id;
        Name = name;
        Category = category;
        Value = value;
        Price = price;
    }
}