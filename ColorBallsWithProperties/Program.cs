using System;

namespace ColorBallsWithProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            Color ball1Color = new Color(255,0,0,150);
            Ball ball1 = new Ball(ball1Color, 5.6f, 10);

            System.Console.WriteLine(ball1Color.Red);

            ball1Color.Red = 155;

            System.Console.WriteLine(ball1Color.Red);

            ball1.CheckRadius();

            ball1.Radius = 0;

            ball1.CheckRadius();

            System.Console.WriteLine(ball1.TimesThrown);

            ball1.ThrowMore();

            System.Console.WriteLine(ball1.TimesThrown);

            ball1.Radius = 5f;
            ball1.ThrowMore();
            
            System.Console.WriteLine(ball1.TimesThrown);
        }
    }
}
