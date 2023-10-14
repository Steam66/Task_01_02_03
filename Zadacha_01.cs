namespace Задача_01_02_03
{

   internal class Zadacha_01
    {
        public void Kvadrat(string? a, int b)
        {
            for (int i = 0; i < b; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    Console.Write(b);
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Укажите из какого символа рисовать квадрат: ");
            string? symb=Console.ReadLine();
            Console.Write("Укажите длину грани квадрата: ");
            int dlina = Convert.ToInt32(Console.ReadLine());
            Kvadrat(symb, dlina);           
        }
   }
}
