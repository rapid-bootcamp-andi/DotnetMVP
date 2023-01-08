namespace DotnetMVP.Models;
public class DataPerusahaanViewModel
{
    public int Id { get; set; }
    public String Divisi { get; set; }
    public String Leader { get; set; }
    public int PkrWnt { get; set; }
    public int PkrPri { get; set; }

    public DataPerusahaanViewModel()
    {
    }

    public DataPerusahaanViewModel(int id, string divisi, string leader, int pkrwnt, int pkrpri)
    {
        Id = id;
        Divisi = divisi;
        Leader = leader;
        PkrWnt = pkrwnt;
        PkrPri = pkrpri;
    }
}