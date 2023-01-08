namespace DotnetMVP.Models;
public class DataTamuViewModel
{
    public int Id { get; set; }
    public String Nama { get; set; }
    public String Kota { get; set; }
    public int NoWa { get; set; }
    public int NoTlp { get; set; }

    public DataTamuViewModel()
    {
    }

    public DataTamuViewModel(int id, string nama, string kota, int nowa, int notlp)
    {
        Id = id;
        Nama = nama;
        Kota = kota;
        NoWa = nowa;
        NoTlp = notlp;
    }
}