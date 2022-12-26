using System.ComponentModel.DataAnnotations;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите размер массива!");
        int size = Convert.ToInt32(Console.ReadLine());
        string[] array = new string[size];
        int lenght = array.Length;
        int newSize = 0;
        int j = 0;

        for (int i = 0; i < size; i++)
        {
            Console.WriteLine("Введите элемент массива");
            string x = Convert.ToString(Console.ReadLine());
            array[i] = array[i] + x;
            if (array[i].Length <= 3)
            {
                newSize++;
            }

            Console.WriteLine();
        }

        string[] newArr = new string[newSize];
        Console.WriteLine("Ваш введенный массив!");
        PrintArray(array);
        for (int i = 0; i < size; i++)
        {
            if (array[i].Length <= 3)
            {
                newArr[j] = array[i];
                j++;
            }
        }
        Console.WriteLine();
        Console.WriteLine("Ваш новый массив, где длина строки меньше или ровна 3м символам!");
        PrintArray(newArr);
    }

    //Methods
    static void PrintArray(string[] array)
    //Двумерный массивб вывод
    {
        int lenght = array.Length;
        for (int i = 0; i < lenght; i++)
        {
            Console.Write(array[i]);
            Console.Write(", ");
        }
    }
}