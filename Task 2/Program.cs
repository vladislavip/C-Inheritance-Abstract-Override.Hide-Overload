namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var unicard = new Unibank("a", "xxxxxxxxxxxxxx", 000, 100);
            var accessCard = new AccessBank("b", "xxxxxxxxxxxxxx", 001, 200);
            var pashaCard = new PashaBank("c", "xxxxxxxxxxxxxx", 002, 300);
            var leoCard= new LeoBank("c", "xxxxxxxxxxxxxx", 003, 400);


            // test values are equal for prompt try of functionality 

            Console.WriteLine(unicard.cardPlus(100));
            Console.WriteLine(unicard.cardMinus(100));

            Console.WriteLine(accessCard.cardPlus(100));
            Console.WriteLine(accessCard.cardMinus(100));

            Console.WriteLine(pashaCard.cardPlus(100));
            Console.WriteLine(pashaCard.cardMinus(100));

            Console.WriteLine(leoCard.cardPlus(100));
            Console.WriteLine(leoCard.cardMinus(100));


            
        }
    }
}