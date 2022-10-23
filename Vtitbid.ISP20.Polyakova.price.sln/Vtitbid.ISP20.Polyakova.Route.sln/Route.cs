namespace Vtitbid.ISP20.Polyakova.Route.sln
{
    public class Route
    {
        private int _routNumber = 0;
        private string _startingPointName = String.Empty;
        private string _endingPointName = String.Empty;

        public string StartingPointName
        {
            get
            {
                return _startingPointName;
            }
            set
            {

                if (!String.IsNullOrEmpty(value) && !String.IsNullOrWhiteSpace(value))
                {
                    _startingPointName = value;
                }
                else
                {

                    Console.WriteLine("Не введено название начальной точки пути");
                    Environment.Exit(0);

                }

            }

        }
        public string EndingPointName
        {
            get
            {
                return _endingPointName;
            }
            set
            {
                if (!String.IsNullOrEmpty(value) && !String.IsNullOrWhiteSpace(value))
                {
                    _endingPointName = value;
                }
                else
                {
                    Console.WriteLine("Не введено название конечной точки пути");
                    Environment.Exit(0);
                }
            }
        }
        public int RoutNumber
        {
            get
            {
                return _routNumber;
            }
            set
            {
                if (value > 0)
                {
                    _routNumber = value;
                }
                else
                {
                    Console.WriteLine("Номер Пути не может быть отрицательным");
                    Environment.Exit(0);
                }
            }
        }
        public Route(int routNumber, string startingPointName, string endingPointName)
        {
            RoutNumber = routNumber;
            StartingPointName = startingPointName;
            EndingPointName = endingPointName;
        }
        public static Route CreateRoute()
        {
            Console.WriteLine("\nВведите здесь номер маршрута");
            int routNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите здесь название начального пункта маршрута");
            string beginRoute = Console.ReadLine();

            Console.WriteLine("Введите здесь название конечного пункта маршрута");
            string endRoute = Console.ReadLine();
            return new Route(routNumber, beginRoute, endRoute);

        }

        public static string ArrayOutput(Route[] array)
        {
            string output = "\nСписок маршрутов:";
            for (int i = 0; i < array.Length; i++)
            {

                output += $"\n{"Номер маршрута:"} {array[i].RoutNumber} {"Название начального пункта маршрута:"} {array[i].StartingPointName} {"Название конечного пункта маршрута:"} {array[i].EndingPointName}";

            }
            return output;
        }
        public static void Sorting(ref Route[] array)
        {
            Route newarr;
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i].RoutNumber > array[j].RoutNumber)
                    {
                        newarr = array[i];
                        array[i] = array[j];
                        array[j] = newarr;
                    }

                }

            }

        }

        public static int CreatingLengthArray()
        {
            Console.Write("Введите количество маршрутов: ");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num > 0)
            {
                return num;
            }
            else
            {
                num = 0;
                Console.WriteLine("Количество маршрутов должно быть больше 0");
                Environment.Exit(0);
            }
            return num;

        }

        public static string Search(ref Route[] array)
        {
            Console.Write("\nВведите номер маршрута, который необходимо найти: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int j = 0;
            string str = "\nСписко маршрутов с указанным номером: ";
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].RoutNumber == num)
                {
                    str += $"\n{"Номер маршрута: "}{array[i].RoutNumber} {"Название начального пункта маршрута: "}{array[i].StartingPointName} {"Название конечного пункта маршрута: "}{array[i].EndingPointName} ";
                    j++;
                }
            }
            if (j == 0)
            {
                str = "Маршрут с таким номером отсутствует!";
                Console.WriteLine("Маршрут с таким номером отсутствует!");
                Environment.Exit(0);

            }
            return str;
        }
    }

}

