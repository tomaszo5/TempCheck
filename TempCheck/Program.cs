using AmplituderChecker.Entities;
using AmplituderChecker.Repositories;

namespace TemperatureApp
{ 
    public class TemperatureChecker
    {
        static void Main()
        {
            // Tworzenie repozytoriów dla pracowników i managera
            var employeeRepository = new ListRepository<Employee>();
            var managerRepository = new ListRepository<Manager>();

            // Dodawanie pracowników
            employeeRepository.Add(new Employee { FirstName = "Tomasz" });
            employeeRepository.Add(new Employee { FirstName = "Zuzanna" });
            employeeRepository.Add(new Employee { FirstName = "Joanna" });

            // Dodawanie managera
            managerRepository.Add(new Manager { FirstName = "Jan", LastName = "Kowalski" });

            // Przykład weryfikacji pracy przez managera
            var manager = managerRepository.GetById(1);
            var employee = employeeRepository.GetById(1);

            if (manager != null && employee != null)
            {
                // Wykonaj weryfikację pracy przez managera
                VerifyWork(manager, employee);
            }
            else
            {
                Console.WriteLine("Nie znaleziono managera lub pracownika.");
            }
        }

        static void VerifyWork(Manager manager, Employee employee)
        {
            Console.WriteLine($"Manager: {manager.FirstName} {manager.LastName}");
            Console.WriteLine($"Pracownik: {employee.FirstName}");

            // Logika weryfikacji pracy przez managera

            Console.WriteLine("Weryfikacja zakończona.");
        }
    }
}
