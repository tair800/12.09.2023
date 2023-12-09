

namespace DomainLayer.Models
{
    internal class Book : Product
    {
        public string AuthorName { get; set; }
        public int PageCount { get; set; }

        public override void Sell()
        {
            if (Count == 0)
            {
                Console.WriteLine("ProductCountIsZeroException");

            }
            
        }
        public Book(string name, int price, string authorNAme,int pageCount)
        {
            Name= name;
            Price= price;
            AuthorName= authorNAme;
            PageCount= pageCount;
            
        }
        public override void ShowInfo()
        {
            Console.WriteLine($"Book ID: {Id}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Author: {AuthorName}");
            Console.WriteLine($"Page Count: {PageCount}");
            Console.WriteLine($"Price: {Price}");
            Console.WriteLine($"Count: {Count}");
            Console.WriteLine($"Total Income: {TotalIncome}");
        }
    }
}
