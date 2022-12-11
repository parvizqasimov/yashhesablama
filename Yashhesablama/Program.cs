namespace Yashhesablama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dogum tarixini qeyd edin");
            int gun = int.Parse(Console.ReadLine());
            int ay = int.Parse(Console.ReadLine());
            int il = int.Parse(Console.ReadLine());

            Console.WriteLine("");

            Console.WriteLine("Bu gunki tarixi qeyd edin");
            int bugun = int.Parse(Console.ReadLine());
            int buay = int.Parse(Console.ReadLine());
            int buil = int.Parse(Console.ReadLine());


            int yash = buil - il;

            if (ay > buay)
            {
                yash = yash - 1;
            }
            else if (ay == buay)
            {
                if (bugun < gun)
                {
                    yash = yash - 1;
                }
            }
            else
            {
                Console.WriteLine(yash);
            }
            Console.WriteLine($"dogum tarixi: {gun}.{ay}.{il} bugunki tarix: {bugun}.{buay}.{buil}  yash {yash}");
        }
    }
}