using System.Numerics;

namespace Triangle_Pyramid
{
    internal class TriangleSwitch
    {
        enum Operations
        {
            Exit, Comparison, Addition, Subtraction, Multiplication, Pyramid
        }
        static string[] opList = new[]
        {
            "Порівняння",
            "Додавання",
            "Віднімання",
            "Множення",
            "Створення піраміди"
        };
        internal static void ETriang()
        {
            Operations opSel = 0;
            Console.WriteLine("Перелік доступних операцій:");
            for (int i = 0; i < opList.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {opList[i]}");
            }
            Console.WriteLine("0. Вихід");
            try
            {
                opSel = (Operations)(int.Parse(Console.ReadLine()));
            }
            catch
            {
                Console.WriteLine("Недопустиме введення. Повторіть спробу.");
                Pause();
            }
            switch (opSel)
            {
                case Operations.Comparison: CompareOn(); Pause(); break;
                case Operations.Addition: AddOn(); Pause(); break;
                case Operations.Subtraction: SubtrOn(); Pause(); break;
                case Operations.Multiplication: MultOn(); Pause(); break;
                case Operations.Pyramid: PyramidOn(); Pause(); break;
                case Operations.Exit:
                    Console.WriteLine("Дякуємо за тестування.");
                    break;
                default:
                    Console.WriteLine("Така операція не підтримується." +
                                                    " Повторіть спробу.");
                    Pause();
                    ETriang();
                    break;

            }
        }
        static void CompareOn()
        {
            Console.Write("Введіть довжину сторін трикутника 1: ");
            int firstETLen = int.Parse(Console.ReadLine());
            Console.Write("Введіть довжину сторін трикутника 2: ");
            int secondETLen = int.Parse(Console.ReadLine());
            ETriangle<double> triangle1 = new ETriangle<double>(firstETLen);
            ETriangle<double> triangle2 = new ETriangle<double>(secondETLen);

            Console.WriteLine("Трикутник 1:");
            triangle1.DisplayData();
            Console.WriteLine($"Площа: {triangle1.CalculateArea()}");
            Console.WriteLine($"Периметр: {triangle1.CalculatePerimeter()}");

            Console.WriteLine("\nТрикутник 2:");
            triangle2.DisplayData();
            Console.WriteLine($"Площа: {triangle2.CalculateArea()}");
            Console.WriteLine($"Периметр: {triangle2.CalculatePerimeter()}");

            Console.WriteLine("\nПорівняння трикутників:");
            Console.WriteLine($"Трикутник 1 і трикутник 2 " +
                $"{(triangle1.Compare(triangle2) ? "рівні" : "не рівні")}");
        }
        static void AddOn()
        {
            Console.Write("Введіть довжину сторін трикутника 1: ");
            int firstETLen = int.Parse(Console.ReadLine());
            Console.Write("Введіть довжину сторін трикутника 2: ");
            int secondETLen = int.Parse(Console.ReadLine());
            ETriangle<double> triangle1 = new ETriangle<double>(firstETLen);
            ETriangle<double> triangle2 = new ETriangle<double>(secondETLen);

            ETriangle<double> sumTriangle = triangle1 + triangle2;

            Console.WriteLine("Сума трикутників:");
            sumTriangle.DisplayData();
        }
        static void SubtrOn()
        {
            Console.Write("Введіть довжину сторін трикутника 1: ");
            int firstETLen = int.Parse(Console.ReadLine());
            Console.Write("Введіть довжину сторін трикутника 2: ");
            int secondETLen = int.Parse(Console.ReadLine());
            ETriangle<double> triangle1 = new ETriangle<double>(firstETLen);
            ETriangle<double> triangle2 = new ETriangle<double>(secondETLen);

            ETriangle<double> diffTriangle = triangle1 - triangle2;

            Console.WriteLine("\nРізниця трикутників:");
            diffTriangle.DisplayData();
        }
        static void MultOn()
        {
            Console.Write("Введіть довжину сторін трикутника: ");
            int ETLen = int.Parse(Console.ReadLine());
            Console.Write("Введіть множник трикутника: ");
            int coeff = int.Parse(Console.ReadLine());

            ETriangle<double> triangle = new ETriangle<double>(ETLen);

            ETriangle<double> multTriangle = triangle * coeff;

            Console.WriteLine($"\nТрикутник, помножений на {coeff}:");
            multTriangle.DisplayData();
        }
        static void PyramidOn()
        {
            Console.Write("Введіть довжину сторін " +
                "правильної трикутної піраміди: ");
            int ETPLen = int.Parse(Console.ReadLine());

            RTPyramid<double> pyramid = new RTPyramid<double>(ETPLen);

            Console.WriteLine("\nПравильна трикутна піраміда:");
            pyramid.DisplayData();
        }
        static void Pause()
        {
            Console.WriteLine("Натисніть довільну клавішу, щоб продовжити.");
            Console.ReadKey();
            Console.Clear();
            ETriang();
        }
    }
    internal class MatrixSwitch
    {
        enum Operations
        {
            Exit, Extremes, Addition, Subtraction, Determinant
        }
        static string[] opList = new[]
        {
            "Екстремальні значення матриць",
            "Додавання",
            "Віднімання",
            "Обчислення визначника 2 порядку",
        };
        internal static void SMatr()
        {
            Operations opSel = 0;
            Console.WriteLine("Перелік доступних операцій:");
            for (int i = 0; i < opList.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {opList[i]}");
            }
            Console.WriteLine("0. Вихід");
            try
            {
                opSel = (Operations)(int.Parse(Console.ReadLine()));
            }
            catch
            {
                Console.WriteLine("Недопустиме введення. Повторіть спробу.");
                Pause();
            }
            switch (opSel)
            {
                case Operations.Extremes: ExtremeOn(); Pause(); break;
                case Operations.Addition: AddOn(); Pause(); break;
                case Operations.Subtraction: SubtrOn(); Pause(); break;
                case Operations.Determinant: DetOn(); Pause(); break;
                case Operations.Exit:
                    Console.WriteLine("Дякуємо за тестування.");
                    break;
                default:
                    Console.WriteLine("Така операція не підтримується." +
                                                    " Повторіть спробу.");
                    Pause();
                    SMatr();
                    break;

            }
        }
        static void MatrixInput(ref SMatrix<int> matrix, out int size)
        {
            Console.Write("Введіть розмірність квадратної матриці: ");
            size = int.Parse(Console.ReadLine());
            if (size != 2)
            {
                Console.WriteLine("Матриця повинна бути другого порядку для знаходження визначника.");
                Pause();
            }
            else
            {
                matrix = new SMatrix<int>(size);

                Console.WriteLine("Введення даних для матриці 1:");
                matrix.InputData();

                Console.WriteLine("\nМатриця 1:");
                matrix.DisplayData();
            }

        }
        static void MatrixInput(ref SMatrix<int> matrix1, ref SMatrix<int> matrix2)
        {
            Console.Write("Введіть розмірність квадратної матриці 1: ");
            int size1 = int.Parse(Console.ReadLine());
            Console.Write("Введіть розмірність квадратної матриці 2: ");
            int size2 = int.Parse(Console.ReadLine());

            matrix1 = new SMatrix<int>(size1);
            matrix2 = new SMatrix<int>(size2);

            Console.WriteLine("Введення даних для матриці 1:");
            matrix1.InputData();

            Console.WriteLine("\nВведення даних для матриці 2:");
            matrix2.InputData();

            Console.WriteLine("\nМатриця 1:");
            matrix1.DisplayData();

            Console.WriteLine("\nМатриця 2:");
            matrix2.DisplayData();
        }
        static void ExtremeOn()
        {
            SMatrix<int> matrix1 = new();
            SMatrix<int> matrix2 = new();
            MatrixInput(ref matrix1, ref matrix2);
            Console.WriteLine($"\nНайбільший елемент матриці 1: {matrix1.FindMaxElement()}");
            Console.WriteLine($"Найменший елемент матриці 1: {matrix1.FindMinElement()}");
            Console.WriteLine($"\nНайбільший елемент матриці 2: {matrix1.FindMaxElement()}");
            Console.WriteLine($"Найменший елемент матриці 2: {matrix2.FindMinElement()}");
        }

