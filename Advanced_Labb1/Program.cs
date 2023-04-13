using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Advanced_Labb1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LådaCollection boxes=new LådaCollection();
            boxes.Add(new Låda(1, 1, 1));
            boxes.Add(new Låda(2, 1, 3));
            boxes.Add(new Låda(5, 7, 3));
            boxes.Add(new Låda(2, 15, 10));
            boxes.Add(new Låda(4, 3, 8));

            boxes.Add(new Låda(1, 1, 1));

            Display(boxes);

            boxes.Remove(new Låda(1,1,1));

            Display(boxes);

            Låda search = (new Låda(4, 3, 8));

            if(boxes.Contains(search))
            {
                Console.WriteLine("\nThe box with height {0}, length {1} and width {2} does exist in the collection",search.höjd,search.längd,search.bredd);
            }
            else
            {
                Console.WriteLine("\nThis box does not exist in the collection");
            }
        }
        static void Display(LådaCollection lådaCollection)
        {
            Console.WriteLine("\nHöjd\tLängd\tBredd\t");

            foreach(var box in lådaCollection)
            {
                Console.WriteLine("{0}\t{1}\t{2}",box.höjd,box.längd,box.bredd);
            }
        }
    }
}
