using System.Text.Json.Serialization;

namespace RelacionesEF_DataAnotations.Models.OneToMany
{
    public class Doctor
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        //Relacion de uno a muchos
        [JsonIgnore]
        public List<Patient>? Patients { get; set; } //Propiedad de navegacion
    }
}
