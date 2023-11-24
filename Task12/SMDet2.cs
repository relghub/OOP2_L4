namespace Triangle_Pyramid
{
    class SMDet2<T> : SMatrix<T>
    {
        // Конструктор з параметром
        public SMDet2(int size) : base(size) { }

        // Метод знаходження визначника матриці
        public T CalculateDeterminant(SMatrix<int> matrix)
        {
            dynamic a11 = matrix.elements[0, 0];
            dynamic a12 = matrix.elements[0, 1];
            dynamic a21 = matrix.elements[1, 0];
            dynamic a22 = matrix.elements[1, 1];

            return (a11 * a22) - (a12 * a21);
        }
    }
}
