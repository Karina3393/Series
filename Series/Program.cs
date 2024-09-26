namespace Series
{
    internal class Program
    {
        static void Main()
        {
       
            Console.WriteLine("Введіть рядок цифр:");
            string input = Console.ReadLine();

           
            Console.WriteLine("Введіть довжину підрядка n:");
            int n = int.Parse(Console.ReadLine());

            if (n > input.Length)
            {
                Console.WriteLine("Підрядки довжиною більше, ніж рядок, неможливо отримати.");
            }
            else
            {
                
                for (int i = 0; i <= input.Length - n; i++)
                {
                    string substring = input.Substring(i, n);
                    Console.WriteLine(substring);
                }
            }
        }
    }
}
