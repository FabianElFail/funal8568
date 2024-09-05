internal class Program
{
    private static void Main(string[] args)
    {

        Random r = new Random();
        int num = r.Next(1, 6 + 1);

        if (num == 1)
        {
            Console.WriteLine("Perdio");

        }
        else if (num == 2)
        {
            Console.WriteLine("Poco");
        }
        else
        {
            Console.WriteLine("Algo");
        }
        switch (num)
        {
            case 4:
            case 5:
                Console.WriteLine("es 4 o 5");
                break;
            default:
                Console.WriteLine("Otro");
                break;

        }

        string resp = num > 3 ? "Ganador" : "Perdedor";
        Console.WriteLine(resp);
    }
}