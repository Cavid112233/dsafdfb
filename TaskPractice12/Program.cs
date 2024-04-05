using Core.Classes;

namespace TaskPractice12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Store store = new Store();
            
            string answer;
            Console.WriteLine();
            do
            {
                Console.WriteLine("1.Mehsul Elave et\n"+
                    "2.Mehsul sil\n"+
                    "3.Mehsula bax\n"+
                    "4.Type-a gore mehsullara bax\n"+
                    "5.Ada gore axtaris et ve mehsullara bax\n");
                Console.WriteLine("secim edin:");
                answer = Console.ReadLine();
                if (answer == "1")
                {
                    Console.WriteLine("Elave et:");
                    Console.WriteLine("Mehsul adini daxil edin:");
                    string name = Console.ReadLine();
                    int price;
                    do
                    {
                        Console.WriteLine("Qiymet daxil edin:");
                        
                    } while (!int.TryParse(Console.ReadLine(),out price));
                    Console.WriteLine(store.AddProduct);
                }

            } while (true);
        }
    }
}