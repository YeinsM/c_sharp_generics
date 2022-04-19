using System;
using YeinsBrainSoftware.StorageApp.Models;
using YeinsBrainSoftware.StorageApp.Repositories;

namespace YeinsBrainSoftware.StorageApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var employeeRepository = new GenericRepository<Employee>();
            employeeRepository.Add(new Employee { FirstName = "Yeins" });
            employeeRepository.Add(new Employee { FirstName = "George" });
            employeeRepository.Add(new Employee { FirstName = "Valeria" });
            employeeRepository.Save();

            var organizationRepository = new GenericRepository<Organization>();
            organizationRepository.Add(new Organization { Name = "Pluralsight" });
            organizationRepository.Add(new Organization { Name = "Microsoft" });
            organizationRepository.Save();

            Console.ReadLine();
        }
    }
}
