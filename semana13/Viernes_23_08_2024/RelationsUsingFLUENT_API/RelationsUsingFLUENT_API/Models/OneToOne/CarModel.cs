namespace RelationsUsingFLUENT_API.Models.OneToOne
{
    public class CarModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int CarCompanyId { get; set; }
        public CarCompany? CarCompany { get; set; }
    }
}
