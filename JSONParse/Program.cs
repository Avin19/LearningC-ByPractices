using System.Text.Json;



string jsonstring = "
             ""id"": 1,
                ""name"": ""John Doe"",
                ""email"": ""john.doe@example.com"",
                ""roles"": [""admin"", ""user""]
        
        ";

User user = JsonSerializer.Deserialize<User>(jsonstring);
Console.WriteLine("Parsed JSON Data:");
Console.WriteLine($"Name : {user.Name}");
Console.WriteLine($"Email : {user.Email}");
Console.WriteLine($"ID  :{user.Id}");

Console.ReadLine();


