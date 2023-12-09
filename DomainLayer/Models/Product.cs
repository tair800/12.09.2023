

namespace DomainLayer.Models
{
    public abstract class Product
    {
     public int Id { get; }
    public string Name { get; set; }
    public double Price {  get; set; }
    public int Count { get; set; }
    public double TotalIncome { get; set; }
        public abstract void Sell();
        public abstract void ShowInfo();
    }
}
