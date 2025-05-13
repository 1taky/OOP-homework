using System;
using System.Text;

namespace Homework
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            string[] initialLines = {
            "Перший рядок",
            "Другий рядок",
            "Третій рядок"
        };

            TextContainer text = new TextContainer(initialLines);

            Console.WriteLine("Кількість рядків: " + text.LineCount);

            Console.WriteLine("Рядок з індексом 1: " + text[1]);

            text[1] = "Оновлений другий рядок";
            Console.WriteLine("Після зміни: " + text[1]);

            Console.WriteLine("Спроба доступу за неправильним індексом: " + text[5]);
        }
    }
}
