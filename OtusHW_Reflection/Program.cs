using System.Diagnostics;
using System.Reflection;
using System.Text;

namespace OtusHW_Reflection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var mser = new MySerializer();
            var classF = new F();
            var newF = classF.Get(); //создаётся новый экземпляр класса F

            Stopwatch sw = new Stopwatch();
            sw.Start();

            for (int i = 0; i <= 100000; i++)
            {
                string serializedString = mser.Serialize(classF);
                if (i == 100000)
                {
                    Console.WriteLine(serializedString);
                }
            }

            sw.Stop();
            var t1 = sw.ElapsedTicks;
            sw.Restart();

            for (int i = 0; i <= 100000; i++)
            {
                string serializedString = mser.Serialize(classF.Get());
                if (i == 100000)
                {
                    Console.WriteLine(serializedString);
                }
            }

            sw.Stop();
            var t2 = sw.ElapsedTicks;
            Console.WriteLine($"Сериализация базового F: {t1} ticks. Сериализация нового F через функцию Get: {t2} ticks");
        }
    }

    [Serializable]
    public class F
    {
        public int i1, i2, i3, i4, i5;

        public F Get() => new F()
        {
            i1 = 1,
            i2 = 2,
            i3 = 3,
            i4 = 4,
            i5 = 5
        };
    }
}
