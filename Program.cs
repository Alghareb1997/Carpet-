namespace FirstProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" ^^^^^^^^^ Hello with Islam's Carpet Cleaning Servises>>>>>>>>\n");
            Console.Write("\n");
            Console.Write("       This is our prices  :    \n");
            Console.Write("                    1- Small room Cost : 25 $ .\n");
            Console.Write("                    2- Large room Cost : 35 $ .\n");
            Console.Write("\n");
            Console.WriteLine(" >>> Please entre  the number of Small carpets :: ");
            int smallCarpets = int.Parse(Console.ReadLine());
            Console.WriteLine(" >>> Please entre  the number of Large carpets :: ");
            int largeCarpets = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");
            Console.WriteLine(">>>>><<<<<  Note that   TAX rate is :: 6 % ");
            int Cost = (smallCarpets*25) + (largeCarpets*35);
            Console.WriteLine("\n");
            Console.WriteLine ( $" >>>>> Cost is :  { Cost}   $$. ") ;
            double tax = 0.06 * Cost;
            Console.WriteLine($"  >>>>> TAXES  is : { tax } $ ");
            double  estimate = tax + Cost;
            Console.WriteLine("   >>>>>>  TOTAl estimate : " + estimate +" $ ");
            Console.WriteLine("This estimate is valid for 30 days ");


        }
    }
}
