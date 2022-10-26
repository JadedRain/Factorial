namespace Factorial
{
    public class FactorialClass
    {
        private int _factNum { get; set; }
        private int _factorial { get; set; } = 1;
        public void SetNumber(int num)
        {
            _factNum = num;
        }

        public int CalculateFactorial()
        {
            for (int i = _factNum; i > 0; i--)
            {
                _factorial*=i;
            }

            return _factorial;
        }
    }
}