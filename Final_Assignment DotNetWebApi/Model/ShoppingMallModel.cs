namespace Final_Assignment_DotNetWebApi.Model
{
    public class ShoppingMallModel
    {
        public int Id { get; set; }
        public string ShoppingMallName { get; set; } = null!;
        public string City { get; set; } = null!;
        public string State { get; set; } = null!;
        public int Built_in_Year { get; set; }
    }
}
