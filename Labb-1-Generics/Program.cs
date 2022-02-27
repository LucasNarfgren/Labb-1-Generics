using System;

namespace Labb_1_Generics
{
    // LUCAS NARFGREN SUT21
    class Program
    {
        static void Main(string[] args)
        {
            LådaCollection LådLista = new LådaCollection();

            LådLista.Add(new Låda(10, 20, 30));
            LådLista.Add(new Låda(5, 10, 35));
            LådLista.Add(new Låda(15, 50, 100));

            Display(LådLista);

            Console.WriteLine("Tar Bort låda med Dimensioner H:{0} L:{1} B:{2}",15,50,100);
            LådLista.Remove(new Låda(15, 50, 100));
            Console.WriteLine();
            Display(LådLista);
            Console.WriteLine();
            
            Console.WriteLine("Lägger Till låda med Dimensioner H:{0} L:{1} B:{2}", 15, 50, 100);
            LådLista.Add(new Låda(15, 50, 100));
            Display(LådLista);
            Console.WriteLine();
            Console.WriteLine("Försöker Lägga till låda med samma dimensioner.");
            LådLista.Add(new Låda(15, 50, 100));

            Display(LådLista);

            Console.ReadKey();


        }

        public static void Display(LådaCollection lådLista)
        {
            Console.WriteLine("\nHöjd\tLängd\tBredd");
            foreach (var item in lådLista)
            {
                Console.WriteLine("{0}\t{1}\t{2}", item.höjd.ToString(), item.längd.ToString(),item.bredd.ToString());
            }
        }
    }
}
