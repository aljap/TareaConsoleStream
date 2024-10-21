using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;


/* void InMemoryStream()
{
    using (MemoryStream ms = new MemoryStream())
    {
        byte[] data = System.Text.Encoding.UTF8.GetBytes("Memory stream example");
        ms.Write(data, 0, data.Length);
        ms.Seek(0, SeekOrigin.Begin); // Reset the position to read from the beginning
        byte[] buffer = new byte[ms.Length];
        ms.Read(buffer, 0, buffer.Length);
        string result = System.Text.Encoding.UTF8.GetString(buffer);
        Console.WriteLine("Data from MemoryStream: ");
        Console.WriteLine(result);
    }
} */

/* void writeFile()
{
    string path = "output.txt";
    using (FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write))
    {

        string content = "This is an example of writing to a file using streams.";
        byte[] data = System.Text.Encoding.UTF8.GetBytes(content);
        fs.Write(data, 2, data.Length - 2);
        Console.WriteLine("Data written to file successfully.");
    }
} */

/* void addline()
{
    string path = "output.txt";
    string content = "This is an example of writing to a file using streams.";
    byte[] data = System.Text.Encoding.UTF8.GetBytes(Environment.NewLine + content);
    using (FileStream fs = new FileStream(path, FileMode.Append, FileAccess.Write, FileShare.None))
    {
        fs.Write(data, 0, data.Length);
    }

}

void readFile()
{
    string path = "output.txt";
    using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
    {
        byte[] buffer = new byte[fs.Length - 3];
        fs.Read(buffer, 3, buffer.Length - 3);

        string content = System.Text.Encoding.UTF8.GetString(buffer);
        Console.WriteLine("File Content: ");
        Console.WriteLine(content);
    }
}
 */
/* var users = new List<User>
{
    new User { Id = 1, Name = "John Doe", Email = "john@example.com" },
    new User { Id = 2, Name = "Jane Smith", Email = "jane@example.com" }
}; */

/* /* void SerializeUsersToJson(List<User> users)
{
    string jsonString = JsonSerializer.Serialize(users, new JsonSerializerOptions { WriteIndented = true });
    File.WriteAllText("users.json", jsonString);
    Console.WriteLine("User list serialized to JSON file successfully.");
} */


/* User FindUserById(int id)
{

    if (!File.Exists("users.json"))
    {
        Console.WriteLine("File not found.");
        return null;
    }

    string jsonString = File.ReadAllText("users.json");
    List<User> users = JsonSerializer.Deserialize<List<User>>(jsonString);

    User user = users.FirstOrDefault(u => u.Id == id);

    if (user != null)
    {
        Console.WriteLine($"User found: {user.Name} ({user.Email})");
    }
    else
    {
        Console.WriteLine("User not found.");
    }

    return user;
}
void asciiART()
{
    string path = "output.txt";
    {
        string[] asciiArt = new string[]
        {
            " /\\_/\\  ",
            "( o.o ) ",
            " > ^ <  "
        };
        using (StreamWriter writer = new StreamWriter(path))
        {
            foreach (string line in asciiArt)
            {
                writer.WriteLine(line);
            }
        }

        Console.WriteLine($"ASCII cat has been written to {path}");

    }
} */
void isThereACat()
{
    Console.WriteLine("Enter the file path (file1.txt, file2.txt, file3.txt) to check for a cat (or press Enter to use 'output.txt'):");

    string filePath = Console.ReadLine() ?? string.Empty;

    if (string.IsNullOrWhiteSpace(filePath))
    {
        filePath = "output.txt";
    }

    if (!File.Exists(filePath))
    {
        Console.WriteLine($"The file {filePath} does not exist.");
    }


    string fileContent = File.ReadAllText(filePath);
    string[] asciiArt = new string[]
        {
            " /\\_/\\  ",
            "( o.o ) ",
            " > ^ <  "
        };
    string asciiArtString = string.Join(Environment.NewLine, asciiArt) + Environment.NewLine;

    if (fileContent == asciiArtString)
    {
        foreach (string line in asciiArt)
        {
            Console.WriteLine(line);
        }
        Console.WriteLine("Hay un gato *** Congratulations! ***");

    }
    else
    {
        Console.WriteLine("No hay gato. Intenta de nuevo");
    }

}

void randomCat()
{
    string[] files = { "file1.txt", "file2.txt", "file3.txt" };

    Random random = new Random();

    int randomFileIndex = random.Next(files.Length);

    string path = files[randomFileIndex];

    string[] asciiArt = new string[]
        {
            " /\\_/\\  ",
            "( o.o ) ",
            " > ^ <  "
        };
    using (StreamWriter writer = new StreamWriter(path))
    {
        foreach (string line in asciiArt)
        {
            writer.WriteLine(line);
        }
    }

    Console.WriteLine($"ASCII cat has been written to ???");



}
void deleteCats()
{
    string[] files = { "file1.txt", "file2.txt", "file3.txt" };


    foreach (string file in files)
    {
        using (FileStream fs = new FileStream(file, FileMode.Truncate))
        {

        }

    }
    Console.WriteLine("Rerun the commmand to try again");

}


randomCat();
isThereACat();
deleteCats();
class User
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public string? Email { get; set; }
}
