namespace RelacionesEF_DataAnotations.Models.OneToMany
{
    public class Patient
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int DoctorId { get; set; } //Clave foranea
        public Doctor? Doctor { get; set; } //Propiedad de navegacion
        //constraint fk_Patient_Doctor foreign key (DoctorId) references Doctor (Id)

    }
}
