
KeyValuePair<int,string> pairNo1 = new KeyValuePair<int, string>(1, "One");
KeyValuePair<int,string> pairNo2 = new KeyValuePair<int, string>(2, "Two");

Console.WriteLine($"KVP1: key : {pairNo1.Key} - value : {pairNo1.Value}");
Console.WriteLine($"KVP2: key : {pairNo2.Key} - value : {pairNo2.Value}");

Dictionary<int, string> dictionary = new Dictionary<int, string>();
dictionary.Add(pairNo1.Key, pairNo1.Value);
dictionary.Add(pairNo2.Key, pairNo2.Value);

Console.WriteLine("Dictionary contents:");
foreach (var kvp in dictionary)
{
    Console.WriteLine($"key : {kvp.Key} - value : {kvp.Value}");
}

var capitals = new List<KeyValuePair<string, string>>()
{
    new KeyValuePair<string, string>("USA", "Washington D.C."),
    new KeyValuePair<string, string>("UK", "London"),
    new KeyValuePair<string, string>("France", "Paris"),
    new KeyValuePair<string, string>("Germany", "Berlin")
};

Console.WriteLine("Capitals:");
foreach (var capital in capitals)
{
    Console.WriteLine($"key : {capital.Key} - value : {capital.Value}");
}

Console.WriteLine("--------------------------");
Console.WriteLine(GetFirstNameAndLastName());

KeyValuePair<string, string> GetFirstNameAndLastName()
{
    Console.WriteLine("Enter first name:");
    string firstName = Console.ReadLine();
    Console.WriteLine("Enter last name:");
    string lastName = Console.ReadLine();
    return new KeyValuePair<string, string>(firstName, lastName);
}

Console.ReadLine();

