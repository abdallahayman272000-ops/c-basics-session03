using System.Text;

namespace Assigment_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //[1]
            string title = "Clean Code";
            string upperTitle = title.ToUpper();
            Console.WriteLine(title);   
            Console.WriteLine(upperTitle);
            Console.WriteLine("=====================================================================");

            //[2]
            string text1, text2;
            text1= "clean code";
            text2= "clean code";

            Console.WriteLine(Object.ReferenceEquals(text1,text2));
            Console.WriteLine("=====================================================================");

            //[3]
            StringBuilder str = new StringBuilder();
            str.Append("Book List");
            str.Append("- Updated");
            Console.WriteLine(str);
            Console.WriteLine("=====================================================================");

            //[4]
            str.Replace("Book List", "Library");
            Console.WriteLine(str);
            Console.WriteLine("=====================================================================");

            //[5]

            int pages = 464;
            string cocatination = "Book:" + title + ", pages:" + pages;
            Console.WriteLine(cocatination);
            Console.WriteLine("=====================================================================");

            //[6]
            string interpolation = $"Book:{title}, pages:{pages}";
            Console.WriteLine(interpolation);
            Console.WriteLine("=====================================================================");

            //[7]
            string Composite_Formating = string.Format("Book:{0},pages: {1}", title,pages);
            Console.WriteLine(Composite_Formating);
            Console.WriteLine("=====================================================================");

            //[8]
            if (pages>300)
            {
                Console.WriteLine("Long Book");
            }
            else
            {
                Console.WriteLine("Short Book");
            }
            Console.WriteLine("=====================================================================");

            //[9]
            switch (title)
            {
                case  "Clean Code":
                    Console.WriteLine("great choice");
                    break;
                case "Refactoring":
                    Console.WriteLine("Nice pick!");
                    break;
                default:
                    Console.WriteLine("Never heard of it");
                    break;

          
            }
            Console.WriteLine("=====================================================================");

            //[9]
            string results = pages > 300 ? "Long Book" : "Short Book";
            Console.WriteLine(results);
            Console.WriteLine("=====================================================================");

            //[10]
            string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
                for (int i = 0; i < 3; i++)
                {
                Console.WriteLine(i + 1 + "." + books[i]);
                }
            
            Console.WriteLine("=====================================================================");
           //[11]
            int x = 0;
            while(x<3)
            {
                Console.WriteLine(x + 1 + "." + books[x]);
                x++;
            }
            Console.WriteLine("=====================================================================");
            //[12]
            x = 0;
            do
            {
                Console.WriteLine(x + 1 + "." + books[x]);
                x++;
            } while (x < 3);
            Console.WriteLine("=====================================================================");
            //[13]
            x = 0;
            foreach (var b in books)
            {
                Console.WriteLine(++x+"." + b);
            }
            Console.WriteLine("=====================================================================");
            //[14]
            for(int i=0;i<3;i++)
            {
                if (i == 2)
                {
                    break;
                }
                Console.WriteLine(i + 1 + "." + books[i]);
            }
            Console.WriteLine("=====================================================================");
            //[15]
            for (int i = 0; i < 3; i++)
            {
                if (i == 1)
                {
                    continue;
                }
                Console.WriteLine(i + 1 + "." + books[i]);
            }
            Console.WriteLine("=====================================================================");
            print(books);
        }
        public static void print(string[] arr)
        {
            Console.WriteLine(arr[0]);
            for(int i=0;i<arr.Length;i++)
            {
                if (arr[i] == "")
                    return;
            }
        }
    }
}
