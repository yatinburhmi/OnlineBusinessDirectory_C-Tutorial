namespace Group1_A2.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }

        public Category() { }

        public Category(int id, string name)
        {
            CategoryId = id;
            Name = name;
        }
    }
}