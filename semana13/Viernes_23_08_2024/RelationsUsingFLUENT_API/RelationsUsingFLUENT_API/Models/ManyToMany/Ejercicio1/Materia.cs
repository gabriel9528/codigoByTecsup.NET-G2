﻿namespace RelationsUsingFLUENT_API.Models.ManyToMany.Ejercicio1
{
    public class Materia
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public List<StudentMateria>? StudentMaterias { get; set; }

    }
}