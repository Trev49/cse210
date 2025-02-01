
public class Entry
{
    public string Prompt;
    public string Response;
    public DateTime Date;

    public Entry(string prompt, string response)
    {
        Prompt = prompt;
        Response = response;
        Date = DateTime.Now;
    }


}
