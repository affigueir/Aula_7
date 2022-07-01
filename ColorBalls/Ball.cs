using System;
namespace ColorBalls
{
    public class Ball
    {
        Color ballColor = new Color(0,0,0,0);
        private float radius;
        private int timesThrow;

        public Ball(Color ballColor, float radius, int timesThrow)
        {
            this.ballColor = ballColor;
            this.radius = radius;
            this.timesThrow = timesThrow;
        }

        public void Pop()
        {
            radius = 0;
            System.Console.WriteLine("Oh no! Your ball popped!");;
        }

        public int ThrowMore()
        {
            if (radius != 0)
            {
                Random random = new Random();
                timesThrow += random.Next(1, 50);
            }            
            return timesThrow;
        }

        public int GetTimesThrow() => timesThrow; 
        public float GetRadius() => radius;

        public float SetRadius(float radius)
        {
            this.radius = radius;
            return radius;
        }

    }
}