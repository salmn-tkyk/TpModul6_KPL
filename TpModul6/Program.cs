using TpModul6;

class Program
{
    static void Main(string[] args)
    {
        SayaTubeVideo video = new SayaTubeVideo("Tutorial Design By Contract Salman");

        video.IncreasePlayCount(100);
        video.PrintVideoDetails();

        Console.WriteLine("\n--- Menguji Overflow ---");
        try
        {
            for (int i = 0; i < 220; i++)
            {
                video.IncreasePlayCount(10000000);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

        video.PrintVideoDetails();
    }
}
