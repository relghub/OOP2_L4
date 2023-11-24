namespace Triangle_Pyramid
{
    class Program
    {
        enum Tasks
        {
            Exit, EquiTriangle, SquareMatrix
        }
        static string[] taskList = new[]
        {
            "Рівносторонній трикутник",
            "Квадратна матриця"
        };
        static void Main()
        {
            Tasks taskSel = 0;
            Console.Clear();
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine("Який варіант бажаєте обрати?");
            for (int i = 0; i < taskList.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {taskList[i]}");
            }
            Console.WriteLine("0. Вихід");

            try
            {
                taskSel = (Tasks)(int.Parse(Console.ReadLine()));
            }
            catch
            {
                Console.WriteLine("Недопустиме введення. Повторіть спробу.");
                Pause();
            }

            switch (taskSel)
            {
                case Tasks.Exit:
                    Console.WriteLine("Дякуємо за тестування.");
                    break;
                case Tasks.EquiTriangle:
                    TriangleSwitch.ETriang(); Pause(); break;
                case Tasks.SquareMatrix:
                    MatrixSwitch.SMatr(); Pause(); break;
                default:
                    Console.WriteLine("Така операція не підтримується." +
                                                    " Повторіть спробу.");
                    Pause();
                    Main();
                    break;
            }
        }
        static void Pause()
        {
            Console.WriteLine("Натисніть довільну клавішу, щоб продовжити.");
            Console.ReadKey();
            Main();
        }
    }

}