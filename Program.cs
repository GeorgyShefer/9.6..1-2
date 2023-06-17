class Program
{

    static void Main(string[] args)
    {
        Exception[] exceptions = new Exception[5];


        exceptions[0] = new ArgumentOutOfRangeException();

        exceptions[1] = new RankException();

        exceptions[2] = new FormatException();

        exceptions[3] = new DivideByZeroException();

        exceptions[4] = new Exception();

        try
        {
            foreach (Exception exces in exceptions)
            {
                Console.WriteLine(exces);
            }
        }
        catch (Exception)
        {


        }

        string[] lastName = { "Орлов", "Крылов", "Донской", "Миронов", "Жирков" };
        foreach (var name in lastName)
        {
            Console.WriteLine(name + " ");
        }
        Exception ex = new FormatException();
        try
        {
            Console.WriteLine("Выберите сортировку:");
            Console.WriteLine("1: Сортировка от А до Я");
            Console.WriteLine("2: Сортировка от Я до А");
            int toChose = Convert.ToInt32(Console.ReadLine());
            while (true)
            {
                switch (toChose)
                {
                    case 1:
                        Console.WriteLine("Донско, Жирков, Крылов, Миронов, Орлов");
                        break;

                    case 2:
                        Console.WriteLine("Орлов, Миронов, Крылов, Жирков, Донской");
                        break;
                    default:
                        Console.WriteLine(ex);
                        break;

                }
                Console.ReadLine();

            }
        }
        catch (Exception)
        {

            throw;
        }
    }


}