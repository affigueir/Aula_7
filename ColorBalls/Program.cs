using System;

namespace ColorBalls
{
    class Program
    {
        static void Main(string[] args)
        {
            Color ball1Color = new Color(15,20,200,155);
            Ball ball1 = new Ball(ball1Color, 11.3f, 5);

            System.Console.WriteLine(ball1.GetTimesThrow());
            System.Console.WriteLine(ball1.GetRadius());
            ball1.Pop();
            ball1.SetRadius(2.5f);
            ball1.ThrowMore();
            System.Console.WriteLine(ball1.GetTimesThrow());
        }
    }
}
