namespace DotnetMVP.Models;
public class TokoGameViewModel
{
    public int Id { get; set; }
    public String Nama { get; set; }
    public String Genre { get; set; }
    public int Jumlah { get; set; }
    public int Tahun { get; set; }
    public int Harga { get; set; }

    public TokoGameViewModel()
    {
    }

    public TokoGameViewModel(int id, string nama, string genre, int jumlah, int tahun, int harga)
    {
        Id = id;
        Nama = nama;
        Genre = genre;
        Jumlah = jumlah;
        Tahun = tahun;
        Harga = harga;
    }
}