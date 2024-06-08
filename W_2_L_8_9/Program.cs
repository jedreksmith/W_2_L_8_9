namespace W_2_L_8_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Changer of the numbers");

            Console.WriteLine("Give me a number");
            int number = int.Parse(Console.ReadLine());
            
            string wynik = "";

            do
            {   
                if ((number % 2) == 1)
                    wynik =  "1"+ wynik;
                else
                    wynik = "0" + wynik;
                number /= 2;
            }
            while (number != 0);

            Console.WriteLine(wynik);
        }
    }
}
    