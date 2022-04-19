﻿namespace YeinsBrainSoftware.StorageApp.Models
{
    public class Organization
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public override string ToString() => $"Id: {Id}, Name: {Name}";
    }
}
