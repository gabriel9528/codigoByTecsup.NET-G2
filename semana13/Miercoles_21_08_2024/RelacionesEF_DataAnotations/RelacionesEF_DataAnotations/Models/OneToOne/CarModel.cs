namespace RelacionesEF_DataAnotations.Models.OneToOne
{
    public class CarModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        //Relacion de uno a uno
        public int CarCompanyId { get; set; } //Clave foránea
        //constraint fk_CarModel_CarCompany foreign key (CarCompanyId) references CarCompany (Id)
        public CarCompany? CarCompany { get; set; } //Propiedad de navegación
    }
}
