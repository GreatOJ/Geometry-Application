// Program.cs
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.FeatureManagement;
using GeoApplib;

class Program
{
    static async Task Main(string[] args)
    {
        var featureManagement = new Dictionary<string, string>
        {
            { "FeatureManagement:Square", "true"},
            { "FeatureManagement:Rectangle", "false"},
            { "FeatureManagement:Triangle", "true"}
        };

        IConfigurationRoot configuration = new ConfigurationBuilder()
            .AddInMemoryCollection(featureManagement)
            .Build();

        var services = new ServiceCollection();
        services.AddFeatureManagement(configuration);
        var serviceProvider = services.BuildServiceProvider();

        var featureManager = serviceProvider.GetRequiredService<IFeatureManager>();

        // Check if the feature is enabled and provide access accordingly
        if (await featureManager.IsEnabledAsync("Square"))
        {
            // Provide access to Square
            double sideLength;
            Console.WriteLine("Enter the side length of the square:");
            if (double.TryParse(Console.ReadLine(), out sideLength))
            {
                var square = new Square(sideLength);
                Console.WriteLine($"Area of the square: {square.CalculateArea()}");
                Console.WriteLine($"Perimeter of the square: {square.CalculatePerimeter()}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }
        else
        {
            Console.WriteLine("The square feature is disabled.");
        }
    }
}
