using System;
namespace ColorBallsWithProperties
{
    public class Ball
    {
        Color ballColor = new Color(0,0,0,0);

        public float Radius { get; set; }
        public int TimesThrown { get; set; }

        public Ball(Color ballColor, float radius, int timesThrown)
        {
            this.ballColor = ballColor;
            Radius = radius;
            TimesThrown = timesThrown;
        }

        public void Pop()
        {
            Radius = 0;
            System.Console.WriteLine("Oh no! Your ball has popped!");
        }

        public void CheckRadius()
        {
            if (Radius == 0) Pop();
            else System.Console.WriteLine($"Your ball is filled, and has a radius of {Radius}");
        }

        public int ThrowMore()
        {
            if (Radius != 0)
            {
                Random random = new Random();
                TimesThrown += random.Next(1, 50);
            }            
            return TimesThrown;
        }

    }
}