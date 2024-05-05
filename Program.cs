namespace task3;

class Program
{

    public static List<int> PrimeNumbers(int start, int end) {

        List<int> numbers = new ();

        for (int i = start; i <= end; i++) {

            if ((i % 2 != 0) && (i % 3 != 0) && (i % 5 != 0) && (i % 7 != 0 )) {

                numbers.Add (i);

            }

        }

        return numbers;
    }

    static void Main(string[] args)
    {
        int start;
        int end;

        while (true)
        {
            Console.Write("Write start array: ");
            var input_start = Console.ReadLine();

            Console.Write("Write end array: ");
            var input_end = Console.ReadLine();

            if (int.TryParse(input_start, out start) && int.TryParse(input_end, out end) && (start < end))
                break;
            else
            {
                Console.WriteLine("Invalid input");
            }
        }

        List<int> numbers = PrimeNumbers(start, end);

        Console.Write("Prime numbers: ");

        foreach (var item in numbers)
        {
            Console.Write(item + " ");
        }
    }
}
