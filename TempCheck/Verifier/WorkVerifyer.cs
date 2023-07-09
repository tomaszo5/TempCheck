using AmplituderChecker.Entities;
using AmplituderChecker.Repositories;
public class WorkVerifier
{
    private readonly IRepository<Employee> _employeeRepository;
    private readonly IRepository<Manager> _managerRepository;

    public WorkVerifier()
    {
        _employeeRepository = new ListRepository<Employee>();
        _managerRepository = new ListRepository<Manager>();

        // Dodawanie managera
        _managerRepository.Add(new Manager { FirstName = "Jan", LastName = "Kowalski" });
    }

    public void VerifyWork()
    {
        // Przykład weryfikacji pracy przez managera
        var manager = _managerRepository.GetById(1);
        var employee = _employeeRepository.GetById(1);

        if (manager != null && employee != null)
        {
            Console.WriteLine($"Manager: {manager.FirstName} {manager.LastName}");
            Console.WriteLine($"Pracownik: {employee.FirstName}");

            // Logika weryfikacji pracy przez managera
            if (IsWorkCompleted(employee))
            {
                Console.WriteLine("Praca została zakończona.");
            }
            else
            {
                Console.WriteLine("Praca nie została zakończona.");
            }
        }
        else
        {
            Console.WriteLine("Nie znaleziono managera lub pracownika.");
        }
    }

    private bool IsWorkCompleted(Employee employee)
    {
        // Logika sprawdzająca, czy praca została zakończona przez pracownika
        // W tym przykładzie przyjmujemy, że praca została zakończona, jeśli pracownik ma ustawione imię
        return !string.IsNullOrEmpty(employee.FirstName);
    }
}