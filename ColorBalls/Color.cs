namespace ColorBalls
{
    public class Color
    {
        private int red, green, blue, alpha, greyValue;

        public Color(int red, int green, int blue, int alpha)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
            this.alpha = 100;
        }

        public int GetRed() => red;
        public int GetGreen() => green;
        public int GetBlue() => blue;
        public int GetAlpha() => alpha;

        public int SetRed(int red)
        {
            this.red = red;

            if(red > 255) red = 255;
            else if(red < 0) red = 0;
            
            return red;
        }

        public int SetGreen(int green)
        {
            this.green = green;

            if(green > 255) green = 255;
            else if(green < 0) green = 0;

            return green;
        }

        public int SetBlue(int blue)
        {
            this.blue = blue;

            if(blue > 255) blue = 255;
            else if(blue < 0) blue = 0;

            return blue;
        }

        public int SetAlpha(int alpha)
        {
            this.alpha = alpha;

            if(alpha > 255) alpha = 255;
            else if(alpha < 0) alpha = 0;

            return alpha;
        }

        public int GetGreyValue(int red, int green, int blue)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;

            greyValue = (red + green + blue) / 3;
            return greyValue;
        }
    }
}