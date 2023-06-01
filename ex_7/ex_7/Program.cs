
 enum Month
{
    Січень = 1,
    Лютий,
    Березень,
    Квітень,
    Травень,
    Червень,
    Липень,
    Серпень,
    Вересень,
    Жовтень,
    Листопад,
    Грудень
}

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        int s = 1; 
        foreach (Month i in Enum.GetValues(typeof(Month)))
        {
            
            Console.WriteLine($"{s}){i.ToString()}");
            s++; 
        }
        Console.Write("Введiть номер мiсяця: ");
        int monthNumber = Convert.ToInt32(Console.ReadLine());

        if (Enum.IsDefined(typeof(Month), monthNumber))
        {
            Month month = (Month)monthNumber;

            switch (month)
            {
                case Month.Травень or Month.Червень or Month.Липень or Month.Серпень or Month.Вересень:
                    Console.WriteLine("тепло");
                    break;
                case Month.Жовтень or Month.Листопад or Month.Березень or Month.Квітень:
                    Console.WriteLine("дощi");
                    break;
                case Month.Грудень or Month.Січень or Month.Лютий:
                    Console.WriteLine("сніг");
                    break;
                default:
                    Console.WriteLine("Погодні умови для місяця {0} не визначені.", month);
                    break;
            }
        }
        else
        {
            Console.WriteLine("Невірний номер місяця.");
        }

    }
}