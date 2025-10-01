using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.Kucherenkonm.Sprint1.Task7.V14.Lib
{
    public class DataService: ISprint1Task7V14
    {
        public double Calculate(double x, double y)
        {
            double x1 = Math.Pow(2, -x);
            double x2 = (5*Math.Pow(x, 2))/(3*Math.Pow(x,3));
            double x3 = Math.Cos(Math.Pow(x,2));
            double x4 = Math.Sin(2 * x * y);
            double res = x1 + x2 - x3 + x4;
            return Math.Round(res, 3, MidpointRounding.ToZero);
        }
    }
}
