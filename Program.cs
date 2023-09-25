namespace RandomPicker;

public static class Program
{
    private static void Main()
    {
        List<string> nameList = new List<string>
        {
            "Douglas Santana",
            "Amanda Torres",
            "Bruno Tavares",
            "Tiago Silva",
            "Rui Seabra",
            "Magali Laiginhas",
            "César Crista",
            "Paulo Gama",
            "Sidney Miranda"
        };

        Random random = new Random();
        int randomIndex = random.Next(minValue: 0, maxValue: nameList.Count);

        string selectedName = nameList[index: randomIndex];

        Console.WriteLine($"Sorteado da vez: {selectedName}");
    }
}