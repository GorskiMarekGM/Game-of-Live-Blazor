namespace blazorserver01.Data
{
    public class RedBall: Data.Ball
    {
        public RedBall(int x, int y, int r, BallEnvironment e) : base(x,y,r,e) {
            this.color = "#AA3939";
            this.radius = 3;
        }
    }
    //base for calling parent constructor
}