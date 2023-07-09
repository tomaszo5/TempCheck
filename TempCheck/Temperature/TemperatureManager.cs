using System;
using System.Linq;
using AmplituderChecker.Entities;
using AmplituderChecker.Repositories;
 
public class TemperatureManager
{
    private readonly IRepository<Temperature> _temperatureRepository;
    private readonly IRepository<Employee> _employeeRepository;
    private bool _isLoggedIn;

    public void RecordTemperatures()
    {
        Console.WriteLine("Dodawanie wartości temperatur:");

        // Dodawanie temperatur dla miast
        var cities = new[] { "Gdynia", "Gdańsk", "Warszawa", "Kraków" };

        foreach (var city in cities)
        {
            Console.Write($"{city}: ");
            double temperature = ReadTemperature();

            // Zapisywanie temperatur do repozytorium
            _temperatureRepository.Add(new Temperature(city, temperature));
        }

        Console.WriteLine("Temperatury zostały zapisane.");
    }

    private double ReadTemperature()
    {
        double temperature;
        while (!double.TryParse(Console.ReadLine(), out temperature))
        {
            Console.WriteLine("Błędny format temperatury. Wprowadź ponownie.");
        }
        return temperature;
    }

    public void VerifyWork(Manager manager)
    {
        Console.WriteLine($"Manager: {manager.FirstName} {manager.LastName}");

        // Obliczanie średniej temperatury
        var temperatures = _temperatureRepository.GetAll();
        double averageTemperature = temperatures.Select(t => t.Value).Average();

        Console.WriteLine($"Średnia temperatura: {averageTemperature}");

        // Znalezienie najwyższej i najniższej temperatury
        double maxTemperature = temperatures.Select(t => t.Value).Max();
        double minTemperature = temperatures.Select(t => t.Value).Min();

        Console.WriteLine($"Najwyższa temperatura: {maxTemperature}");
        Console.WriteLine($"Najniższa temperatura: {minTemperature}");

        Console.WriteLine("Weryfikacja zakończona.");
    }
}
