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
            AddEmployees(employeeRepository);
            GetEmployeeById(employeeRepository);

            var organizationRepository = new GenericRepository<Organization>();
            AddOrganizations(organizationRepository);

            Console.ReadLine();
        }

        private static void GetEmployeeById(GenericRepository<Employee> employeeRepository)
        {
            var employee = employeeRepository.GetById(2);
            Console.WriteLine($"Employee with Id 2: {employee.FirstName}");
        }

        private static void AddEmployees(GenericRepository<Employee> employeeRepository)
        {
            employeeRepository.Add(new Employee { FirstName = "Yeins" });
            employeeRepository.Add(new Employee { FirstName = "George" });
            employeeRepository.Add(new Employee { FirstName = "Valeria" });
            employeeRepository.Save();
        }

        private static void AddOrganizations(GenericRepository<Organization> organizationRepository)
        {
            organizationRepository.Add(new Organization { Name = "Pluralsight" });
            organizationRepository.Add(new Organization { Name = "Microsoft" });
            organizationRepository.Save();
        }
    }
}
