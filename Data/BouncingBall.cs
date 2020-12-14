namespace blazorserver01.Data
{
    public class BouncingBall
    {
        protected string color;
        public int posx;
        public int posy;
        public int radius;
        private int colision_radius = 1;
        public Environment parent;

        public BouncingBall(int x, int y, int r, Environment e)
        {
            this.posx = x;
            this.posy = y;
            this.radius = r;
            this.color = "#4FEA00";
            this.parent = e;
        }
        public string myColor() => this.color;

        
    }
}