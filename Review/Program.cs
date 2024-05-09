class New
{

    static void myNewMethod(string name, string fname)
    {
        Console.WriteLine(name + " " + fname);

    }


    static int[] array1()
    {
        int[] arr = { 4, 1, 3, 4 };
        return arr;

    }

    static decimal[,] nesarr()
    {
        decimal[,] arr = { { 1, 6, 9, 5 }, { 5, 9, 5, 2 } };
        return arr;
    }


    public static void Main()
    {
        Console.WriteLine("Hello, World!");
        int new1 = 2;
        Console.WriteLine(new1);
        myNewMethod("noman", "Shafaat");
        int[] array2 = array1();
        Array.Sort(array2);
        Console.WriteLine(array2.Max());

        decimal[,] newarr = nesarr();

        int rows = newarr.GetLength(0);
        int cols = newarr.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(newarr[i, j] + " ");
            }
            Console.WriteLine();
        }


    }
}
