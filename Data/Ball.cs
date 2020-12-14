namespace blazorserver01.Data
{
    public class Ball
    {        
        protected string color;
        public int posx;
        public int posy;
        public int radius;
        public BallEnvironment parent;
        public Ball(int x, int y, int r, BallEnvironment e){
            
            this.posx = x;
            this.posy = y;
            this.radius = r;
            this.color="#fafafa";
            this.parent = e;
        }
        public string myColor() => this.color;
    }
    //base for calling parent constructor
}