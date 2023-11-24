namespace Triangle_Pyramid
{
    class RTPyramid<T> : ETriangle<T>
    {
        public RTPyramid(T sideLength) : base(sideLength) { }

        // Метод знаходження об'єму піраміди
        public double CalculateVolume()
        {
            dynamic s = base.CalculateArea();
            return s * base.sideLength / 3;
        }

        // Перевизначення методу виведення даних
        public new void DisplayData()
        {
            base.DisplayData();
            Console.WriteLine($"Об'єм піраміди: {CalculateVolume()}");
        }
    }
}
