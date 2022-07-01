namespace ColorBallsWithProperties
{
    public class Color
    {
        private int red, green, blue, alpha;
        private float greyValue;


        public int Red
        {
            get
            {
                return red;
            }

            set
            {
                this.red = value;

                if(red > 255) red = 255;
                else if(red < 0) red = 0;
            }
        }

        public int Green
        {
            get => green;
            set
            {
                this.green = value > 255 ? 255 : value < 0 ? 0 : value;
            }
        }

        public int Blue
        {
            get => blue;
            set
            {
                this.blue = value > 255 ? 255 : value < 0 ? 0 : value;
            }
        }

        public int Alpha
        {
            get => alpha;
            set
            {
                this.alpha = value > 255 ? 255 : value < 0 ? 0 : value;
            }
        }

        public float GreyValue
        {
            set
            {
                this.greyValue = value;
                value = (red + green + blue) / 3;
            }
        }

        public Color(int red, int green, int blue, int alpha)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
            this.alpha = 100;
        }
    }
}