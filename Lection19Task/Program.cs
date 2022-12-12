// See https://aka.ms/new-console-template for more information
using Lection19Task;

ICalculator calc = new ConcreteCalculator();
Console.WriteLine(calc.CalcData(3, 0, '+'));
