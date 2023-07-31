public class program
{
    static void Main(string[] args)
    {
        int[] arr = new int[5];
        int i;

        Console.WriteLine("enter the numbers");
        for (i = 0; i < arr.Length; i++)
        {
            Console.Write("Element[" + (i + 1) + "]:");
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("List of odd  numbers : ");
        for (i = 0; i < arr.Length; i++)
        {
            if (arr[i] % 2 != 0)
                Console.Write(arr[i] + " ");

            //else
            //{
            //    Console.WriteLine("there is no odd no");
            //}
        }
        Console.WriteLine(" ");
    }
}