        static void AddOn()
        {
            SMatrix<int> matrix1 = new();
            SMatrix<int> matrix2 = new();
            MatrixInput(ref matrix1, ref matrix2);

            SMatrix<int> sumMatrix = matrix1 + matrix2;

            Console.WriteLine("\nОперації з матрицями:");
            Console.WriteLine("Сума матриць:");
            sumMatrix.DisplayData();
        }

        static void SubtrOn()
        {
            SMatrix<int> matrix1 = new();
            SMatrix<int> matrix2 = new();
            MatrixInput(ref matrix1, ref matrix2);

            SMatrix<int> diffMatrix = matrix1 - matrix2;

            Console.WriteLine("\nОперації з матрицями:");
            Console.WriteLine("\nРізниця матриць:");
            diffMatrix.DisplayData();
        }

        static void DetOn()
        {
            int size = 0;
            SMatrix<int> matrix1 = new();
            MatrixInput(ref matrix1, out size);
            SMDet2<double> determinantMatrix = new(size);
            Console.WriteLine($"Визначник матриці другого порядку:" +
                $" {determinantMatrix.CalculateDeterminant(matrix1)}");
        }

        static void Pause()
        {
            Console.WriteLine("Натисніть довільну клавішу, щоб продовжити.");
            Console.ReadKey();
            Console.Clear();
            SMatr();
        }
    }
}
