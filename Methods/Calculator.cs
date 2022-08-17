namespace Methods
{
    partial class Program
    {
        public class Calculator
        {
            public int Add(params int[] numbers)
            {
                return numbers.Sum();
            }
        }
    }
}