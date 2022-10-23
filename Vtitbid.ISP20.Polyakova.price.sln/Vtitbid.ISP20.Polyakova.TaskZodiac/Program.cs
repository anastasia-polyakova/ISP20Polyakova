namespace Vtitbid.ISP20.Polyakova.TaskZodiac
{
    public class Program
    {
        static void Main(string[] args)
        {
            Zodiac[] zodiacs = Zodiac.GetZodiacArray();
            foreach (Zodiac zodiac in zodiacs)
            {
                Console.WriteLine(zodiac);
            }
        }
    }
}
