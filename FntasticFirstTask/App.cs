using System.Text;

namespace FntasticFirstTask;

public class App
{
    public void Run()
    {
        while (true)
        {
            Process();
        }
    }

    private void Process()
    {
        var input = Enter("Input: ");

        var dictionary = new Dictionary<char, uint>();
        
        foreach (var character in input)
        {
            if (dictionary.ContainsKey(character))
            {
                dictionary[character] += 1;
            }
            else
            {
                dictionary[character] = 1;
            }
        }

        var stringBuilder = new StringBuilder();

        foreach (var character in input)
        {
            stringBuilder.Append(dictionary[character] >= 2 ? ')' : '(');
        }
        
        Console.WriteLine($"Output: {stringBuilder}");
    }

    private string Enter(string printText)
    {
        while (true)
        {
            try
            {
                Console.Write(printText);
                
                var input = Console.ReadLine();

                if (string.IsNullOrEmpty(input))
                {
                    throw new ArgumentException("Empty input");
                }
                
                return input.ToLower();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}