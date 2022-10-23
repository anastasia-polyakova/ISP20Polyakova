using Vtitbid.ISP20.Polyakova.Route.sln;
public class Program
{
    static void Main(string[] args)
    {
        Route[] array = new Route[Route.CreatingLengthArray()];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Route.CreateRoute();
        }
        Route.Sorting(ref array);
        Console.WriteLine(Route.Search(ref array));
        Console.WriteLine(Route.ArrayOutput(array));
    }


}




