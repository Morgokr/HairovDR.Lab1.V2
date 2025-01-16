namespace MathExpressionClass
{
    public class MathExpressions
    {
        public float CalculateFirstExpression(int arg1, int arg2, int arg3)
        {
            var x = (float)arg1;
            var y = (float)arg2;
            var a = (float)arg3;
            return 12 * y - (3 * x + 2 * a + a) / (3 * a + 2 * x - y) + 12 * y + ((x / y + 2 + a / y) / ((2 - a + 1) / x));
        }
        public float CalculateSecondExpression(int arg1, int arg2, int arg3)
        {
            var x = (float)arg1;
            var y = (float)arg2;
            var a = (float)arg3;

            return 6 * x + ((2 * x + y - 3 * a) / (a + 2 * x - 7 * y)) + (((x + 3) / y) / ((2 - x) / x));
        }
    }
}
