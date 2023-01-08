namespace DotnetMVP.Models;
public class SendEmailViewModel
{
    public int Id { get; set; }
    public String To { get; set; }
    public String Subject { get; set; }
    public String From { get; set; }
    public String Message { get; set; }

    public SendEmailViewModel()
    {
    }

    public SendEmailViewModel(int id, string from, string to, String subject, String message)
    {
        Id = id;
        From = from;
        To = to;
        Subject = subject;
        Message = message;
    }
}