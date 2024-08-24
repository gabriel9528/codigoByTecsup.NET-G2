namespace RelationsUsingFLUENT_API.Models.OneToOne
{
    public class CarCompany
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public CarModel? CarModel { get; set; }
    }
}
