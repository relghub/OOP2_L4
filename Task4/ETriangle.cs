namespace Triangle_Pyramid
{
    // Узагальнений клас для трикутника
    class ETriangle<T>
    {
        protected T sideLength;

        // Конструктор без параметрів
        public ETriangle()
        {
            sideLength = default(T);
        }

        // Конструктор з параметром
        public ETriangle(T sideLength)
        {
            this.sideLength = sideLength;
        }

        // Конструктор копіювання
        public ETriangle(ETriangle<T> other)
        {
            this.sideLength = other.sideLength;
        }

        // Метод введення даних
        public void InputData(T sideLength)
        {
            this.sideLength = sideLength;
        }

        // Метод виведення даних
        public void DisplayData()
        {
            Console.WriteLine($"Довжина сторони: {sideLength}");
        }

        // Метод визначення площі
        public double CalculateArea()
        {
            dynamic s = sideLength;
            return Math.Sqrt(3) / 4 * s * s;
        }

        // Метод визначення периметру
        public double CalculatePerimeter()
        {
            dynamic s = sideLength;
            return 3 * s;
        }

        // Метод порівняння з іншим трикутником
        public bool Compare(ETriangle<T> other)
        {
            dynamic s1 = sideLength;
            dynamic s2 = other.sideLength;
            return s1 == s2;
        }

        // Перевантаження оператору +
        public static ETriangle<T> operator +(ETriangle<T> t1, ETriangle<T> t2)
        {
            dynamic s1 = t1.sideLength;
            dynamic s2 = t2.sideLength;
            return new ETriangle<T>(s1 + s2);
        }

        // Перевантаження оператору -
        public static ETriangle<T> operator -(ETriangle<T> t1, ETriangle<T> t2)
        {
            dynamic s1 = t1.sideLength;
            dynamic s2 = t2.sideLength;
            return new ETriangle<T>(s1 - s2);
        }

        // Перевантаження оператору *
        public static ETriangle<T> operator *(ETriangle<T> t, int multiplier)
        {
            dynamic s = t.sideLength;
            return new ETriangle<T>(s * multiplier);
        }
    }
}