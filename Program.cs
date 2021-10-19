using System;
public class Program

{
    public static void Main()

    {
        //number list to sort 
        Console.WriteLine("Enter number 1:");
        int num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter number 2:");
        int num2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter number 3:");
        int num3 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter number 4:");
        int num4 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter number 5:");
        int num5 = int.Parse(Console.ReadLine());

        //data to be sorted 
        int[] data = new int[5] { num1, num2, num3, num4, num5 };
        int size = data.Length;
        int hole = 0;
        int insertValue = 0;
        int temp;

        //for each element in array 
        for (int index = 0; index < size; index++)
        {

            insertValue = data[index];
            hole = index;
            //move numbers into position 

            while (hole > 0 && data[hole - 1] > insertValue)
            {

                temp = data[hole];
                data[hole] = data[hole - 1];
                data[hole - 1] = temp;
                hole--;

            }
        }

        //output  
        foreach (int number in data)
        {
            //and print it out 
            Console.WriteLine(number);

        }

    }

}