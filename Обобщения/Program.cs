namespace Обобщения
{
    public class Array<T>
    {
        private T[] arr;
        public Array(int n) 
        {
            arr = new T[n];
        }

        public void SetValue(T value, int index)
        {
            arr[index] = value;
        }

        public T GetValue(int index)
        {
            return arr[index];
        }

        public void Remove(T value)
        {
            int index = Array.IndexOf(arr, value);
            arr[index] = default(T);
        }

        public void PrintArr()
        {
            foreach (T value in arr) 
            {
                if (value == null)
                {
                    Console.Write("Ничего ");
                    continue;
                }
                Console.Write(value + " "); 
            }
            Console.WriteLine();
        }

        public int Length { get { return arr.Length; } }

    }
    internal class Program
    {
        static void Main()
        {
            Array<int> array = new Array<int>(5);  // в скобках - длина массива
            array.SetValue(5, 2);
            array.SetValue(4, 3);
            array.SetValue(3, 4);
            array.Remove(3);
            Console.WriteLine($"Значение по индексу 3: {array.GetValue(3)}");
            array.PrintArr();

            Console.WriteLine();

            Array<string> string_array = new Array<string>(5);  // в скобках - длина массива
            string_array.SetValue("пять", 2);
            string_array.SetValue("четыре", 3);
            string_array.SetValue("тэри", 4);
            string_array.Remove("тэри");
            Console.WriteLine($"Значение по индексу 3: {array.GetValue(3)}");
            string_array.PrintArr();
        }
    }
}