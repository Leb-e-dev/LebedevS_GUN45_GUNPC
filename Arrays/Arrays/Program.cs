

namespace HomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] fibonacci = { 0, 1, 1, 2, 3, 5, 8, 13 };

            string[] months = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };

            int[,] matrix = {
                { 2, 3, 4 },
                { 4, 9, 16 },
                { 8, 27, 64 }
            };

            double[][] jagged = {
                new double[] { 1, 2, 3, 4, 5 },
                new double[] { Math.E, Math.PI },
                new double[] { Math.Log10(1), Math.Log10(10), Math.Log10(100), Math.Log10(1000) }
            };

            int[] array = { 1, 2, 3, 4, 5 };
            int[] array2 = { 7, 8, 9, 10, 11, 12, 13 };
            var result = CopyArrays(array, array2, 3);

            Console.WriteLine(string.Join(" ", result));

            string[] sample = { "", "" };
            ResizeArray(ref array, array.Length * 2);

            Console.WriteLine(string.Join(" ", array));
        }

        static int[] CopyArrays(int[] source, int[] destination, int count)
        {
            Array.Copy(source, 0, destination, 0, count);
            return destination;
        }

        static void ResizeArray(ref int[] sourceArray, int newSize)
        {
            Array.Resize(ref sourceArray, newSize);
        }
    }
}
