using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Composite_DP;


public interface ILibrary
{
    void Show(int charactercount);
}

public class Book : ILibrary
{
    public string Name { get; set; }
    public Book(string name)
    {
        Name = name;
    }

    public void Show(int charactercount)
    {
        String line = new String('-', charactercount);
        Console.WriteLine(line + Name);
    }

    public override string ToString()
    {
        return Name;
    }

    public class Category: ILibrary
    {
        public string Name { get; set; }
        public Category(string name)
        {
            Name = name;
        }
        private List<ILibrary> subitems = new List<ILibrary>();
        public void Add(ILibrary library)
        {
            subitems.Add(library);
        }
        public void Show(int charactercount)
        {
            String line = new String('-', charactercount++);
            Console.WriteLine("{0}{1}({2})", line, Name, subitems.Count);

            foreach (var item in subitems)
            {
                item.Show(charactercount);
            }

        }
        public override string ToString()
        {
            return Name;
        }
    }

    public class Composite
    {
        static void Main(string[] args)
        {
            Category books = new Category("Book");
            Category sciencefiction = new Category("Science Fiction");
            Category fantastic = new Category("Fantastic");

            Book sciencefiction1 = new Book("Frankestein");
            Book sciencefiction2 = new Book("The Time Machine");

            Book fantastic1 = new Book("The Lord of The Rings");
            Book fantastic2 = new Book("Harry Potter");

            
            books.Add(sciencefiction);
            books.Add(fantastic);
            sciencefiction.Add(sciencefiction1);
            sciencefiction.Add(sciencefiction2);
            fantastic.Add(fantastic1);
            fantastic.Add(fantastic2);

            books.Show(1);
            Console.ReadLine();
            


        }
    }

}

