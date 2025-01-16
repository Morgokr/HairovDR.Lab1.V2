using MathExpressionClass;

Console.WriteLine("*********************************************************************************************");
Console.WriteLine("Эта программа может посчитать значения двух выражений в зависимости от чисел, которые вы введёте.");
Console.WriteLine("Выражение №1: 12y - ((3x + 2a + a) / (3a + 2x - y)) + 12y + ((x / y + 2 + a / y) / ((2 - a + 1) / x))");
Console.WriteLine("Выражение №2: 6x + ((2x + y - 3a) / (a + 2x - 7y)) + (((x + 3) / y) / ((2 - x) / x))");

Console.WriteLine("Введите x:");
var x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите y:");
var y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите a:");
var a = Convert.ToInt32(Console.ReadLine());

var Calc = new MathExpressions();
Console.WriteLine("Результат первого выражения:" + Calc.CalculateFirstExpression(x, y, a));
Console.WriteLine("Результат второго выражения:" + Calc.CalculateSecondExpression(x, y, a));