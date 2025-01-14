namespace MyCustomList;

public class Program
{
    static void Main(string[] args)
    {
        MyList List = new MyList(4);
        List.Add(14);
        /*List.Veiwer();
        List.Add(14);
        Console.WriteLine();
        List.Veiwer();
        Console.WriteLine();
        List.Add(17);
        Console.WriteLine();
        List.Add(28);
        List.Add(32);*/
        int[] mass = { 1, 7, 115 };
        List.Veiwer();
        Console.WriteLine();
        Console.WriteLine(List.Count);
        Console.WriteLine(List.Capacity);
        Console.WriteLine();
        List.Add(mass); /* Метод Add(int[] elements)*/
        List.Veiwer();
        Console.WriteLine();
        Console.WriteLine(List.Count);
        Console.WriteLine(List.Capacity);
        Console.WriteLine();

        List.Add(3, 55); /* Метод Add(int index, int element)*/
        List.Veiwer();
        Console.WriteLine();
        Console.WriteLine(List.Count);
        Console.WriteLine(List.Capacity);
        Console.WriteLine();

        int[] mass2 = { 96, 248, 715 };
        List.Add(4, mass2);  /* Метод Add(int index, int[] elements)*/
        List.Veiwer();
        Console.WriteLine();
        Console.WriteLine(List.Count);
        Console.WriteLine(List.Capacity);
        Console.ReadKey();
        Console.ReadKey();
    }
}


