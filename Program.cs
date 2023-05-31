using System.Net;

string url = "https://v4v6.ipv6-test.com/api/myip.php";

bool i = true;
while (i)
{
    using (WebClient client = new WebClient())
    {
        try
        {
            string response = client.DownloadString(url);
            Console.WriteLine(response);
            i = false;
        }
        catch (Exception ex)
        {
            Console.WriteLine("Chyba při získávání dat: " + ex.Message);
        }
    }
    Console.WriteLine("http request done");
}