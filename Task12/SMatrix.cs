namespace Triangle_Pyramid
{
    class SMatrix<T>
    {
        internal T[,] elements;
        internal int size;

        // Конструктор без параметрів
        public SMatrix()
        {
            size = 0;
            elements = null;
        }

        // Конструктор з параметрами
        public SMatrix(int size)
        {
            this.size = size;
            elements = new T[size, size];
        }

        // Конструктор копіювання
        public SMatrix(SMatrix<T> other)
        {
            this.size = other.size;
            this.elements = new T[size, size];
            Array.Copy(other.elements, this.elements, size * size);
        }

        // Метод введення даних
        public void InputData()
        {
            Console.WriteLine($"Введіть елементи {size}x{size} матриці:");
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write($"Елемент[{i + 1},{j + 1}]: ");
                    elements[i, j] = (T)Convert.ChangeType(Console.ReadLine(), typeof(T));
                }
            }
        }

        // Метод виведення даних
        public void DisplayData()
        {
            Console.WriteLine($"Матриця розмірності {size}x{size}:");

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write($"{elements[i, j]} \t");
                }
                Console.WriteLine();
            }
        }

        // Метод знаходження найбільшого елемента
        public T FindMaxElement()
        {
            T maxElement = elements[0, 0];

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (Comparer<T>.Default.Compare(elements[i, j], maxElement) > 0)
                    {
                        maxElement = elements[i, j];
                    }
                }
            }

            return maxElement;
        }

        // Метод знаходження найменшого елемента
        public T FindMinElement()
        {
            T minElement = elements[0, 0];

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (Comparer<T>.Default.Compare(elements[i, j], minElement) < 0)
                    {
                        minElement = elements[i, j];
                    }
                }
            }

            return minElement;
        }

        // Перевантаження оператору +
        public static SMatrix<T> operator +(SMatrix<T> matrix1, SMatrix<T> matrix2)
        {
            if (matrix1.size != matrix2.size)
            {
                throw new ArgumentException("Розмірності матриць повинні бути однаковими для додавання.");
            }

            SMatrix<T> resultMatrix = new SMatrix<T>(matrix1.size);

            for (int i = 0; i < matrix1.size; i++)
            {
                for (int j = 0; j < matrix1.size; j++)
                {
                    dynamic element1 = matrix1.elements[i, j];
                    dynamic element2 = matrix2.elements[i, j];
                    resultMatrix.elements[i, j] = element1 + element2;
                }
            }

            return resultMatrix;
        }

        // Перевантаження оператору -
        public static SMatrix<T> operator -(SMatrix<T> matrix1, SMatrix<T> matrix2)
        {
            if (matrix1.size != matrix2.size)
            {
                throw new ArgumentException("Розмірності матриць повинні бути однаковими для віднімання.");
            }

            SMatrix<T> resultMatrix = new SMatrix<T>(matrix1.size);

            for (int i = 0; i < matrix1.size; i++)
            {
                for (int j = 0; j < matrix1.size; j++)
                {
                    dynamic element1 = matrix1.elements[i, j];
                    dynamic element2 = matrix2.elements[i, j];
                    resultMatrix.elements[i, j] = element1 - element2;
                }
            }

            return resultMatrix;
        }
    }

}
