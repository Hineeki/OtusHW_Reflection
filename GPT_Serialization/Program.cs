using System.Diagnostics;
using System.Text;

class F
{
    public int i1, i2, i3, i4, i5;

    public string SerializeToString()
    {
        StringBuilder result = new StringBuilder();
        result.AppendLine($"i1: {i1}");
        result.AppendLine($"i2: {i2}");
        result.AppendLine($"i3: {i3}");
        result.AppendLine($"i4: {i4}");
        result.AppendLine($"i5: {i5}");
        return result.ToString();
    }
}

class Program
{
    static void Main()
    {
        F myObject = new F();

        int numberOfIterations = 100000;
        Stopwatch stopwatch = new Stopwatch();

        // Замеряем время до выполнения сериализации
        stopwatch.Start();

        for (int i = 0; i < numberOfIterations; i++)
        {
            string serializedString = myObject.SerializeToString();
            // Здесь вы можете использовать serializedString, если это необходимо
        }

        // Замеряем время после выполнения сериализации
        stopwatch.Stop();

        // Выводим результаты
        Console.WriteLine($"Сериализация выполнена {numberOfIterations} раз");
        Console.WriteLine($"Затраченное время: {stopwatch.ElapsedMilliseconds} миллисекунд");
    }
}
